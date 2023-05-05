using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarOrigin { get; set; }
        public int CarPrice { get; set; }
        public int CarYear { get; set; }
        public string CarPicture { get; set; }
        public string CarDescription { get; set; }
    }
}
