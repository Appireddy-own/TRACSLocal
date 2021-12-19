using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRACSLocal.Models;

namespace TRACSLocal.Controllers
{
    public class ABSFormController : Controller
    {
        ABSFormData formData = ABSFormDataind();
        // GET: ABSForm
        public ActionResult Index()
        {
            return View(formData);
        }
        //Get Form
        [HttpGet]
        public ViewResult CreateABSForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CreateABSForm(ABSFormModel aBSFormModel)
        {
            formData.Griddata.Add(aBSFormModel);
            return View("Index", formData);
        }

        public RedirectResult RedirectToAspx()
        {
            return Redirect("/TRACSHome.aspx");
        }
        public static ABSFormData ABSFormDataind()
        {
            List<ABSFormModel> formModelList = new List<ABSFormModel>();

            ABSFormModel formData1 = new ABSFormModel();
            formData1.IssuerName = "ABS Issuer1";
            formData1.ProjectName = "ABS Project1";
            formData1.SponsorName = "ABS Sponsor1";
            formData1.DealContacts = "ABS Deal contacts1";
            formData1.SizeofDistribution = "30";
            formModelList.Add(formData1);

            ABSFormModel formData2 = new ABSFormModel();
            formData2.IssuerName = "ABS Issuer2";
            formData2.ProjectName = "ABS Project2";
            formData2.SponsorName = "ABS Sponsor2";
            formData2.DealContacts = "ABS Deal contacts2";
            formData2.SizeofDistribution = "20";
            formModelList.Add(formData2);

            ABSFormModel formData3 = new ABSFormModel();
            formData3.IssuerName = "ABS Issuer3";
            formData3.ProjectName = "ABS Project3";
            formData3.SponsorName = "ABS Sponsor3";
            formData3.DealContacts = "ABS Deal contacts3";
            formData3.SizeofDistribution = "15";
            formModelList.Add(formData3);


            ABSFormData formData = new ABSFormData();

            formData.Griddata = formModelList;
            return formData;
        }
    }
}