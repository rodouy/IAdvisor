using IrrigationAdvisor.Authorize;
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

                Authentication auth = new Authentication(userName, password);

                if (auth.IsAuthenticated())
                {
                    string cleanUserName = userName.ToLower().Trim();
                    var user = context.Users.Where(n => n.UserName == cleanUserName).Single();

                    var farms = from uf in context.UserFarms
                                join iu in context.IrrigationUnits
                                on uf.FarmId equals iu.FarmId
                                join f in context.Farms
                                on iu.FarmId equals f.FarmId
                                join ciw in context.CropIrrigationWeathers
                                on iu.IrrigationUnitId equals ciw.IrrigationUnitId
                                where uf.UserId == user.UserId &&
                                iu.Show && ciw.SowingDate <= DateTime.Now && f.IsActive &&
                                ciw.HarvestDate >= DateTime.Now
                                select uf;

                    foreach (var f in farms)
                    {
                        FarmViewModel newFarm = new FarmViewModel()
                        {
                            Description = f.Name,
                            FarmId = f.FarmId
                        };

                        vw.Farms.Add(newFarm);
                    }
                }
                else
                {
                    throw new UnauthorizedAccessException("Usuario o contraseña invalido");
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
    }
}