using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TRACSLocal.Models
{
    public class ABSFormModel
    {
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        [DisplayName("Issuer Name")]
        public string IssuerName { get; set; }
        [DisplayName("Sponsor Name")]
        public string SponsorName { get; set; }
        [DisplayName("Deal Contacts")]
        public string DealContacts { get; set; }
        [DisplayName("Size of Distribution")]
        public string SizeofDistribution { get; set; }
    }
    public class ABSFormData
    {
       public List<ABSFormModel> Griddata { get; set; }
    }
}