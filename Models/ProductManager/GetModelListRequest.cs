using CdscntMkpAPI_aspnetWebApp.CdscntMkpApiReference_Prod;

namespace CdscntMkpAPI_aspnetWebApp.Models
{

    
    public class GetModelListRequest : Request
    {
        public ModelFilter _ModelFilter;
        public GetModelListRequest()
        {
            _ModelFilter = new ModelFilter();
            _Parameters.Add("Code Category", "");
        }

    }
}
