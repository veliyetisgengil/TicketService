using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TicketService.Model.SeferDto
{
    [Serializable, XmlRoot("Sefer")]
    public class Sefer
    {
        [XmlElement(ElementName = "FirmaNo")]
        public int FirmaNo { get; set; } = 0;
        [Required]
        [XmlElement(ElementName = "KalkisAdi")]
        public string KalkisAdi { get; set; }
        [Required]
        [XmlElement(ElementName = "VarisAdi")]
        public string VarisAdi { get; set; }
        [Required]
        [XmlElement(ElementName = "Tarih")]
        public DateTime Tarih { get; set; }

        [XmlElement(ElementName = "AraNoktaGelsin")]
        public int AraNoktaGelsin { get; set; } = 1;
        [XmlElement(ElementName = "IslemTipi")]
        public int IslemTipi { get; set; } = 0;
        [XmlElement(ElementName = "YolcuSayisi")]
        public int YolcuSayisi { get; set; } = 1;
        [XmlElement(ElementName = "Ip")]
        public string Ip { get; set; }

    }
}
