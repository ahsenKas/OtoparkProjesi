using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace OtoparkProjesi.Class
{
    public class Musteri
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string AdiSoyadi { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Telefon { get; set; }
        public DateTime Tarih { get; set; }
        public virtual ICollection<AracParkBilgileri> AracParkBilgileris { get; set; }
        public virtual ICollection<Ucret> Ucrets { get; set; }


    }

}
