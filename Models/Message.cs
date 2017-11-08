using System.Collections.Generic;
using CdscntMkpAPI_aspnetWebApp.CdscntMkpApiReference_Prod;
using CdscntMkpAPI_aspnetWebApp.Models.Enumeration;
using System.Xml.Serialization;
using System;

namespace CdscntMkpAPI_aspnetWebApp.Models
{
    public class Message
    {

        public string _MessageXML { get; set; }
        public string _RequestXML { get; set; }

        public string _Token { get; set; }
        public bool _OperationSuccess { get; set; }

        protected XmlSerializer _xmlSerializer;
        public string _ErrorMessage{ get; set; }
        public  List<Error> _ErrorList { get; set; }
        public string _ErrorType { get; set; }
        public string _InnerErrorMessage { get; set; }

        protected MarketplaceAPIServiceClient _MarketplaceAPIService;

        protected InspectorBehavior _RequestInterceptor;
        public Dictionary<string, string> _Parameters { get; set; }
        protected EnvironmentEnum _Environment;
        string _EndPointAddress;
        protected ServiceBaseAPIMessage ApiMessage;
        

        public Message()
        {
            _Parameters = new Dictionary<string, string>();
            _RequestInterceptor = new InspectorBehavior();
            _OperationSuccess = true;
        }


        public void GetService()
        {
            if (_Environment == EnvironmentEnum.Production)
                _EndPointAddress = "https://wsvc.cdiscount.com/MarketplaceAPIService.svc";
            else if (_Environment == EnvironmentEnum.Local)
                _EndPointAddress = "http://localhost:8030/MarketplaceAPIService.svc";
            else if (_Environment == EnvironmentEnum.Preproduction)
                _EndPointAddress = "https://wsvc.preprod-cdiscount.com/MarketplaceAPIService.svc";
            else if (_Environment == EnvironmentEnum.Recette)
                _EndPointAddress = "https://wsvc.recette-cdiscount.com/MarketplaceAPIService.svc";

            // _MarketplaceAPIService = new MarketplaceAPIServiceClient(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, _EndPointAddress);
            //_MarketplaceAPIService.Endpoint.EndpointBehaviors.Add(_RequestInterceptor);
            _MarketplaceAPIService = new MarketplaceAPIServiceClient();
            _MarketplaceAPIService.Endpoint.Address = new System.ServiceModel.EndpointAddress(_EndPointAddress);
            //(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, _EndPointAddress);
            _MarketplaceAPIService.Endpoint.EndpointBehaviors.Add(_RequestInterceptor);


        }

        public void GetService(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            if (_Environment == EnvironmentEnum.Production)
                _EndPointAddress = "https://wsvc.cdiscount.com/MarketplaceAPIService.svc";
            else if (_Environment == EnvironmentEnum.Local)
                _EndPointAddress = "http://localhost:8030/MarketplaceAPIService.svc";
            else
                _EndPointAddress = "https://wsvc.preprod-cdiscount.com/MarketplaceAPIService.svc";



            System.Configuration.Configuration rootWebConfig1 =
                System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(null);
            if (rootWebConfig1.AppSettings.Settings.Count > 0)
            {
                System.Configuration.KeyValueConfigurationElement customSetting =
                    rootWebConfig1.AppSettings.Settings["customsetting1"];
                if (customSetting != null)
                    Console.WriteLine("customsetting1 application string = \"{0}\"",
                        customSetting.Value);
                else
                    Console.WriteLine("No customsetting1 application string");
            }






            _MarketplaceAPIService = new MarketplaceAPIServiceClient();
            _MarketplaceAPIService.Endpoint.Address = new System.ServiceModel.EndpointAddress(_EndPointAddress);
            //(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, _EndPointAddress);
            _MarketplaceAPIService.Endpoint.EndpointBehaviors.Add(_RequestInterceptor);


        }


    }
}
