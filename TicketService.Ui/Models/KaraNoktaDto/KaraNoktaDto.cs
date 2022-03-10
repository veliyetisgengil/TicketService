using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace TicketService.Ui.Models.KaraNoktaDto
{
	[XmlRoot("KaraNokta")]
	public class KaraNokta
	{
		[XmlElement(ElementName = "ID")]
		public string ID { get; set; }
		[XmlElement(ElementName = "SeyahatSehirID")]
		public string SeyahatSehirID { get; set; }
		[XmlElement(ElementName = "Bolge")]
		public string Bolge { get; set; }
		[XmlElement(ElementName = "Ad")]
		public string Ad { get; set; }
		[XmlElement(ElementName = "Aciklama")]
		public string Aciklama { get; set; }
		[XmlElement(ElementName = "MerkezMi")]
		public string MerkezMi { get; set; }
		[XmlElement(ElementName = "BagliOlduguNoktaID")]
		public string BagliOlduguNoktaID { get; set; }
	}

	[XmlRoot("KaraNoktalar")]
	public class KaraNoktalar
	{
		[XmlElement(ElementName = "KaraNokta")]
		public List<KaraNokta> KaraNokta { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}