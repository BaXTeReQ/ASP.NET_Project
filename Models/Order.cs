using finalApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public double OrderPrice { get; set; }


        // zlaczenie id samochodu do zamowienia
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        // zlaczenie id usera do zamowienia
        public int UserId { get; set; }
        public virtual Users User { get; set; }
    }
}
