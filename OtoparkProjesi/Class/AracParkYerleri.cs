using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkProjesi.Class
{
    public class AracParkYerleri
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string ParkYerleri { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Durumu { get; set; }

        public virtual ICollection<AracParkBilgileri> AracParkBilgileris { get; set; }
        public virtual ICollection<Ucret> Ucrets { get; set; }

    }
}
