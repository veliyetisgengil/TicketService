using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using TicketService.Helper.Utilites;

namespace TicketService.Ui.Utilites
{
    public class WebService : IDisposable
    {
        private readonly WebReference.Service serviceContext;
        private readonly string _kullaniciAdi = string.Empty;
        private readonly string _sifre = string.Empty;
        public WebService(string KullaniciAdi, string Sifre)
        {
            _kullaniciAdi = KullaniciAdi;
            _sifre = Sifre;
            serviceContext = new WebReference.Service();
        }

        public T RequestServiceByClass<T,TT>(TT requestClass) where T : new()
        {
            var requestXml = requestClass.Serialize();

            var ss = serviceContext.XmlIslet(StrtoXmldocument(requestXml).DocumentElement, StrtoXmldocument("<Kullanici><Adi>" + _kullaniciAdi + "</Adi><Sifre>" + _sifre + "</Sifre></Kullanici>").DocumentElement);
			var ee = XmlParser.DeserializeObject<T>(ss.OuterXml);

            return ee;
        }

        public T RequestServiceByXml<T>(string xmlRequest) where T : new()
        {

            var ss = serviceContext.XmlIslet(StrtoXmldocument(xmlRequest).DocumentElement, StrtoXmldocument("<Kullanici><Adi>" + _kullaniciAdi + "</Adi><Sifre>" + _sifre + "</Sifre></Kullanici>").DocumentElement);
            var ee = XmlParser.DeserializeObject<T>(ss.OuterXml);

            return ee;
        }

        private XmlDocument StrtoXmldocument(string str)
        {
            XmlDocument xd = new XmlDocument();
            try
            {
                string str1 = str;
                xd.LoadXml(str1);
            }
            catch
            {

            }

            return xd;
        }

        public void Dispose()
        {
            serviceContext.Abort();
            serviceContext.Dispose();
        }
    }
}