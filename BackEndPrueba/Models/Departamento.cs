using System;
using System.Collections.Generic;

namespace BackEndPrueba.Models;

public partial class Departamento
{
    public int IdDep { get; set; }

    public string CodigoDep { get; set; } = null!;

    public string NombreDep { get; set; } = null!;

    public bool ActivoDep { get; set; }

    public int IdUsuarioCreacionDep { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
