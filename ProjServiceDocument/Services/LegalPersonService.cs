using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProjServiceDocument.Services
{
    [ApiController]
    [Route("api/[controller]")]
    public class LegalPersonService : ControllerBase
    {
        [HttpGet("{document}")]
        public Rootobject Get(string document)
        {
            WebRequest request = WebRequest.Create("https://www.receitaws.com.br/v1/cnpj/" + document);
            request.Method = "GET";
            string responseFromServer = new StreamReader(request.GetResponse()
                                                                .GetResponseStream())
                                                                .ReadToEnd();
            return JsonConvert.DeserializeObject<Rootobject>(responseFromServer);
        }
    }
}
