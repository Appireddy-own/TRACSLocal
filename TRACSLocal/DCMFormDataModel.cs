using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TRACSLocal
{
    public class DCMFormDataModel
    {
        [DisplayName("Issuer Name")]
        public string IssuerName { get; set; }

        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
        [DisplayName("Size of Distribution")]
        public string SizeofDistribution { get; set; }
        [DisplayName("Deal Team")]
        public string DealTeam { get; set; }
    }
   
}
