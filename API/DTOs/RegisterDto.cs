using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "[ERRO] Um nome é necessario !")]
        public string Username { get; set; }
        [Required(ErrorMessage = "[ERRO] Uma Senha é necessaria !")]
        public string Password { get; set; }
    }
}