using System.ComponentModel.DataAnnotations;

namespace EstacaoRecarga.Dominio.Enumeradores
{
    public enum Tipo
    {
        [Display(Name = "Veicular")]
        Veicular = 0,
        [Display(Name = "Móvel")]
        Movel = 1
    }
}