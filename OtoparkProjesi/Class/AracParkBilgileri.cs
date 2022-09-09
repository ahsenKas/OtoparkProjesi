using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OtoparkProjesi.Class
{
    public class AracParkBilgileri
    {
        public int ID { get; set; }
        public int MusteriID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string AdiSoyadi { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Telefon { get; set; }
        public int MarkaID { get; set; }
        public int TurID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Plaka { get; set; }
        public int ParkyeriID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(150)]
        public string Aciklama { get; set; }
        public DateTime GirisTarihi { get; set; }

        public virtual AracParkYerleri AracParkYerleri { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual Tur Tur { get; set; }

        public virtual Musteri Musteri { get; set; }

    }



}
