using System;
using Microsoft.AspNetCore.Mvc;
using testunity.Services;
using System.Web.Http;
using testunity.Data;
namespace testunity.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class CreateShortUrlController : ControllerBase
    {
        private IUrlShortner _urlShortner;

        public CreateShortUrlController(IUrlShortner urlShortner)
        {
            _urlShortner = urlShortner;
        }

        // POST api/CreateShortUrl
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Post([Microsoft.AspNetCore.Mvc.FromBody] string originalUrl)
        {
            string result = _urlShortner.CreateTinyUrl(originalUrl);
            string shortenUrl = $"{Constants.HostName}/{result}";
            return Ok(new UrlMapDetails() { ShortenUrl = shortenUrl, OriginalUrl = originalUrl });
        }

        //Post api/UrlDetails
        [Microsoft.AspNetCore.Mvc.Route("UrlDetails")]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Details([Microsoft.AspNetCore.Mvc.FromBody]string shortenUrl)
        {
            return Ok(_urlShortner.RetrieveUrlDetails(shortenUrl));
        }


    }
}
