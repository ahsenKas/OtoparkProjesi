using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkProjesi.Class
{
    public class Tur
    {
        public int Id { get; set; }
        public int MarkaID { get; set; }


        public string tur { get; set; }


        public virtual Marka Marka { get; set; }
        public virtual ICollection<AracParkBilgileri> AracParkBilgileris { get; set; }
        public virtual ICollection<Ucret> Ucrets { get; set; }


    }
}
