﻿namespace ScrawlIt.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    //public class TokenManager : IClientAuthorizationTracker
    //{
    //    public IAuthorizationState GetAuthorizationState(
    //      Uri callbackUrl, string clientState)
    //    {
    //        return new AuthorizationState
    //        {
    //            Callback = callbackUrl,
    //        };
    //    }
    //}

    //public class FacebookClient : WebServerClient
    //{
    //    private static readonly
    //    AuthorizationServerDescription FacebookDescription
    //      = new AuthorizationServerDescription
    //      {
    //          TokenEndpoint
    //            = new Uri("https://graph.facebook.com/oauth/access_token"),
    //          AuthorizationEndpoint
    //            = new Uri("https://graph.facebook.com/oauth/authorize"),
    //      };

    //    /// <summary>
    //    /// Initializes a new instance of 
    //    /// the <see cref="FacebookClient"/> class.
    //    /// </summary>
    //    public FacebookClient()
    //        : base(FacebookDescription)
    //    {
    //        this.AuthorizationTracker = new TokenManager();
    //    }
    //}

    //[DataContract]
    //public class FacebookGraph
    //{
    //    private static DataContractJsonSerializer jsonSerializer
    //      = new DataContractJsonSerializer(typeof(FacebookGraph));

    //    [DataMember(Name = "id")]
    //    public long Id { get; set; }

    //    [DataMember(Name = "name")]
    //    public string Name { get; set; }

    //    [DataMember(Name = "first_name")]
    //    public string FirstName { get; set; }

    //    [DataMember(Name = "last_name")]
    //    public string LastName { get; set; }

    //    [DataMember(Name = "link")]
    //    public Uri Link { get; set; }

    //    [DataMember(Name = "birthday")]
    //    public string Birthday { get; set; }

    //    [DataMember(Name = "email")]
    //    public string Email { get; set; }

    //    public static FacebookGraph Deserialize(string json)
    //    {
    //        if (string.IsNullOrEmpty(json))
    //        {
    //            throw new ArgumentNullException("json");
    //        }
    //        return Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(json)));
    //    }

    //    public static FacebookGraph Deserialize(Stream jsonStream)
    //    {
    //        if (jsonStream == null)
    //        {
    //            throw new ArgumentNullException("jsonStream");
    //        }
    //        return (FacebookGraph)jsonSerializer.ReadObject(jsonStream);
    //    }
    //}
}