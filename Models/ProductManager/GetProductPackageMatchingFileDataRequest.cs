using System.Collections.Generic;
using CdscntMkpAPI_aspnetWebApp.CdscntMkpApiReference_Prod;

namespace CdscntMkpAPI_aspnetWebApp.Models
{
    public class GetProductPackageMatchingFileDataRequest:Request
    {
        public GetProductPackageMatchingFileDataRequest()
        {
            _hasParameters = true;

            _Autentication = new Autentication();

            _Parameters = new Dictionary<string, string>();
            _Parameters.Add("PackageID", "");
        }
    }
}
