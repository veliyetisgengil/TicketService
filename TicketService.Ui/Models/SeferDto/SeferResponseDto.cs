using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TicketService.Model.SeferDto
{
	[Serializable, XmlRoot("NewDataSet")]
	public class NewDataSet
	{
		[XmlElement(ElementName = "Table")]
		public List<Table> Table { get; set; }
		[XmlElement(ElementName = "OTipOzellik")]
		public List<OTipOzellik> OTipOzellik { get; set; }
	}

	[XmlRoot(ElementName = "Table")]
	public class Table
	{
		[XmlElement(ElementName = "FirmaNo")]
		public string FirmaNo { get; set; }
		[XmlElement(ElementName = "FirmaAdi")]
		public string FirmaAdi { get; set; }
		[XmlElement(ElementName = "YerelSaat")]
		public string YerelSaat { get; set; }
		[XmlElement(ElementName = "YerelInternetSaat")]
		public string YerelInternetSaat { get; set; }
		[XmlElement(ElementName = "Tarih")]
		public string Tarih { get; set; }
		[XmlElement(ElementName = "GunBitimi")]
		public string GunBitimi { get; set; }
		[XmlElement(ElementName = "Saat")]
		public string Saat { get; set; }
		[XmlElement(ElementName = "HatNo")]
		public string HatNo { get; set; }
		[XmlElement(ElementName = "IlkKalkisYeri")]
		public string IlkKalkisYeri { get; set; }
		[XmlElement(ElementName = "SonVarisYeri")]
		public string SonVarisYeri { get; set; }
		[XmlElement(ElementName = "KalkisYeri")]
		public string KalkisYeri { get; set; }
		[XmlElement(ElementName = "VarisYeri")]
		public string VarisYeri { get; set; }
		[XmlElement(ElementName = "OtobusTipi")]
		public string OtobusTipi { get; set; }
		[XmlElement(ElementName = "OTipAciklamasi")]
		public string OTipAciklamasi { get; set; }
		[XmlElement(ElementName = "OtobusPlaka")]
		public string OtobusPlaka { get; set; }
		[XmlElement(ElementName = "SeyahatSuresi")]
		public string SeyahatSuresi { get; set; }
		[XmlElement(ElementName = "BiletFiyati1")]
		public string BiletFiyati1 { get; set; }
		[XmlElement(ElementName = "BiletFiyatiInternet")]
		public string BiletFiyatiInternet { get; set; }
		[XmlElement(ElementName = "Sinif_Farki")]
		public string Sinif_Farki { get; set; }
		[XmlElement(ElementName = "MaxRzvZamani")]
		public string MaxRzvZamani { get; set; }
		[XmlElement(ElementName = "SeferTipi")]
		public string SeferTipi { get; set; }
		[XmlElement(ElementName = "SeferTipiAciklamasi")]
		public string SeferTipiAciklamasi { get; set; }
		[XmlElement(ElementName = "HatSeferNo")]
		public string HatSeferNo { get; set; }
		[XmlElement(ElementName = "O_Tip_Sinif")]
		public string O_Tip_Sinif { get; set; }
		[XmlElement(ElementName = "SeferTakipNo")]
		public string SeferTakipNo { get; set; }
		[XmlElement(ElementName = "ToplamSatisAdedi")]
		public string ToplamSatisAdedi { get; set; }
		[XmlElement(ElementName = "DolulukKuraliVar")]
		public string DolulukKuraliVar { get; set; }
		[XmlElement(ElementName = "OTipOzellik")]
		public string OTipOzellik { get; set; }
		[XmlElement(ElementName = "NormalBiletFiyati")]
		public string NormalBiletFiyati { get; set; }
		[XmlElement(ElementName = "DoluSeferMi")]
		public string DoluSeferMi { get; set; }
		[XmlElement(ElementName = "ID")]
		public string ID { get; set; }
		[XmlElement(ElementName = "Vakit")]
		public string Vakit { get; set; }
	}

	[XmlRoot(ElementName = "OTipOzellik")]
	public class OTipOzellik
	{
		[XmlElement(ElementName = "O_Tip_Ozellik")]
		public string O_Tip_Ozellik { get; set; }
		[XmlElement(ElementName = "O_Tip_Ozellik_Aciklama")]
		public string O_Tip_Ozellik_Aciklama { get; set; }
		[XmlElement(ElementName = "O_Tip_Ozellik_Detay")]
		public string O_Tip_Ozellik_Detay { get; set; }
		[XmlElement(ElementName = "O_Tip_Ozellik_Icon")]
		public string O_Tip_Ozellik_Icon { get; set; }
	}
}
