using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using testunity.Data;
namespace testunity.Services
{
    public interface IUrlShortner
    {
        string CreateTinyUrl(string originalUrl);
        List<UrlDetails> RetrieveUrlDetails(string shortenUrl);
        void UpdateShortenUrlDetails(string shorten, string userAgent,string ipAddress);
        string RedirectToLongUrl(string shorten);
    }
}
