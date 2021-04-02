﻿using Eatigo.Eatilink.DataObjects.Models;
using Eatigo.Eatilink.Entities.Link;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eatigo.Eatilink.Domain.Mappers
{
    public static class ShortenUrlMapper
    {
        public static ShortenUrl ToEntity(this ShortUrlRequest model)
        {
            return new ShortenUrl()
            {
                OriginalUrl = model.OriginalUrl,
                ShortUrl = "https://" + (string.IsNullOrEmpty(model.Domain) ? "eati.go" : model.Domain) + "/" + model.ShortUrl,
                Domain = string.IsNullOrEmpty(model.Domain) ? "eati.go" : model.Domain,
                CreateDate = model.CreateDate
            };
        }
        public static ShortUrlResponse ToObject(this ShortenUrl model)
        {
            return new ShortUrlResponse()
            {
                OriginalUrl = model.OriginalUrl,
                ShortUrl = model.ShortUrl
            };
        }
    }
}
