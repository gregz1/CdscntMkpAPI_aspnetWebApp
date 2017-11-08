using System.Threading.Tasks;
using CdscntMkpAPI_aspnetWebApp.CdscntMkpApiReference_Prod;
using System.Xml.Serialization;

namespace CdscntMkpAPI_aspnetWebApp.Models
{
    public class GetProductListByIdentifierMessage : Message
    {
        public Task<ProductListByIdentifierMessage> _ProductListByIdentifierMessage { get; set; }

        public ProductFilter _ProductFilter { get; set; }

        ProductPackageRequest _ProductPackageRequest;
        public IdentifierRequest _IdentifierRequest { get; set; }

        public GetProductListByIdentifierMessage(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService(MyRequest);
            _IdentifierRequest = new IdentifierRequest();
            _IdentifierRequest.IdentifierType = IdentifierTypeEnum.EAN;
            _IdentifierRequest.ValueList = new System.Collections.Generic.List<string>();
            _IdentifierRequest.ValueList.AddRange(MyRequest._Parameters["EAN"].Split(';'));
            _ProductListByIdentifierMessage = _MarketplaceAPIService.GetProductListByIdentifierAsync(MyRequest._HeaderMessage, _IdentifierRequest);
            //XmlSerializer xmlSerializer = new XmlSerializer(_ProductListByIdentifierMessage.Result.GetType());
                            
            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }  


 
}
