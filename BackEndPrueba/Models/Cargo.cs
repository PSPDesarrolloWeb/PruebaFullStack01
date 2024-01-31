using System;
using System.Collections.Generic;

namespace BackEndPrueba.Models;

public partial class Cargo
{
    public int IdCg { get; set; }

    public string CodigoCg { get; set; } = null!;

    public string NombreCg { get; set; } = null!;

    public bool Activo { get; set; }

    public int IdUsuarioCreacionCg { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
