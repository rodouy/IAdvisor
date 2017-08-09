using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.WebApi.Models
{
    public class OperationResult<T>
    {
        public T Data { get; set; }
        public bool IsOk { get; set; }
        public string ErrorMessage { get; set; }
    }
}