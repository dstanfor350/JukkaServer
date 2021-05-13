// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace JukkaServer
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string GrantType { get; set; }

        [JsonProperty]
        public string Access_token { get; set; }

        [JsonProperty]
        public string Token_Type { get; set; }

        [JsonProperty]
        public int Expires_in { get; set; }

        [JsonProperty]
        public string FirstName { get; set; }

        [JsonProperty]
        public string LastName { get; set; }

        [JsonProperty]
        public string Email { get; set; }

        [JsonProperty]
        public string[] Roles { get; set; }

        [JsonProperty]
        public string UserId { get; set; }

        [JsonProperty]
        public DateTime Issued { get; set; }

        [JsonProperty]
        public DateTime Expires { get; set; }

        public Login()
        {
        }

        public Login(NameValueCollection loginCollection, string access_Token, string token_Type, int expires_in, string firstName,
            string lastName, string emailAddress, string[] roles,
            string UID, DateTime issuedDate, DateTime expires)
        {
            UserName = loginCollection[0];
            Password = loginCollection[1];
            GrantType = loginCollection[2];

            Access_token = access_Token;
            Token_Type = token_Type;
            Expires_in = expires_in;
            LastName = lastName;
            Email = emailAddress;
            Roles = roles;
            UserId = UID;
            Issued = issuedDate;
            Expires = expires;
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
