using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public string UserID { get; set; }

        [Required, StringLength(100)]
        public string Username { get; set; }

        [Required]
        public string ImagePath { get; set; }

    }
}