// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.36.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Google Play Developer API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/android-publisher'>Google Play Developer API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20181202 (1431)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/android-publisher'>
 *              https://developers.google.com/android-publisher</a>
 *      <tr><th>Discovery Name<td>androidpublisher
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Google Play Developer API can be found at
 * <a href='https://developers.google.com/android-publisher'>https://developers.google.com/android-publisher</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.AndroidPublisher.v1
{
    /// <summary>The AndroidPublisher Service.</summary>
    public class AndroidPublisherService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AndroidPublisherService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AndroidPublisherService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            purchases = new PurchasesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "androidpublisher"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://www.googleapis.com/androidpublisher/v1/applications/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "androidpublisher/v1/applications/"; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://www.googleapis.com/batch/androidpublisher/v1"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch/androidpublisher/v1"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play Developer API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public static string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";

        }



        private readonly PurchasesResource purchases;

        /// <summary>Gets the Purchases resource.</summary>
        public virtual PurchasesResource Purchases
        {
            get { return purchases; }
        }
    }

    ///<summary>A base abstract class for AndroidPublisher requests.</summary>
    public abstract class AndroidPublisherBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new AndroidPublisherBaseServiceRequest instance.</summary>
        protected AndroidPublisherBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>An opaque string that represents a user for quota purposes. Must not exceed 40
        /// characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes AndroidPublisher parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "purchases" collection of methods.</summary>
    public class PurchasesResource
    {
        private const string Resource = "purchases";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PurchasesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Cancels a user's subscription purchase. The subscription remains valid until its expiration
        /// time.</summary>
        /// <param name="packageName">The package name of the application for which this subscription was purchased (for
        /// example, 'com.some.thing').</param>
        /// <param name="subscriptionId">The purchased subscription ID (for example,
        /// 'monthly001').</param>
        /// <param name="token">The token provided to the user's device when the subscription was
        /// purchased.</param>
        public virtual CancelRequest Cancel(string packageName, string subscriptionId, string token)
        {
            return new CancelRequest(service, packageName, subscriptionId, token);
        }

        /// <summary>Cancels a user's subscription purchase. The subscription remains valid until its expiration
        /// time.</summary>
        public class CancelRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, string packageName, string subscriptionId, string token)
                : base(service)
            {
                PackageName = packageName;
                SubscriptionId = subscriptionId;
                Token = token;
                InitParameters();
            }


            /// <summary>The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId { get; private set; }

            /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Token { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "cancel"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{packageName}/subscriptions/{subscriptionId}/purchases/{token}/cancel"; }
            }

            /// <summary>Initializes Cancel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Checks whether a user's subscription purchase is valid and returns its expiry time.</summary>
        /// <param name="packageName">The package name of the application for which this subscription was purchased (for
        /// example, 'com.some.thing').</param>
        /// <param name="subscriptionId">The purchased subscription ID (for example,
        /// 'monthly001').</param>
        /// <param name="token">The token provided to the user's device when the subscription was
        /// purchased.</param>
        public virtual GetRequest Get(string packageName, string subscriptionId, string token)
        {
            return new GetRequest(service, packageName, subscriptionId, token);
        }

        /// <summary>Checks whether a user's subscription purchase is valid and returns its expiry time.</summary>
        public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v1.Data.SubscriptionPurchase>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string packageName, string subscriptionId, string token)
                : base(service)
            {
                PackageName = packageName;
                SubscriptionId = subscriptionId;
                Token = token;
                InitParameters();
            }


            /// <summary>The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId { get; private set; }

            /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Token { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "get"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{packageName}/subscriptions/{subscriptionId}/purchases/{token}"; }
            }

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.AndroidPublisher.v1.Data
{    

    /// <summary>A SubscriptionPurchase resource indicates the status of a user's subscription purchase.</summary>
    public class SubscriptionPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the subscription will automatically be renewed when it reaches its current expiry
        /// time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRenewing")]
        public virtual System.Nullable<bool> AutoRenewing { get; set; } 

        /// <summary>Time at which the subscription was granted, in milliseconds since the Epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiationTimestampMsec")]
        public virtual System.Nullable<long> InitiationTimestampMsec { get; set; } 

        /// <summary>This kind represents a subscriptionPurchase object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Time at which the subscription will expire, in milliseconds since the Epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validUntilTimestampMsec")]
        public virtual System.Nullable<long> ValidUntilTimestampMsec { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
