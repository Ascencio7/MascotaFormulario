using System;
using System.Collections.Generic;

namespace Formulario_Mascotas.DAE;

public partial class DatosMascota
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Raza { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Contacto { get; set; }
}
