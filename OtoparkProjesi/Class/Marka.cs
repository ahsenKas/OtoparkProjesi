using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkProjesi.Class
{
    public class Marka
    {
        public int ID { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(30)]

        public string MarkaAdi { get; set; }

        public virtual ICollection<Tur> tur { get; set; }
        public virtual ICollection<AracParkBilgileri> AracParkBilgileris { get; set; }
        public virtual ICollection<Ucret> Ucrets { get; set; }
    }
}
