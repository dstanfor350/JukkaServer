// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Newtonsoft.Json;

namespace JukkaServer
{
    public class Login
    {
        public string Access_token { get; set; }
        public string Token_Type { get; set; }
        public int Expires_in { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }
        public string UserId { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expires { get; set; }

        public Login()
        {
        }

        public Login(string access_Token, string token_Type, int expires_in, string firstName,
            string lastName, string emailAddress, string[] roles,
            string UID, DateTime issuedDate, DateTime expires)
        {
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
