using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OtoparkProjesi.Class
{
    public class Ucret
    {
        public int ID { get; set; }
        public int UcretId { get; set; }
        public int MusteriId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Adi_Soyadi { get; set; }
        public int MarkaID { get; set; }
        public int TurID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Plaka { get; set; }
        public int ParkyeriID { get; set; }
        public decimal saatUcreti { get; set; }

        public decimal Sure { get; set; }
        public decimal Tutar { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(150)]

        public string Aciklama { get; set; }
        public DateTime GirisTarihi { get; set; }

        public DateTime CıkısTarihi { get; set; }

        public virtual AracParkYerleri AracParkYerleri { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual Tur Tur { get; set; }

        public virtual Musteri Musteri { get; set; }

    }




}
