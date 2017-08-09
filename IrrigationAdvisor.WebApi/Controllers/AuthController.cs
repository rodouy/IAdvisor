using IrrigationAdvisor.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IrrigationAdvisor.WebApi.Controllers
{
    [RoutePrefix("api/Auth")]
    public class AuthController : ApiController
    {
        [Route("userName/{userName}/password/{password}")]
        public OperationResult<AuthViewModel> Get(string userName, string password)
        {
            OperationResult<AuthViewModel> result = new OperationResult<AuthViewModel>();

            try
            {
                AuthViewModel vw = new AuthViewModel()
                {
                    Token = "ffdvskdidmf5656483"
                };

                FarmViewModel farm = new FarmViewModel()
                {
                    Description = "El Venteveo",
                    FarmId = 1
                };

                FarmViewModel farm2 = new FarmViewModel()
                {
                    Description = "La casita",
                    FarmId = 2
                };

                FarmViewModel farm3 = new FarmViewModel()
                {
                    Description = "El Paraiso",
                    FarmId = 3
                };

                vw.Farms.Add(farm);
                vw.Farms.Add(farm2);
                vw.Farms.Add(farm3);

                result.IsOk = true;
                result.Data = vw;       
                    
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}