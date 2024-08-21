using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PACS.Models
{
    public class Result
    {
        public bool IsValid { get; set; }
        public List<ErrorObject> Errors { get; set; }
        public object JsonData { get; set; }
    }
    public class FunctionResult
    {
        public bool Valid { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public int Code { get; set; }
    }

   
    public class ErrorObject
    {
        public string Key { get; set; }
        public object ErrorMessage { get; set; }
    }

}
