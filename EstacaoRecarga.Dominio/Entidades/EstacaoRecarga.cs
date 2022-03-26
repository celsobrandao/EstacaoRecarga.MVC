using EstacaoRecarga.Dominio.Enumeradores;

namespace EstacaoRecarga.Dominio.Entidades
{
    public class EstacaoRecarga
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}