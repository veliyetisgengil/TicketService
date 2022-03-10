using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using TicketService.Helper.Utilites;
using TicketService.Model.SeferDto;
using TicketService.Ui.Models;
using TicketService.Ui.Models.CommonDto;
using TicketService.Ui.Models.KaraNoktaDto;
using TicketService.Ui.Models.ViewModel;
using TicketService.Ui.Utilites;

namespace TicketService.Ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebService webService;
        public HomeController()
        {
            webService = new WebService(WSConfiguration.KullaniciAdi, WSConfiguration.Sifre);
        }

        public ActionResult Index()
        {
            SeferListeleViewModel seferListeleViewModel = new SeferListeleViewModel();

            var noktas = GetNoktaList();

            ViewData["KalkisAdi"] = noktas;
            ViewData["VarisAdi"] = noktas;

            return View(seferListeleViewModel);
        }

        [HttpGet]
        public ActionResult GetSeferList(Sefer seferRequest,string strTarih)
        {
            DataResult<NewDataSet> dataResult = new DataResult<NewDataSet>();

            seferRequest.Ip = Request.UserHostAddress == "::1"? "127.0.0.1" : Request.UserHostAddress;
            seferRequest.Tarih = Convert.ToDateTime(strTarih);

            if (!ModelState.IsValid)
            {
                dataResult.Success = false;
                dataResult.Message = "Lütfen GerekliAlanları Doldurunuz.";
                return View(dataResult);
            }

            var res = webService.RequestServiceByClass<NewDataSet, Sefer>(seferRequest);

            dataResult.Success = true;
            dataResult.Data = res;
            dataResult.Message = res.Table.Count > 0 ? "Seferler Başarı ile Getirildi." : "Sefer Bulunamadı";

            webService.Dispose();

            return View(dataResult);
        }


        private List<SelectListItem> GetNoktaList()
        {
            List<SelectListItem> dataResult = new List<SelectListItem>();

            try
            {
                var res = webService.RequestServiceByXml<KaraNoktalar>("<KaraNoktaGetirKomut/>");

                if (res.KaraNokta.Count > 0)
                {
                    dataResult.Add(new SelectListItem() { Text = "Lütfen Nokta Seçiniz.", Value = "0" });
                    foreach (var item in res.KaraNokta)
                    {
                        dataResult.Add(new SelectListItem() { Text = item.Ad, Value = item.ID });
                    }
                }

                return dataResult;
            }
            catch
            {
                var lst = new List<SelectListItem>
                {
                    new SelectListItem() { Text = "Nokta Bulunamadı", Value = "0" }
                };
                return lst;
            }

            finally
            {
                webService.Dispose();
            }
        }
    }

}