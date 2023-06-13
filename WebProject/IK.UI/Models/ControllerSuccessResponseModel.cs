using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IK.UI.Models
{
    public class ControllerSuccessResponseModel<T>
    {

        public ControllerSuccessResponseModel(T data, string message = "", bool pageRefresh = false, string newUrl = "")
        {
            PageRefresh = pageRefresh;
            Message = message;
            NewUrl = newUrl;
            Data = data;
        }

        public bool PageRefresh { get; set; }        
        public string NewUrl { get; set; }
        public string Message { get; set; }        
        public T Data { get; set; }
    }
}
