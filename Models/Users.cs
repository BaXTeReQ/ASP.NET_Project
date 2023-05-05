using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
    }
}
