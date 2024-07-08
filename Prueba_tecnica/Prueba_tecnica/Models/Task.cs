using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_tecnica.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }

    //public class RegisterModel
    //{
    //    public string Email { get; set; }
    //    public string Password { get; set; }
    //    public string ConfirmPassword { get; set; }
    //}

    //public class LoginModel
    //{
    //    public string Email { get; set; }
    //    public string Password { get; set; }
    //}
}
