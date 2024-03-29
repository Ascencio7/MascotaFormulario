using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using Formulario_Mascotas.DAE;


namespace Formulario_Mascotas
{
    public partial class Form1 : Form
    {
        BaseMascotasContext context = new BaseMascotasContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarTabla()
        {
            gridMascotas.DataSource = null;
            gridMascotas.DataSource = context.DatosMascotas.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void gridMascotas_Click(object sender, EventArgs e)
        {
            txtID.Text = gridMascotas.SelectedCells[0].Value.ToString();
            txtNombre.Text = gridMascotas.SelectedCells[1].Value.ToString();
            txtApellido.Text = gridMascotas.SelectedCells[2].Value.ToString();
            txtRaza.Text = gridMascotas.SelectedCells[3].Value.ToString();
            dtpFechaNac.Text = gridMascotas.SelectedCells[4].Value.ToString();
            txtContacto.Text = gridMascotas.SelectedCells[5].Value.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DatosMascota r = new DatosMascota();

            r.Id = int.Parse(txtID.Text);
            r.Nombre = txtNombre.Text;
            r.Apellido = txtApellido.Text;
            r.Raza = txtRaza.Text;
            r.FechaNacimiento = dtpFechaNac.Value.Date;
            r.Contacto = txtContacto.Text;

            context.DatosMascotas.Add(r);
            if (context.SaveChanges() == 1)
            {
                MessageBox.Show("Datos registrados correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtRaza.Text = "";
                dtpFechaNac.Text = "";
                txtContacto.Text = "";
            }
            else
            {
                MessageBox.Show("Datos erroneos", "Registro incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtID.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtRaza.Text = "";
                dtpFechaNac.Text = "";
                txtContacto.Text = "";
            }
            cargarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "¿Deseas modificar los datos?", "Modificación en proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                var modificar = context.DatosMascotas.FirstOrDefault(p => p.Id == int.Parse(txtID.Text));

                modificar.Nombre = txtNombre.Text;
                modificar.Apellido = txtApellido.Text;
                modificar.Raza = txtRaza.Text;
                modificar.FechaNacimiento = dtpFechaNac.Value.Date;
                modificar.Contacto = txtContacto.Text;

                context.DatosMascotas.Update(modificar);
                context.SaveChanges();
                MessageBox.Show("Datos modificados correctamente", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtRaza.Text = "";
                dtpFechaNac.Text = "";
                txtContacto.Text = "";
                cargarTabla();
            }
            else
            {
                MessageBox.Show("Datos no modificados", "Modificación detenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtRaza.Text = "";
                dtpFechaNac.Text = "";
                txtContacto.Text = "";
                cargarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "¿Desea eliminar los datos?", "Eliminación en proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var eliminar = context.DatosMascotas.FirstOrDefault(p => p.Id == int.Parse(txtID.Text));

                context.DatosMascotas.Remove(eliminar);
                context.SaveChanges();

                MessageBox.Show("Datos eliminados correctamente", "Elimación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtRaza.Text = "";
                dtpFechaNac.Text = "";
                txtContacto.Text = "";
                cargarTabla();
            }
            else
            {
                MessageBox.Show("Datos no eliminados", "Eliminación detenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtRaza.Text = "";
                dtpFechaNac.Text = "";
                txtContacto.Text = "";
                cargarTabla();
            }
        }
    }
}
