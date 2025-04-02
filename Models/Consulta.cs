namespace NutriConsultoriaAPI.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Descricao { get; set; }
        public DateTime DataConsulta { get; set; }
    }
}
