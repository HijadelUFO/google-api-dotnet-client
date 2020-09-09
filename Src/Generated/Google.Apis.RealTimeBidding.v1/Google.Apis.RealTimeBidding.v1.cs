// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.RealTimeBidding.v1
{
    /// <summary>The RealTimeBidding Service.</summary>
    public class RealTimeBiddingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public RealTimeBiddingService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public RealTimeBiddingService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Bidders = new BiddersResource(this);
            Buyers = new BuyersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "realtimebidding";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://realtimebidding.googleapis.com/";
        #else
            "https://realtimebidding.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://realtimebidding.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Real-time Bidding API.</summary>
        public class Scope
        {
            /// <summary>See, create, edit, and delete your Authorized Buyers and Open Bidding account
            /// entities</summary>
            public static string RealtimeBidding = "https://www.googleapis.com/auth/realtime-bidding";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Real-time Bidding API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, create, edit, and delete your Authorized Buyers and Open Bidding account
            /// entities</summary>
            public const string RealtimeBidding = "https://www.googleapis.com/auth/realtime-bidding";

        }



        /// <summary>Gets the Bidders resource.</summary>
        public virtual BiddersResource Bidders { get; }

        /// <summary>Gets the Buyers resource.</summary>
        public virtual BuyersResource Buyers { get; }
    }

    ///<summary>A base abstract class for RealTimeBidding requests.</summary>
    public abstract class RealTimeBiddingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new RealTimeBiddingBaseServiceRequest instance.</summary>
        protected RealTimeBiddingBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

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
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes RealTimeBidding parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
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
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
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
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "bidders" collection of methods.</summary>
    public class BiddersResource
    {
        private const string Resource = "bidders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BiddersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Creatives = new CreativesResource(service);

        }

        /// <summary>Gets the Creatives resource.</summary>
        public virtual CreativesResource Creatives { get; }

        /// <summary>The "creatives" collection of methods.</summary>
        public class CreativesResource
        {
            private const string Resource = "creatives";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CreativesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Lists creatives.</summary>
            /// <param name="parent">Required. Name of the parent buyer that owns the creatives. The pattern for this resource is
            /// either `buyers/{buyerAccountId}` or `bidders/{bidderAccountId}`. For `buyers/{buyerAccountId}`, the `buyerAccountId`
            /// can be one of the following: 1. The ID of the buyer that is accessing their own creatives. 2. The ID of the child
            /// seat buyer under a bidder account. So for listing creatives pertaining to the child seat buyer (`456`) under bidder
            /// account (`123`), you would use the pattern: `buyers/456`. 3. The ID of the bidder itself. So for listing creatives
            /// pertaining to bidder (`123`), you would use `buyers/123`. If you want to access all creatives pertaining to both the
            /// bidder and all of its child seat accounts, you would use `bidders/{bidderAccountId}`, e.g., for all creatives
            /// pertaining to bidder (`123`), use `bidders/123`.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists creatives.</summary>
            public class ListRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.ListCreativesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent)
                    : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. Name of the parent buyer that owns the creatives. The pattern for this resource
                /// is either `buyers/{buyerAccountId}` or `bidders/{bidderAccountId}`. For `buyers/{buyerAccountId}`,
                /// the `buyerAccountId` can be one of the following: 1. The ID of the buyer that is accessing their own
                /// creatives. 2. The ID of the child seat buyer under a bidder account. So for listing creatives
                /// pertaining to the child seat buyer (`456`) under bidder account (`123`), you would use the pattern:
                /// `buyers/456`. 3. The ID of the bidder itself. So for listing creatives pertaining to bidder (`123`),
                /// you would use `buyers/123`. If you want to access all creatives pertaining to both the bidder and
                /// all of its child seat accounts, you would use `bidders/{bidderAccountId}`, e.g., for all creatives
                /// pertaining to bidder (`123`), use `bidders/123`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Query string to filter creatives. If no filter is specified, all active creatives will be
                /// returned. Example: 'accountId=12345 AND (dealsStatus:DISAPPROVED AND
                /// disapprovalReason:UNACCEPTABLE_CONTENT) OR declaredAttributes:IS_COOKIE_TARGETED'</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Requested page size. The server may return fewer creatives than requested (due to timeout
                /// constraint) even if more are available via another call. If unspecified, server will pick an
                /// appropriate default. Acceptable values are 1 to 1000, inclusive.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of ListCreativesResponse.nextPageToken returned from the previous call to the 'ListCreatives'
                /// method.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Controls the amount of information included in the response. By default only
                /// creativeServingDecision is included. To retrieve the entire creative resource (including the
                /// declared fields and the creative content) specify the view as "FULL".</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Controls the amount of information included in the response. By default only
                /// creativeServingDecision is included. To retrieve the entire creative resource (including the
                /// declared fields and the creative content) specify the view as "FULL".</summary>
                public enum ViewEnum
                {
                    /// <summary>Not specified, equivalent to SERVING_DECISION_ONLY.</summary>
                    [Google.Apis.Util.StringValueAttribute("CREATIVE_VIEW_UNSPECIFIED")]
                    CREATIVEVIEWUNSPECIFIED,
                    /// <summary>Only creativeServingDecision is included in the response.</summary>
                    [Google.Apis.Util.StringValueAttribute("SERVING_DECISION_ONLY")]
                    SERVINGDECISIONONLY,
                    /// <summary>The entire creative resource (including the declared fields and the creative content)
                    /// is included in the response.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL,
                }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/creatives";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+$",
                        });
                    RequestParameters.Add(
                        "filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Watches all creatives pertaining to a bidder. It is sufficient to invoke this endpoint once per
            /// bidder. A Pub/Sub topic will be created and notifications will be pushed to the topic when any of the
            /// bidder's creatives change status. All of the bidder's service accounts will have access to read from the
            /// topic. Subsequent invocations of this method will return the existing Pub/Sub configuration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. To watch all creatives pertaining to the bidder and all its child seat accounts, the
            /// bidder must follow the pattern `bidders/{bidderAccountId}`.</param>
            public virtual WatchRequest Watch(Google.Apis.RealTimeBidding.v1.Data.WatchCreativesRequest body, string parent)
            {
                return new WatchRequest(service, body, parent);
            }

            /// <summary>Watches all creatives pertaining to a bidder. It is sufficient to invoke this endpoint once per
            /// bidder. A Pub/Sub topic will be created and notifications will be pushed to the topic when any of the
            /// bidder's creatives change status. All of the bidder's service accounts will have access to read from the
            /// topic. Subsequent invocations of this method will return the existing Pub/Sub configuration.</summary>
            public class WatchRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.WatchCreativesResponse>
            {
                /// <summary>Constructs a new Watch request.</summary>
                public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.RealTimeBidding.v1.Data.WatchCreativesRequest body, string parent)
                    : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. To watch all creatives pertaining to the bidder and all its child seat accounts,
                /// the bidder must follow the pattern `bidders/{bidderAccountId}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RealTimeBidding.v1.Data.WatchCreativesRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "watch";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/creatives:watch";

                /// <summary>Initializes Watch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^bidders/[^/]+$",
                        });
                }

            }
        }
    }

    /// <summary>The "buyers" collection of methods.</summary>
    public class BuyersResource
    {
        private const string Resource = "buyers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BuyersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Creatives = new CreativesResource(service);
            UserLists = new UserListsResource(service);

        }

        /// <summary>Gets the Creatives resource.</summary>
        public virtual CreativesResource Creatives { get; }

        /// <summary>The "creatives" collection of methods.</summary>
        public class CreativesResource
        {
            private const string Resource = "creatives";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CreativesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates a creative.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The name of the parent buyer that the new creative belongs to that must follow the
            /// pattern `buyers/{buyerAccountId}`, where `{buyerAccountId}` represents the account ID of the buyer who owns a
            /// creative. For a bidder accessing creatives on behalf of a child seat buyer, `{buyerAccountId}` should represent the
            /// account ID of the child seat buyer.</param>
            public virtual CreateRequest Create(Google.Apis.RealTimeBidding.v1.Data.Creative body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a creative.</summary>
            public class CreateRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.Creative>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.RealTimeBidding.v1.Data.Creative body, string parent)
                    : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the parent buyer that the new creative belongs to that must follow
                /// the pattern `buyers/{buyerAccountId}`, where `{buyerAccountId}` represents the account ID of the
                /// buyer who owns a creative. For a bidder accessing creatives on behalf of a child seat buyer,
                /// `{buyerAccountId}` should represent the account ID of the child seat buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RealTimeBidding.v1.Data.Creative Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/creatives";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+$",
                        });
                }

            }

            /// <summary>Gets a creative.</summary>
            /// <param name="name">Required. Name of the creative to retrieve. See creative.name.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a creative.</summary>
            public class GetRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.Creative>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. Name of the creative to retrieve. See creative.name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Controls the amount of information included in the response. By default only
                /// creativeServingDecision is included. To retrieve the entire creative resource (including the
                /// declared fields and the creative content) specify the view as "FULL".</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Controls the amount of information included in the response. By default only
                /// creativeServingDecision is included. To retrieve the entire creative resource (including the
                /// declared fields and the creative content) specify the view as "FULL".</summary>
                public enum ViewEnum
                {
                    /// <summary>Not specified, equivalent to SERVING_DECISION_ONLY.</summary>
                    [Google.Apis.Util.StringValueAttribute("CREATIVE_VIEW_UNSPECIFIED")]
                    CREATIVEVIEWUNSPECIFIED,
                    /// <summary>Only creativeServingDecision is included in the response.</summary>
                    [Google.Apis.Util.StringValueAttribute("SERVING_DECISION_ONLY")]
                    SERVINGDECISIONONLY,
                    /// <summary>The entire creative resource (including the declared fields and the creative content)
                    /// is included in the response.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL,
                }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/creatives/[^/]+$",
                        });
                    RequestParameters.Add(
                        "view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Lists creatives.</summary>
            /// <param name="parent">Required. Name of the parent buyer that owns the creatives. The pattern for this resource is
            /// either `buyers/{buyerAccountId}` or `bidders/{bidderAccountId}`. For `buyers/{buyerAccountId}`, the `buyerAccountId`
            /// can be one of the following: 1. The ID of the buyer that is accessing their own creatives. 2. The ID of the child
            /// seat buyer under a bidder account. So for listing creatives pertaining to the child seat buyer (`456`) under bidder
            /// account (`123`), you would use the pattern: `buyers/456`. 3. The ID of the bidder itself. So for listing creatives
            /// pertaining to bidder (`123`), you would use `buyers/123`. If you want to access all creatives pertaining to both the
            /// bidder and all of its child seat accounts, you would use `bidders/{bidderAccountId}`, e.g., for all creatives
            /// pertaining to bidder (`123`), use `bidders/123`.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists creatives.</summary>
            public class ListRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.ListCreativesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent)
                    : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. Name of the parent buyer that owns the creatives. The pattern for this resource
                /// is either `buyers/{buyerAccountId}` or `bidders/{bidderAccountId}`. For `buyers/{buyerAccountId}`,
                /// the `buyerAccountId` can be one of the following: 1. The ID of the buyer that is accessing their own
                /// creatives. 2. The ID of the child seat buyer under a bidder account. So for listing creatives
                /// pertaining to the child seat buyer (`456`) under bidder account (`123`), you would use the pattern:
                /// `buyers/456`. 3. The ID of the bidder itself. So for listing creatives pertaining to bidder (`123`),
                /// you would use `buyers/123`. If you want to access all creatives pertaining to both the bidder and
                /// all of its child seat accounts, you would use `bidders/{bidderAccountId}`, e.g., for all creatives
                /// pertaining to bidder (`123`), use `bidders/123`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Query string to filter creatives. If no filter is specified, all active creatives will be
                /// returned. Example: 'accountId=12345 AND (dealsStatus:DISAPPROVED AND
                /// disapprovalReason:UNACCEPTABLE_CONTENT) OR declaredAttributes:IS_COOKIE_TARGETED'</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Requested page size. The server may return fewer creatives than requested (due to timeout
                /// constraint) even if more are available via another call. If unspecified, server will pick an
                /// appropriate default. Acceptable values are 1 to 1000, inclusive.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results the server should return. Typically, this is the
                /// value of ListCreativesResponse.nextPageToken returned from the previous call to the 'ListCreatives'
                /// method.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Controls the amount of information included in the response. By default only
                /// creativeServingDecision is included. To retrieve the entire creative resource (including the
                /// declared fields and the creative content) specify the view as "FULL".</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Controls the amount of information included in the response. By default only
                /// creativeServingDecision is included. To retrieve the entire creative resource (including the
                /// declared fields and the creative content) specify the view as "FULL".</summary>
                public enum ViewEnum
                {
                    /// <summary>Not specified, equivalent to SERVING_DECISION_ONLY.</summary>
                    [Google.Apis.Util.StringValueAttribute("CREATIVE_VIEW_UNSPECIFIED")]
                    CREATIVEVIEWUNSPECIFIED,
                    /// <summary>Only creativeServingDecision is included in the response.</summary>
                    [Google.Apis.Util.StringValueAttribute("SERVING_DECISION_ONLY")]
                    SERVINGDECISIONONLY,
                    /// <summary>The entire creative resource (including the declared fields and the creative content)
                    /// is included in the response.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL,
                }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/creatives";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+$",
                        });
                    RequestParameters.Add(
                        "filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Updates a creative.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Name of the creative to update. See creative.name.</param>
            public virtual PatchRequest Patch(Google.Apis.RealTimeBidding.v1.Data.Creative body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a creative.</summary>
            public class PatchRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.Creative>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.RealTimeBidding.v1.Data.Creative body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Name of the creative to update. See creative.name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Field mask to use for partial in-place updates.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RealTimeBidding.v1.Data.Creative Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/creatives/[^/]+$",
                        });
                    RequestParameters.Add(
                        "updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }
        /// <summary>Gets the UserLists resource.</summary>
        public virtual UserListsResource UserLists { get; }

        /// <summary>The "userLists" collection of methods.</summary>
        public class UserListsResource
        {
            private const string Resource = "userLists";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UserListsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Change the status of a user list to CLOSED. This prevents new users from being added to the
            /// user list.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the user list to close. See UserList.name</param>
            public virtual CloseRequest Close(Google.Apis.RealTimeBidding.v1.Data.CloseUserListRequest body, string name)
            {
                return new CloseRequest(service, body, name);
            }

            /// <summary>Change the status of a user list to CLOSED. This prevents new users from being added to the
            /// user list.</summary>
            public class CloseRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.UserList>
            {
                /// <summary>Constructs a new Close request.</summary>
                public CloseRequest(Google.Apis.Services.IClientService service, Google.Apis.RealTimeBidding.v1.Data.CloseUserListRequest body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the user list to close. See UserList.name</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RealTimeBidding.v1.Data.CloseUserListRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "close";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:close";

                /// <summary>Initializes Close parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/userLists/[^/]+$",
                        });
                }

            }

            /// <summary>Create a new user list.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The name of the parent buyer of the user list to be retrieved that must follow the
            /// pattern `buyers/{buyerAccountId}`, where `{buyerAccountId}` represents the account ID of the buyer who owns user
            /// lists. For a bidder accessing user lists on behalf of a child seat buyer , `{buyerAccountId}` should represent the
            /// account ID of the child seat buyer.</param>
            public virtual CreateRequest Create(Google.Apis.RealTimeBidding.v1.Data.UserList body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Create a new user list.</summary>
            public class CreateRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.UserList>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.RealTimeBidding.v1.Data.UserList body, string parent)
                    : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the parent buyer of the user list to be retrieved that must follow
                /// the pattern `buyers/{buyerAccountId}`, where `{buyerAccountId}` represents the account ID of the
                /// buyer who owns user lists. For a bidder accessing user lists on behalf of a child seat buyer ,
                /// `{buyerAccountId}` should represent the account ID of the child seat buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RealTimeBidding.v1.Data.UserList Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/userLists";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+$",
                        });
                }

            }

            /// <summary>Gets a user list by its name.</summary>
            /// <param name="name">Required. The name of the user list to be retrieved. See UserList.name.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a user list by its name.</summary>
            public class GetRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.UserList>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. The name of the user list to be retrieved. See UserList.name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/userLists/[^/]+$",
                        });
                }

            }

            /// <summary>Gets remarketing tag for a buyer. A remarketing tag is a piece of JavaScript code that can be
            /// placed on a web page. When a user visits a page containing a remarketing tag, Google adds the user to a
            /// user list.</summary>
            /// <param name="name">Required. To fetch remarketing tag for an account, name must follow the pattern
            /// `buyers/{accountId}` where `{accountId}` represents ID of a buyer that owns the remarketing tag. For a bidder
            /// accessing remarketing tag on behalf of a child seat buyer, `{accountId}` should represent the ID of the child seat
            /// buyer. To fetch remarketing tag for a specific user list, name must follow the pattern
            /// `buyers/{accountId}/userLists/{userListId}`. See UserList.name.</param>
            public virtual GetRemarketingTagRequest GetRemarketingTag(string name)
            {
                return new GetRemarketingTagRequest(service, name);
            }

            /// <summary>Gets remarketing tag for a buyer. A remarketing tag is a piece of JavaScript code that can be
            /// placed on a web page. When a user visits a page containing a remarketing tag, Google adds the user to a
            /// user list.</summary>
            public class GetRemarketingTagRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.GetRemarketingTagResponse>
            {
                /// <summary>Constructs a new GetRemarketingTag request.</summary>
                public GetRemarketingTagRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. To fetch remarketing tag for an account, name must follow the pattern
                /// `buyers/{accountId}` where `{accountId}` represents ID of a buyer that owns the remarketing tag. For
                /// a bidder accessing remarketing tag on behalf of a child seat buyer, `{accountId}` should represent
                /// the ID of the child seat buyer. To fetch remarketing tag for a specific user list, name must follow
                /// the pattern `buyers/{accountId}/userLists/{userListId}`. See UserList.name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "getRemarketingTag";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:getRemarketingTag";

                /// <summary>Initializes GetRemarketingTag parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/userLists/[^/]+$",
                        });
                }

            }

            /// <summary>Lists the user lists visible to the current user.</summary>
            /// <param name="parent">Required. The name of the parent buyer for the user lists to be returned that must follow the
            /// pattern `buyers/{buyerAccountId}`, where `{buyerAccountId}` represents the account ID of the buyer who owns user
            /// lists. For a bidder accessing user lists on behalf of a child seat buyer , `{buyerAccountId}` should represent the
            /// account ID of the child seat buyer.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the user lists visible to the current user.</summary>
            public class ListRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.ListUserListsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent)
                    : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. The name of the parent buyer for the user lists to be returned that must follow
                /// the pattern `buyers/{buyerAccountId}`, where `{buyerAccountId}` represents the account ID of the
                /// buyer who owns user lists. For a bidder accessing user lists on behalf of a child seat buyer ,
                /// `{buyerAccountId}` should represent the account ID of the child seat buyer.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The number of results to return per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Continuation page token (as received from a previous response).</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/userLists";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+$",
                        });
                    RequestParameters.Add(
                        "pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Change the status of a user list to OPEN. This allows new users to be added to the user
            /// list.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the user list to open. See UserList.name</param>
            public virtual OpenRequest Open(Google.Apis.RealTimeBidding.v1.Data.OpenUserListRequest body, string name)
            {
                return new OpenRequest(service, body, name);
            }

            /// <summary>Change the status of a user list to OPEN. This allows new users to be added to the user
            /// list.</summary>
            public class OpenRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.UserList>
            {
                /// <summary>Constructs a new Open request.</summary>
                public OpenRequest(Google.Apis.Services.IClientService service, Google.Apis.RealTimeBidding.v1.Data.OpenUserListRequest body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the user list to open. See UserList.name</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RealTimeBidding.v1.Data.OpenUserListRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "open";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:open";

                /// <summary>Initializes Open parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/userLists/[^/]+$",
                        });
                }

            }

            /// <summary>Update the given user list. Only user lists with URLRestrictions can be updated.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Output only. Name of the user list that must follow the pattern
            /// `buyers/{buyer}/userLists/{user_list}`, where `{buyer}` represents the account ID of the buyer who owns the user
            /// list. For a bidder accessing user lists on behalf of a child seat buyer, `{buyer}` represents the account ID of the
            /// child seat buyer. `{user_list}` is an int64 identifier assigned by Google to uniquely identify a user
            /// list.</param>
            public virtual UpdateRequest Update(Google.Apis.RealTimeBidding.v1.Data.UserList body, string name)
            {
                return new UpdateRequest(service, body, name);
            }

            /// <summary>Update the given user list. Only user lists with URLRestrictions can be updated.</summary>
            public class UpdateRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.UserList>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.RealTimeBidding.v1.Data.UserList body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. Name of the user list that must follow the pattern
                /// `buyers/{buyer}/userLists/{user_list}`, where `{buyer}` represents the account ID of the buyer who
                /// owns the user list. For a bidder accessing user lists on behalf of a child seat buyer, `{buyer}`
                /// represents the account ID of the child seat buyer. `{user_list}` is an int64 identifier assigned by
                /// Google to uniquely identify a user list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RealTimeBidding.v1.Data.UserList Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "update";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^buyers/[^/]+/userLists/[^/]+$",
                        });
                }

            }
        }

        /// <summary>Gets remarketing tag for a buyer. A remarketing tag is a piece of JavaScript code that can be
        /// placed on a web page. When a user visits a page containing a remarketing tag, Google adds the user to a user
        /// list.</summary>
        /// <param name="name">Required. To fetch remarketing tag for an account, name must follow the pattern
        /// `buyers/{accountId}` where `{accountId}` represents ID of a buyer that owns the remarketing tag. For a bidder
        /// accessing remarketing tag on behalf of a child seat buyer, `{accountId}` should represent the ID of the child seat
        /// buyer. To fetch remarketing tag for a specific user list, name must follow the pattern
        /// `buyers/{accountId}/userLists/{userListId}`. See UserList.name.</param>
        public virtual GetRemarketingTagRequest GetRemarketingTag(string name)
        {
            return new GetRemarketingTagRequest(service, name);
        }

        /// <summary>Gets remarketing tag for a buyer. A remarketing tag is a piece of JavaScript code that can be
        /// placed on a web page. When a user visits a page containing a remarketing tag, Google adds the user to a user
        /// list.</summary>
        public class GetRemarketingTagRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1.Data.GetRemarketingTagResponse>
        {
            /// <summary>Constructs a new GetRemarketingTag request.</summary>
            public GetRemarketingTagRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>Required. To fetch remarketing tag for an account, name must follow the pattern
            /// `buyers/{accountId}` where `{accountId}` represents ID of a buyer that owns the remarketing tag. For a
            /// bidder accessing remarketing tag on behalf of a child seat buyer, `{accountId}` should represent the ID
            /// of the child seat buyer. To fetch remarketing tag for a specific user list, name must follow the pattern
            /// `buyers/{accountId}/userLists/{userListId}`. See UserList.name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "getRemarketingTag";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:getRemarketingTag";

            /// <summary>Initializes GetRemarketingTag parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^buyers/[^/]+$",
                    });
            }

        }
    }
}

