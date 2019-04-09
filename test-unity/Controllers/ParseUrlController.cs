using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using testunity.Services;

namespace testunity.Controllers
{
    [Route("{shorten}")]
    [ApiController]
    public class ParseUrlController : ControllerBase
    {
        private IUrlShortner _urlShortner;
        

        public ParseUrlController(IUrlShortner urlShortner )
        {
            _urlShortner = urlShortner;
           
        }

        [HttpGet]
        public IActionResult Get([FromRoute]string shorten)
        {

            string userAgent=HttpContext.Request.Headers["User-Agent"].ToString();
            string ipaddress = HttpContext.Connection.RemoteIpAddress.ToString();

            _urlShortner.UpdateShortenUrlDetails(shorten, userAgent,ipaddress);
            string result=_urlShortner.RedirectToLongUrl(shorten);
            return new RedirectResult(result, true);
        }

    }
}
