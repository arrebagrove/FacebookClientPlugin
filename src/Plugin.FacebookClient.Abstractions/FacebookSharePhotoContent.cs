﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.FacebookClient.Abstractions
{
    public class FacebookSharePhotoContent : FacebookShareContent
    {
        public FacebookSharePhotoContent(FacebookSharePhoto[] photos, Uri contentLink =null,string hashtag = null, string placeId = null, string[] peopleIds = null, string @ref = null) : base(placeId, peopleIds, @ref, hashtag, contentLink)
        {
            Photos = photos;
        }

        public FacebookSharePhoto[] Photos { get; set; }


    }
}
