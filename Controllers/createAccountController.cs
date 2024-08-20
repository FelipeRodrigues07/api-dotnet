using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace api_c_.Controllers
{
    [Route("api/[controller]")]//definição da rota 
    [ApiController]//classe de conntroler
    public class createAccountController : ControllerBase
    {
        [HttpGet]
        [Route("{id}/person/{name}")]//na url , sem ser queru
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id, string name) {


            var response = new User
            {
                ID = 1,
                Age = 7,
                Name = "Felipe"

            };

            return Ok(response);
        }
    }
}
