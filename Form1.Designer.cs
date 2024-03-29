namespace Formulario_Mascotas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            gridMascotas = new DataGridView();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpFechaNac = new DateTimePicker();
            txtContacto = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnRegistrar = new Button();
            txtRaza = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMascotas).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(gridMascotas);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 159);
            panel2.TabIndex = 1;
            // 
            // gridMascotas
            // 
            gridMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMascotas.BackgroundColor = Color.WhiteSmoke;
            gridMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMascotas.Dock = DockStyle.Fill;
            gridMascotas.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridMascotas.Location = new Point(0, 0);
            gridMascotas.MultiSelect = false;
            gridMascotas.Name = "gridMascotas";
            gridMascotas.ReadOnly = true;
            gridMascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMascotas.Size = new Size(600, 159);
            gridMascotas.TabIndex = 0;
            gridMascotas.Click += gridMascotas_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtRaza);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dtpFechaNac);
            panel3.Controls.Add(txtContacto);
            panel3.Controls.Add(txtApellido);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnModificar);
            panel3.Controls.Add(btnRegistrar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 291);
            panel3.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(244, 9);
            label7.Name = "label7";
            label7.Size = new Size(143, 15);
            label7.TabIndex = 15;
            label7.Text = "Ingrese datos de la mascota: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F);
            label6.Location = new Point(71, 256);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 14;
            label6.Text = "Contacto: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F);
            label5.Location = new Point(42, 219);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 13;
            label5.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F);
            label4.Location = new Point(84, 178);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 12;
            label4.Text = "Raza: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F);
            label3.Location = new Point(74, 130);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 11;
            label3.Text = "Apellido: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F);
            label2.Location = new Point(74, 85);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombre: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F);
            label1.Location = new Point(93, 49);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Font = new Font("Times New Roman", 9F);
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(192, 215);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(152, 21);
            dtpFechaNac.TabIndex = 8;
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Times New Roman", 9F);
            txtContacto.Location = new Point(192, 255);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(152, 21);
            txtContacto.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Times New Roman", 9F);
            txtApellido.Location = new Point(192, 129);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(152, 21);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Times New Roman", 9F);
            txtNombre.Location = new Point(192, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 21);
            txtNombre.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Font = new Font("Times New Roman", 9F);
            txtID.Location = new Point(192, 46);
            txtID.Name = "txtID";
            txtID.Size = new Size(152, 21);
            txtID.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Transparent;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(426, 215);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 51);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "      Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Black;
            btnModificar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Transparent;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(426, 141);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(137, 51);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "        Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Black;
            btnRegistrar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Transparent;
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(426, 73);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(137, 53);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "     Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Times New Roman", 9F);
            txtRaza.Location = new Point(192, 172);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(152, 21);
            txtRaza.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Formulario de mascotas";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMascotas).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView gridMascotas;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFechaNac;
        private TextBox txtContacto;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtID;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnRegistrar;
        private Label label7;
        private TextBox txtRaza;
    }
}
