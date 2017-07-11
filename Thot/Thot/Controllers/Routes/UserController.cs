using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Template.Data;

namespace Thot.Controllers.Routes
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/user")]
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new User().GetUser() );
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex); // Lança a exceção no postman
            }
        }

        //Exemplos...
        //// GET: api/User
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/User/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/User
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/User/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/User/5
        //public void Delete(int id)
        //{
        //}
    }
}
