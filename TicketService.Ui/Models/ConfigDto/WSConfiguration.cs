using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketService.Ui.Models
{
    public static class WSConfiguration
    {
        public static string KullaniciAdi
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["WSKullaniciAdi"]; }
        }

        public static string Sifre
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["WSSifre"]; }
        }
    }
}