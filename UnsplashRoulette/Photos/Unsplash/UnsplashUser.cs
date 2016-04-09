﻿using System.Runtime.Serialization;

namespace UnsplashRoulette.Photos.Unsplash
{
    [DataContract]
    class UnsplashUser
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "profile_image")]
        public UnsplashAvatarCollection AvatarCollection { get; set; }
    }
}
