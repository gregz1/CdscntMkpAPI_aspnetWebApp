﻿namespace CdscntMkpAPI_aspnetWebApp.Models
{
    public class GetAllModelListRequest : Request
    {
        public GetAllModelListMessage _GetAllModelListMessage;
        public GetAllModelListRequest()
        {
            _hasParameters = false;
        }
    }
}
