using API.Teste.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Teste.Controllers
{
    [Authorize]
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
        //[Authorize(Roles = "ApiGetOnlyMala")]
        [HttpGet("/usersFake")]
        public List<UserModel> UsersFake()
        {
            return nameList;
        }

        ///// <summary>
        ///// PostAuthorization
        ///// </summary>
        ///// <param name="userModel"></param>
        ///// <returns></returns>
        //[Authorize(Roles = "ApiGetOnlyMala")]
        [HttpPost("/addUserFake")]
        public List<UserModel> AddUserFake(UserModel userModel)
        {
            nameList.Add(userModel);
            return nameList;
        }


        //[Authorize(Roles = "ApiGetOnlyMala")]
        [HttpGet("/TesteADB")]
        public IActionResult TesteADB()
        {
            return Ok(nameList);
        }
    }
}
