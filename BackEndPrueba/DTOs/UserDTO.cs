namespace BackEndPrueba.DTOs
{
    public class UserDTO
    {
        public string UsuarioUs { get; set; } = null!;
        public string PrimerNombreUs { get; set; } = null!;
        public string SegundoNombreUs { get; set; } = null!;
        public string PrimerApellidoUs { get; set; } = null!;
        public string SegundoApellidoUs { get; set; } = null!;
        public int IdDepartamentoUs { get; set; }
        public string NombreDepartamento { get; set; } = null!;
        public int IdCargoUs { get; set; }
        public string NombreCargo { get; set; } = null!;

    }
}
