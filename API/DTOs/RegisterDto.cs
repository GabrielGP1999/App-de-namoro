using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "[ERRO] Um nome é necessario !")]
        public string Username { get; set; }
        [Required(ErrorMessage = "[ERRO] Uma Senha é necessaria !")]
        [StringLength(9, MinimumLength = 4)]
        public string Password { get; set; }
    }
}