namespace Google.Apis.RealTimeBidding.v1.Data
{    

    /// <summary>Detected ad technology provider information.</summary>
    public class AdTechnologyProviders : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detected ad technology provider IDs for this creative. See https://storage.googleapis.com/adx-
        /// rtb-dictionaries/providers.csv for mapping of provider ID to provided name, a privacy policy URL, and a list
        /// of domains which can be attributed to the provider. If the creative contains provider IDs that are outside
        /// of those listed in the `BidRequest.adslot.consented_providers_settings.consented_providers` field on the
        /// [Google bid protocol](https://developers.google.com/authorized-buyers/rtb/downloads/realtime-bidding-proto)
        /// and the `BidRequest.user.ext.consented_providers_settings.consented_providers` field on the [OpenRTB
        /// protocol](https://developers.google.com/authorized-buyers/rtb/downloads/openrtb-adx-proto), and a bid is
        /// submitted with that creative for an impression that will serve to an EEA user, the bid will be filtered
        /// before the auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedProviderIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> DetectedProviderIds { get; set; } 

        /// <summary>Whether the creative contains an unidentified ad technology provider. If true for a given creative,
        /// any bid submitted with that creative for an impression that will serve to an EEA user will be filtered
        /// before the auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUnidentifiedProvider")]
        public virtual System.Nullable<bool> HasUnidentifiedProvider { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Detected advertiser and brand information.</summary>
    public class AdvertiserAndBrand : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>See https://storage.googleapis.com/adx-rtb-dictionaries/advertisers.txt for the list of possible
        /// values. Can be used to filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; } 

        /// <summary>Advertiser name. Can be used to filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserName")]
        public virtual string AdvertiserName { get; set; } 

        /// <summary>Detected brand ID or zero if no brand has been detected. See https://storage.googleapis.com/adx-
        /// rtb-dictionaries/brands.txt for the list of possible values. Can be used to filter the response of the
        /// creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brandId")]
        public virtual System.Nullable<long> BrandId { get; set; } 

        /// <summary>Brand name. Can be used to filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brandName")]
        public virtual string BrandName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request to close a specified user list.</summary>
    public class CloseUserListRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A creative and its classification data.</summary>
    public class Creative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. ID of the buyer account that this creative is owned by. Can be used to filter the
        /// response of the creatives.list method with equality and inequality check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<long> AccountId { get; set; } 

        /// <summary>The link to AdChoices destination page. This is only supported for native ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adChoicesDestinationUrl")]
        public virtual string AdChoicesDestinationUrl { get; set; } 

        /// <summary>The name of the company being advertised in the creative. Can be used to filter the response of the
        /// creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserName")]
        public virtual string AdvertiserName { get; set; } 

        /// <summary>The agency ID for this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agencyId")]
        public virtual System.Nullable<long> AgencyId { get; set; } 

        /// <summary>Output only. The last update timestamp of the creative via API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiUpdateTime")]
        public virtual object ApiUpdateTime { get; set; } 

        /// <summary>Output only. The format of this creative. Can be used to filter the response of the creatives.list
        /// method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeFormat")]
        public virtual string CreativeFormat { get; set; } 

        /// <summary>Buyer-specific creative ID that references this creative in bid responses. This field is Ignored in
        /// update operations. Can be used to filter the response of the creatives.list method. The maximum length of
        /// the creative ID is 128 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeId")]
        public virtual string CreativeId { get; set; } 

        /// <summary>Output only. Top level status and detected attributes of a creative (for example domain, language,
        /// advertiser, product category, etc.) that affect whether (status) and where (context) a creative will be
        /// allowed to serve.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeServingDecision")]
        public virtual CreativeServingDecision CreativeServingDecision { get; set; } 

        /// <summary>Output only. IDs of all of the deals with which this creative has been used in bidding. Can be used
        /// to filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealIds")]
        public virtual System.Collections.Generic.IList<string> DealIds { get; set; } 

        /// <summary>All declared attributes for the ads that may be shown from this creative. Can be used to filter the
        /// response of the creatives.list method. If the `excluded_attribute` field of a [bid
        /// request](https://developers.google.com/authorized-buyers/rtb/downloads/realtime-bidding-proto") contains one
        /// of the attributes that were declared or detected for a given creative, and a bid is submitted with that
        /// creative, the bid will be filtered before the auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("declaredAttributes")]
        public virtual System.Collections.Generic.IList<string> DeclaredAttributes { get; set; } 

        /// <summary>The set of declared destination URLs for the creative. Can be used to filter the response of the
        /// creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("declaredClickThroughUrls")]
        public virtual System.Collections.Generic.IList<string> DeclaredClickThroughUrls { get; set; } 

        /// <summary>All declared restricted categories for the ads that may be shown from this creative. Can be used to
        /// filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("declaredRestrictedCategories")]
        public virtual System.Collections.Generic.IList<string> DeclaredRestrictedCategories { get; set; } 

        /// <summary>IDs for the declared ad technology vendors that may be used by this creative. See
        /// https://storage.googleapis.com/adx-rtb-dictionaries/vendors.txt for possible values. Can be used to filter
        /// the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("declaredVendorIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DeclaredVendorIds { get; set; } 

        /// <summary>An HTML creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("html")]
        public virtual HtmlContent Html { get; set; } 

        /// <summary>The set of URLs to be called to record an impression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionTrackingUrls")]
        public virtual System.Collections.Generic.IList<string> ImpressionTrackingUrls { get; set; } 

        /// <summary>Output only. Name of the creative. Follows the pattern `buyers/{buyer}/creatives/{creative}`, where
        /// `{buyer}` represents the account ID of the buyer who owns the creative, and `{creative}` is the buyer-
        /// specific creative ID that references this creative in the bid response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>A native creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("native")]
        public virtual NativeContent Native { get; set; } 

        /// <summary>All restricted categories for the ads that may be shown from this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedCategories")]
        public virtual System.Collections.Generic.IList<string> RestrictedCategories { get; set; } 

        /// <summary>Output only. The version of this creative. Version for a new creative is 1 and it increments during
        /// subsequent creative updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; } 

        /// <summary>A video creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("video")]
        public virtual VideoContent Video { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Top level status and detected attributes of a creative.</summary>
    public class CreativeServingDecision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detected ad technology providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adTechnologyProviders")]
        public virtual AdTechnologyProviders AdTechnologyProviders { get; set; } 

        /// <summary>The serving status of this creative in China. When approved or disapproved, this status applies to
        /// both deals and open auction in China. When pending review, this creative is allowed to serve for deals but
        /// not for open auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chinaServingStatus")]
        public virtual ServingStatus ChinaServingStatus { get; set; } 

        /// <summary>Status of this creative when bidding on PG and PD deals (outside of Russia and China).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealsServingStatus")]
        public virtual ServingStatus DealsServingStatus { get; set; } 

        /// <summary>Detected advertisers and brands.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedAdvertisers")]
        public virtual System.Collections.Generic.IList<AdvertiserAndBrand> DetectedAdvertisers { get; set; } 

        /// <summary>Publisher-excludable attributes that were detected for this creative. Can be used to filter the
        /// response of the creatives.list method. If the `excluded_attribute` field of a [bid
        /// request](https://developers.google.com/authorized-buyers/rtb/downloads/realtime-bidding-proto) contains one
        /// of the attributes that were declared or detected for a given creative, and a bid is submitted with that
        /// creative, the bid will be filtered before the auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedAttributes")]
        public virtual System.Collections.Generic.IList<string> DetectedAttributes { get; set; } 

        /// <summary>The set of detected destination URLs for the creative. Can be used to filter the response of the
        /// creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedClickThroughUrls")]
        public virtual System.Collections.Generic.IList<string> DetectedClickThroughUrls { get; set; } 

        /// <summary>The detected domains for this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedDomains")]
        public virtual System.Collections.Generic.IList<string> DetectedDomains { get; set; } 

        /// <summary>The detected languages for this creative. The order is arbitrary. The codes are 2 or 5 characters
        /// and are documented at https://developers.google.com/adwords/api/docs/appendix/languagecodes. Can be used to
        /// filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<string> DetectedLanguages { get; set; } 

        /// <summary>Detected product categories, if any. See the ad-product-categories.txt file in the technical
        /// documentation for a list of IDs. Can be used to filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedProductCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DetectedProductCategories { get; set; } 

        /// <summary>Detected sensitive categories, if any. Can be used to filter the response of the creatives.list
        /// method. See the ad-sensitive-categories.txt file in the technical documentation for a list of IDs. You
        /// should use these IDs along with the excluded-sensitive-category field in the bid request to filter your
        /// bids.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedSensitiveCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DetectedSensitiveCategories { get; set; } 

        /// <summary>IDs of the ad technology vendors that were detected to be used by this creative. See
        /// https://storage.googleapis.com/adx-rtb-dictionaries/vendors.txt for possible values. Can be used to filter
        /// the response of the creatives.list method. If the `allowed_vendor_type` field of a [bid
        /// request](https://developers.google.com/authorized-buyers/rtb/downloads/realtime-bidding-proto) does not
        /// contain one of the vendor type IDs that were declared or detected for a given creative, and a bid is
        /// submitted with that creative, the bid will be filtered before the auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedVendorIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DetectedVendorIds { get; set; } 

        /// <summary>The last time the creative status was updated. Can be used to filter the response of the
        /// creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastStatusUpdate")]
        public virtual object LastStatusUpdate { get; set; } 

        /// <summary>Status of this creative when bidding in open auction, private auction, or auction packages (outside
        /// of Russia and China).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openAuctionServingStatus")]
        public virtual ServingStatus OpenAuctionServingStatus { get; set; } 

        /// <summary>The serving status of this creative in Russia. When approved or disapproved, this status applies to
        /// both deals and open auction in Russia. When pending review, this creative is allowed to serve for deals but
        /// not for open auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("russiaServingStatus")]
        public virtual ServingStatus RussiaServingStatus { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a whole or partial calendar date, e.g. a birthday. The time of day and time zone are either
    /// specified elsewhere or are not significant. The date is relative to the Proleptic Gregorian Calendar. This can
    /// represent: * A full date, with non-zero year, month and day values * A month and day value, with a zero year,
    /// e.g. an anniversary * A year on its own, with zero month and day values * A year and month value, with a zero
    /// day, e.g. a credit card expiration date Related types are google.type.TimeOfDay and
    /// `google.protobuf.Timestamp`.</summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a year by
        /// itself or a year and month where the day is not significant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; } 

        /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; } 

        /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Evidence that the creative's destination URL was not crawlable by Google.</summary>
    public class DestinationNotCrawlableEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Approximate time of the crawl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crawlTime")]
        public virtual object CrawlTime { get; set; } 

        /// <summary>Destination URL that was attempted to be crawled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crawledUrl")]
        public virtual string CrawledUrl { get; set; } 

        /// <summary>Reason of destination not crawlable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Evidence of the creative's destination URL not functioning properly or having been incorrectly set
    /// up.</summary>
    public class DestinationNotWorkingEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DNS lookup errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsError")]
        public virtual string DnsError { get; set; } 

        /// <summary>The full non-working URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandedUrl")]
        public virtual string ExpandedUrl { get; set; } 

        /// <summary>HTTP error code (e.g. 404 or 5xx)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpError")]
        public virtual System.Nullable<int> HttpError { get; set; } 

        /// <summary>Page was crawled successfully, but was detected as either a page with no content or an error
        /// page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidPage")]
        public virtual string InvalidPage { get; set; } 

        /// <summary>Approximate time when the ad destination was last checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastCheckTime")]
        public virtual object LastCheckTime { get; set; } 

        /// <summary>Platform of the non-working URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; } 

        /// <summary>HTTP redirect chain error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectionError")]
        public virtual string RedirectionError { get; set; } 

        /// <summary>Rejected because of malformed URLs or invalid requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlRejected")]
        public virtual string UrlRejected { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The full landing page URL of the destination.</summary>
    public class DestinationUrlEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The full landing page URL of the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationUrl")]
        public virtual string DestinationUrl { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Number of HTTP calls made by a creative, broken down by domain.</summary>
    public class DomainCallEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Breakdown of the most frequent domains called via HTTP by the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topHttpCallDomains")]
        public virtual System.Collections.Generic.IList<DomainCalls> TopHttpCallDomains { get; set; } 

        /// <summary>The total number of HTTP calls made by the creative, including but not limited to the number of
        /// calls in the top_http_call_domains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalHttpCallCount")]
        public virtual System.Nullable<int> TotalHttpCallCount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The number of HTTP calls made to the given domain.</summary>
    public class DomainCalls : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; } 

        /// <summary>Number of HTTP calls made to the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpCallCount")]
        public virtual System.Nullable<int> HttpCallCount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Total download size and URL-level download size breakdown for resources in a creative.</summary>
    public class DownloadSizeEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Download size broken down by URLs with the top download size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topUrlDownloadSizeBreakdowns")]
        public virtual System.Collections.Generic.IList<UrlDownloadSize> TopUrlDownloadSizeBreakdowns { get; set; } 

        /// <summary>Total download size (in kilobytes) for all the resources in the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDownloadSizeKb")]
        public virtual System.Nullable<int> TotalDownloadSizeKb { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for a request to get remarketing tag.</summary>
    public class GetRemarketingTagResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A HTML tag that can be placed on the advertiser's page to add users to a user list. For more
        /// information and code samples on using snippet on your website refer to [Tag your site for remarketing](
        /// https://support.google.com/google-ads/answer/2476688).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>HTML content for a creative.</summary>
    public class HtmlContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The height of the HTML snippet in pixels. Can be used to filter the response of the creatives.list
        /// method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; } 

        /// <summary>The HTML snippet that displays the ad when inserted in the web page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; } 

        /// <summary>The width of the HTML snippet in pixels. Can be used to filter the response of the creatives.list
        /// method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>HTTP calls made by a creative that resulted in policy violations.</summary>
    public class HttpCallEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URLs of HTTP calls made by the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urls")]
        public virtual System.Collections.Generic.IList<string> Urls { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Evidence for HTTP cookie-related policy violations.</summary>
    public class HttpCookieEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Names of cookies that violate Google policies. For TOO_MANY_COOKIES policy, this will be the cookie
        /// names of top domains with the largest number of cookies. For other policies, this will be all the cookie
        /// names that violate the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieNames")]
        public virtual System.Collections.Generic.IList<string> CookieNames { get; set; } 

        /// <summary>The largest number of cookies set by a creative. If this field is set, cookie_names above will be
        /// set to the cookie names of top domains with the largest number of cookies. This field will only be set for
        /// TOO_MANY_COOKIES policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxCookieCount")]
        public virtual System.Nullable<int> MaxCookieCount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An image resource. You may provide a larger image than was requested, so long as the aspect ratio is
    /// preserved.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Image height in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; } 

        /// <summary>The URL of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>Image width in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response for listing creatives.</summary>
    public class ListCreativesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of creatives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatives")]
        public virtual System.Collections.Generic.IList<Creative> Creatives { get; set; } 

        /// <summary>A token to retrieve the next page of results. Pass this value in the ListCreativesRequest.pageToken
        /// field in the subsequent call to the `ListCreatives` method to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The list user list response.</summary>
    public class ListUserListsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The continuation page token to send back to the server in a subsequent request. Due to a currently
        /// known issue, it is recommended that the caller keep invoking the list method till the time a next page token
        /// is not returned (even if the result set is empty).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>List of user lists from the search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLists")]
        public virtual System.Collections.Generic.IList<UserList> UserLists { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information about each media file in the VAST.</summary>
    public class MediaFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bitrate of the video file, in Kbps. Can be used to filter the response of the creatives.list
        /// method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitrate")]
        public virtual System.Nullable<long> Bitrate { get; set; } 

        /// <summary>The MIME type of this media file. Can be used to filter the response of the creatives.list
        /// method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Native content for a creative.</summary>
    public class NativeContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the advertiser or sponsor, to be displayed in the ad creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserName")]
        public virtual string AdvertiserName { get; set; } 

        /// <summary>The app icon, for app download ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appIcon")]
        public virtual Image AppIcon { get; set; } 

        /// <summary>A long description of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; } 

        /// <summary>A label for the button that the user is supposed to click.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callToAction")]
        public virtual string CallToAction { get; set; } 

        /// <summary>The URL that the browser/SDK will load when the user clicks the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickLinkUrl")]
        public virtual string ClickLinkUrl { get; set; } 

        /// <summary>The URL to use for click tracking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickTrackingUrl")]
        public virtual string ClickTrackingUrl { get; set; } 

        /// <summary>A short title for the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headline")]
        public virtual string Headline { get; set; } 

        /// <summary>A large image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; } 

        /// <summary>A smaller image, for the advertiser's logo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logo")]
        public virtual Image Logo { get; set; } 

        /// <summary>The price of the promoted app including currency info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceDisplayText")]
        public virtual string PriceDisplayText { get; set; } 

        /// <summary>The app rating in the app store. Must be in the range [0-5].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starRating")]
        public virtual System.Nullable<double> StarRating { get; set; } 

        /// <summary>The URL to fetch a native video ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoUrl")]
        public virtual string VideoUrl { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request to open a specified user list.</summary>
    public class OpenUserListRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Each policy topic entry will represent a violation of a policy topic for a creative, with the policy
    /// topic information and optional evidence for the policy violation.</summary>
    public class PolicyTopicEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pieces of evidence associated with this policy topic entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evidences")]
        public virtual System.Collections.Generic.IList<PolicyTopicEvidence> Evidences { get; set; } 

        /// <summary>URL of the help center article describing this policy topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpCenterUrl")]
        public virtual string HelpCenterUrl { get; set; } 

        /// <summary>Policy topic this entry refers to. For example, "ALCOHOL", "TRADEMARKS_IN_AD_TEXT", or
        /// "DESTINATION_NOT_WORKING". The set of possible policy topics is not fixed for a particular API version and
        /// may change at any time. Can be used to filter the response of the creatives.list method</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTopic")]
        public virtual string PolicyTopic { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Evidence associated with a policy topic entry.</summary>
    public class PolicyTopicEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creative's destination URL was not crawlable by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationNotCrawlable")]
        public virtual DestinationNotCrawlableEvidence DestinationNotCrawlable { get; set; } 

        /// <summary>The creative's destination URL did not function properly or was incorrectly set up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationNotWorking")]
        public virtual DestinationNotWorkingEvidence DestinationNotWorking { get; set; } 

        /// <summary>URL of the actual landing page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationUrl")]
        public virtual DestinationUrlEvidence DestinationUrl { get; set; } 

        /// <summary>Number of HTTP calls made by the creative, broken down by domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainCall")]
        public virtual DomainCallEvidence DomainCall { get; set; } 

        /// <summary>Total download size and URL-level download size breakdown for resources in a creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadSize")]
        public virtual DownloadSizeEvidence DownloadSize { get; set; } 

        /// <summary>HTTP calls made by the creative that resulted in policy violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpCall")]
        public virtual HttpCallEvidence HttpCall { get; set; } 

        /// <summary>Evidence for HTTP cookie-related policy violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpCookie")]
        public virtual HttpCookieEvidence HttpCookie { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Serving status of the creative for a transaction type or a region.</summary>
    public class ServingStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Serving status for the given transaction type (e.g., open auction, deals) or region (e.g., China,
        /// Russia). Can be used to filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>Policy topics related to the serving decision for this transaction type (e.g., open auction, deals)
        /// or region (e.g., China, Russia). Topics may be present only if status is DISAPPROVED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topics")]
        public virtual System.Collections.Generic.IList<PolicyTopicEntry> Topics { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The URL-level breakdown for the download size.</summary>
    public class UrlDownloadSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Download size of the URL in kilobytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadSizeKb")]
        public virtual System.Nullable<int> DownloadSizeKb { get; set; } 

        /// <summary>The normalized URL with query parameters and fragment removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedUrl")]
        public virtual string NormalizedUrl { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the URL restriction (for the URL captured by the pixel callback) for a user list.</summary>
    public class UrlRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End date (if specified) of the URL restriction. End date should be later than the start date for
        /// the date range to be valid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; } 

        /// <summary>The restriction type for the specified URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictionType")]
        public virtual string RestrictionType { get; set; } 

        /// <summary>Start date (if specified) of the URL restriction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; } 

        /// <summary>Required. The URL to use for applying the restriction on the user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an Authorized Buyers user list. Authorized Buyers can create/update/list user lists. Once a
    /// user list is created in the system, Authorized Buyers can add users to the user list using the bulk uploader
    /// API. Alternatively, users can be added by hosting a tag on the advertiser's page.</summary>
    public class UserList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description for the user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Required. Display name of the user list. This must be unique across all user lists for a given
        /// account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Required. The number of days a user's cookie stays on the user list. The field must be between 0
        /// and 540 inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipDurationDays")]
        public virtual System.Nullable<long> MembershipDurationDays { get; set; } 

        /// <summary>Output only. Name of the user list that must follow the pattern
        /// `buyers/{buyer}/userLists/{user_list}`, where `{buyer}` represents the account ID of the buyer who owns the
        /// user list. For a bidder accessing user lists on behalf of a child seat buyer, `{buyer}` represents the
        /// account ID of the child seat buyer. `{user_list}` is an int64 identifier assigned by Google to uniquely
        /// identify a user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The status of the user list. A new user list starts out as open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>Required. The URL restriction for the user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlRestriction")]
        public virtual UrlRestriction UrlRestriction { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Video content for a creative.</summary>
    public class VideoContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Video metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoMetadata")]
        public virtual VideoMetadata VideoMetadata { get; set; } 

        /// <summary>The URL to fetch a video ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoUrl")]
        public virtual string VideoUrl { get; set; } 

        /// <summary>The contents of a VAST document for a video ad. This document should conform to the VAST 2.0 or 3.0
        /// standard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoVastXml")]
        public virtual string VideoVastXml { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Video metadata for a creative.</summary>
    public class VideoMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration of the ad. Can be used to filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; } 

        /// <summary>Is this a valid VAST ad? Can be used to filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isValidVast")]
        public virtual System.Nullable<bool> IsValidVast { get; set; } 

        /// <summary>Is this a VPAID ad? Can be used to filter the response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isVpaid")]
        public virtual System.Nullable<bool> IsVpaid { get; set; } 

        /// <summary>The list of all media files declared in the VAST. If there are multiple VASTs in a wrapper chain,
        /// this includes the media files from the deepest one in the chain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaFiles")]
        public virtual System.Collections.Generic.IList<MediaFile> MediaFiles { get; set; } 

        /// <summary>The minimum duration that the user has to watch before being able to skip this ad. If the field is
        /// not set, the ad is not skippable. If the field is set, the ad is skippable. Can be used to filter the
        /// response of the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipOffset")]
        public virtual object SkipOffset { get; set; } 

        /// <summary>The maximum VAST version across all wrapped VAST documents. Can be used to filter the response of
        /// the creatives.list method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vastVersion")]
        public virtual string VastVersion { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request to receive push notifications when any of the creatives belonging to the bidder changes
    /// status.</summary>
    public class WatchCreativesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response for the request to receive push notification when a bidder's creatives change
    /// status.</summary>
    public class WatchCreativesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Pub/Sub subscription that can be used to pull creative status notifications. This would be of
        /// the format `projects/{project_id}/subscriptions/{subscription_id}`. Subscription is created with pull
        /// delivery. All service accounts belonging to the bidder will have read access to this subscription.
        /// Subscriptions that are inactive for more than 90 days will be disabled. Please use watchCreatives to re-
        /// enable the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; } 

        /// <summary>The Pub/Sub topic that will be used to publish creative serving status notifications. This would be
        /// of the format `projects/{project_id}/topics/{topic_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
