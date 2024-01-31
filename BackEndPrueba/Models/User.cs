using System;
using System.Collections.Generic;

namespace BackEndPrueba.Models;

public partial class User
{
    public string UsuarioUs { get; set; } = null!;

    public string PrimerNombreUs { get; set; } = null!;

    public string SegundoNombreUs { get; set; } = null!;

    public string PrimerApellidoUs { get; set; } = null!;

    public string SegundoApellidoUs { get; set; } = null!;

    public int IdDepartamentoUs { get; set; }

    public int IdCargoUs { get; set; }

    public virtual Cargo IdCargoUsNavigation { get; set; } = null!;

    public virtual Departamento IdDepartamentoUsNavigation { get; set; } = null!;
}
