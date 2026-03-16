using System.ComponentModel.DataAnnotations;

namespace BlazorAppTailwind.Models
{
    public class Starship
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "O nome da nave é obrigatório.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "A empresa da nave é obrigatório.")]
        public string? Company { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        public string? Phone { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Você precisa aceitar os termos de privacidade.")]
        public bool AcceptPrivacy { get; set; }
    }
}
