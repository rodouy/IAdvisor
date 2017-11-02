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
                IrrigationAdvisorWebApiEntities1 context = new IrrigationAdvisorWebApiEntities1();

                AuthViewModel vw = new AuthViewModel()
                {
                    Token = "ffdvskdidmf5656483"
                };

                string cleanUserName = userName.ToLower().Trim();
                var user = context.Users.Where(n => n.UserName == cleanUserName).Single();

                var farms = context.UserFarms.Where(n => n.UserId == user.UserId).ToList();

                foreach (var f in farms)
                {
                    FarmViewModel newFarm = new FarmViewModel()
                    {
                        Description = f.Name,
                        FarmId = f.FarmId
                    };

                    vw.Farms.Add(newFarm);
                }

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