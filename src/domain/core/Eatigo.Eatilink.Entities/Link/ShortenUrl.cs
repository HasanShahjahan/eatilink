﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eatigo.Eatilink.Entities.Link
{
    public class ShortenUrl : BaseEntity
    {
        [BsonElement("UId")]
        public int UniqueId { get; set; }

        [BsonElement("OriginalUrl")]
        public string OriginalUrl { get; set; }

        [BsonElement("ShortUrl")]
        public string ShortUrl { get; set; }

        [BsonElement("Domain")]
        public string Domain { get; set; }

        [BsonElement("CreateDate")]
        public string CreateDate { get; set; }

        [BsonElement("ExpiryDate")]
        public string ExpiryDate { get; set; }
    }
}