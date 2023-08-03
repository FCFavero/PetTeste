using API.Teste.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Teste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        // Dados para teste
        List<UserModel> nameList = new List<UserModel>
        {
            new UserModel{ Id = 1, FirstName="Adriano", LastName="Malaquias"},
            new UserModel{ Id = 2, FirstName="Fabio", LastName="Favero"},
        };

        /// <summary>
        /// GetAuthorization
        /// </summary>
        /// <returns></returns>
        //[Authorize(Roles = "VemDoAzure1, VemDoAzure2")]
        [HttpGet(Name = "GetAuthorization")]
        public List<UserModel> GetAuthorization()
        {
            return nameList;
        }

        ///// <summary>
        ///// PostAuthorization
        ///// </summary>
        ///// <param name="userModel"></param>
        ///// <returns></returns>
        //[Authorize(Roles = "VemDoAzure1")]
        [HttpPost(Name = "PostAuthorization")]
        public List<UserModel> PostAuthorization(UserModel userModel)
        {
            nameList.Add(userModel);
            return nameList;
        }
    }
}
