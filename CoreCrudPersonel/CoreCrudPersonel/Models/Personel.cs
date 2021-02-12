using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrudPersonel.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string personelAd { get; set; }
        public string personelSoyad { get; set; }
        public string personelSehir { get; set; }
        public int BirimID { get; set; }
        public Birim Birim { get; set; }

    }
}
