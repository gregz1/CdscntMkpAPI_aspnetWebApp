
using System.Collections.Generic;
using CdscntMkpAPI_aspnetWebApp.CdscntMkpApiReference_Prod;

namespace CdscntMkpAPI_aspnetWebApp.Models
{
    public class GetProductPackageSubmissionResultRequest : Request
    {
        public ProductFilter _ProductFilter { get; set; }
        public ProductIntegrationReportMessage _ProductIntegrationReportMessage { get; set; }

        public GetProductPackageSubmissionResultRequest()
        {
            _hasParameters = true;

            _Autentication = new Autentication();
                 
            _Parameters = new Dictionary<string, string>();
            _Parameters.Add("PackageID", "");
        }        
    }
}
