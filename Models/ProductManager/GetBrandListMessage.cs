﻿using System.Xml.Serialization;

namespace CdscntMkpAPI_aspnetWebApp.Models
{
    public class GetBrandListMessage : Message
    {
        public GetBrandListMessage(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService();
            var _BrandListMessage = _MarketplaceAPIService.GetBrandListAsync(MyRequest._HeaderMessage);
            XmlSerializer xmlSerializer = new XmlSerializer(_BrandListMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
