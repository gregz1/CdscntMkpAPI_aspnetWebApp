using System.Threading.Tasks;
using CdscntMkpAPI_aspnetWebApp.CdscntMkpApiReference_Prod;



namespace CdscntMkpAPI_aspnetWebApp.Models
{
    public class GetAllAllowedCategoryTreeMessage : Message
    {        
        public Task<CategoryTreeMessage> _AllCategoryTreeMessage { get; set; }
        

        public  GetAllAllowedCategoryTreeMessage(Request MyRequest)
        {

            _Environment = MyRequest._EnvironmentSelected;
            GetService();
            _AllCategoryTreeMessage = _MarketplaceAPIService.GetAllAllowedCategoryTreeAsync(MyRequest._HeaderMessage);
            //  XmlSerializer xmlSerializer = new XmlSerializer(_AllCategoryTreeMessage.Result.GetType());
            
            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
            //_AllCategoryTreeMessage.Result.CategoryTree.

            //CategoryTree ct = new CategoryTree();
            
        }
            
    }
}
