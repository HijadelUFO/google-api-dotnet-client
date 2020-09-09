// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Vault.v1
{
    /// <summary>The Vault Service.</summary>
    public class VaultService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public VaultService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public VaultService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Matters = new MattersResource(this);
            Operations = new OperationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "vault";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://vault.googleapis.com/";
        #else
            "https://vault.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://vault.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the G Suite Vault API.</summary>
        public class Scope
        {
            /// <summary>Manage your eDiscovery data</summary>
            public static string Ediscovery = "https://www.googleapis.com/auth/ediscovery";

            /// <summary>View your eDiscovery data</summary>
            public static string EdiscoveryReadonly = "https://www.googleapis.com/auth/ediscovery.readonly";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the G Suite Vault API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your eDiscovery data</summary>
            public const string Ediscovery = "https://www.googleapis.com/auth/ediscovery";

            /// <summary>View your eDiscovery data</summary>
            public const string EdiscoveryReadonly = "https://www.googleapis.com/auth/ediscovery.readonly";

        }



        /// <summary>Gets the Matters resource.</summary>
        public virtual MattersResource Matters { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }
    }

    ///<summary>A base abstract class for Vault requests.</summary>
    public abstract class VaultBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new VaultBaseServiceRequest instance.</summary>
        protected VaultBaseServiceRequest(Google.Apis.Services.IClientService service)
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

        /// <summary>Initializes Vault parameter list.</summary>
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

    /// <summary>The "matters" collection of methods.</summary>
    public class MattersResource
    {
        private const string Resource = "matters";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MattersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Exports = new ExportsResource(service);
            Holds = new HoldsResource(service);
            SavedQueries = new SavedQueriesResource(service);

        }

        /// <summary>Gets the Exports resource.</summary>
        public virtual ExportsResource Exports { get; }

        /// <summary>The "exports" collection of methods.</summary>
        public class ExportsResource
        {
            private const string Resource = "exports";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExportsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates an Export.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="matterId">The matter ID.</param>
            public virtual CreateRequest Create(Google.Apis.Vault.v1.Data.Export body, string matterId)
            {
                return new CreateRequest(service, body, matterId);
            }

            /// <summary>Creates an Export.</summary>
            public class CreateRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Export>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.Export body, string matterId)
                    : base(service)
                {
                    MatterId = matterId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Vault.v1.Data.Export Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/exports";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Deletes an Export.</summary>
            /// <param name="matterId">The matter ID.</param>
            /// <param name="exportId">The export ID.</param>
            public virtual DeleteRequest Delete(string matterId, string exportId)
            {
                return new DeleteRequest(service, matterId, exportId);
            }

            /// <summary>Deletes an Export.</summary>
            public class DeleteRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string matterId, string exportId)
                    : base(service)
                {
                    MatterId = matterId;
                    ExportId = exportId;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>The export ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("exportId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ExportId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/exports/{exportId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "exportId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "exportId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Gets an Export.</summary>
            /// <param name="matterId">The matter ID.</param>
            /// <param name="exportId">The export ID.</param>
            public virtual GetRequest Get(string matterId, string exportId)
            {
                return new GetRequest(service, matterId, exportId);
            }

            /// <summary>Gets an Export.</summary>
            public class GetRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Export>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string matterId, string exportId)
                    : base(service)
                {
                    MatterId = matterId;
                    ExportId = exportId;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>The export ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("exportId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ExportId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/exports/{exportId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "exportId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "exportId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Lists Exports.</summary>
            /// <param name="matterId">The matter ID.</param>
            public virtual ListRequest List(string matterId)
            {
                return new ListRequest(service, matterId);
            }

            /// <summary>Lists Exports.</summary>
            public class ListRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.ListExportsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string matterId)
                    : base(service)
                {
                    MatterId = matterId;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>The number of exports to return in the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The pagination token as returned in the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/exports";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
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
                }

            }
        }
        /// <summary>Gets the Holds resource.</summary>
        public virtual HoldsResource Holds { get; }

        /// <summary>The "holds" collection of methods.</summary>
        public class HoldsResource
        {
            private const string Resource = "holds";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public HoldsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Accounts = new AccountsResource(service);

            }

            /// <summary>Gets the Accounts resource.</summary>
            public virtual AccountsResource Accounts { get; }

            /// <summary>The "accounts" collection of methods.</summary>
            public class AccountsResource
            {
                private const string Resource = "accounts";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AccountsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Adds a HeldAccount to a hold. Accounts can only be added to a hold that has no
                /// held_org_unit set. Attempting to add an account to an OU-based hold will result in an
                /// error.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="matterId">The matter ID.</param>
                /// <param name="holdId">The hold ID.</param>
                public virtual CreateRequest Create(Google.Apis.Vault.v1.Data.HeldAccount body, string matterId, string holdId)
                {
                    return new CreateRequest(service, body, matterId, holdId);
                }

                /// <summary>Adds a HeldAccount to a hold. Accounts can only be added to a hold that has no
                /// held_org_unit set. Attempting to add an account to an OU-based hold will result in an
                /// error.</summary>
                public class CreateRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.HeldAccount>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.HeldAccount body, string matterId, string holdId)
                        : base(service)
                    {
                        MatterId = matterId;
                        HoldId = holdId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>The matter ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string MatterId { get; private set; }

                    /// <summary>The hold ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("holdId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string HoldId { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Vault.v1.Data.HeldAccount Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/matters/{matterId}/holds/{holdId}/accounts";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "matterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "matterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "holdId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "holdId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Removes a HeldAccount from a hold. If this request leaves the hold with no held accounts,
                /// the hold will not apply to any accounts.</summary>
                /// <param name="matterId">The matter ID.</param>
                /// <param name="holdId">The hold ID.</param>
                /// <param
                /// name="accountId">The ID of the account to remove from the hold.</param>
                public virtual DeleteRequest Delete(string matterId, string holdId, string accountId)
                {
                    return new DeleteRequest(service, matterId, holdId, accountId);
                }

                /// <summary>Removes a HeldAccount from a hold. If this request leaves the hold with no held accounts,
                /// the hold will not apply to any accounts.</summary>
                public class DeleteRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string matterId, string holdId, string accountId)
                        : base(service)
                    {
                        MatterId = matterId;
                        HoldId = holdId;
                        AccountId = accountId;
                        InitParameters();
                    }


                    /// <summary>The matter ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string MatterId { get; private set; }

                    /// <summary>The hold ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("holdId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string HoldId { get; private set; }

                    /// <summary>The ID of the account to remove from the hold.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/matters/{matterId}/holds/{holdId}/accounts/{accountId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "matterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "matterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "holdId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "holdId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "accountId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "accountId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Lists HeldAccounts for a hold. This will only list individually specified held accounts. If
                /// the hold is on an OU, then use Admin SDK to enumerate its members.</summary>
                /// <param name="matterId">The matter ID.</param>
                /// <param name="holdId">The hold ID.</param>
                public virtual ListRequest List(string matterId, string holdId)
                {
                    return new ListRequest(service, matterId, holdId);
                }

                /// <summary>Lists HeldAccounts for a hold. This will only list individually specified held accounts. If
                /// the hold is on an OU, then use Admin SDK to enumerate its members.</summary>
                public class ListRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.ListHeldAccountsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string matterId, string holdId)
                        : base(service)
                    {
                        MatterId = matterId;
                        HoldId = holdId;
                        InitParameters();
                    }


                    /// <summary>The matter ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string MatterId { get; private set; }

                    /// <summary>The hold ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("holdId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string HoldId { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/matters/{matterId}/holds/{holdId}/accounts";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "matterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "matterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "holdId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "holdId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }
            }

            /// <summary>Adds HeldAccounts to a hold. Returns a list of accounts that have been successfully added.
            /// Accounts can only be added to an existing account-based hold.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="matterId">The matter ID.</param>
            /// <param name="holdId">The hold ID.</param>
            public virtual AddHeldAccountsRequest AddHeldAccounts(Google.Apis.Vault.v1.Data.AddHeldAccountsRequest body, string matterId, string holdId)
            {
                return new AddHeldAccountsRequest(service, body, matterId, holdId);
            }

            /// <summary>Adds HeldAccounts to a hold. Returns a list of accounts that have been successfully added.
            /// Accounts can only be added to an existing account-based hold.</summary>
            public class AddHeldAccountsRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.AddHeldAccountsResponse>
            {
                /// <summary>Constructs a new AddHeldAccounts request.</summary>
                public AddHeldAccountsRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.AddHeldAccountsRequest body, string matterId, string holdId)
                    : base(service)
                {
                    MatterId = matterId;
                    HoldId = holdId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>The hold ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("holdId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string HoldId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Vault.v1.Data.AddHeldAccountsRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "addHeldAccounts";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/holds/{holdId}:addHeldAccounts";

                /// <summary>Initializes AddHeldAccounts parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "holdId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "holdId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Creates a hold in the given matter.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="matterId">The matter ID.</param>
            public virtual CreateRequest Create(Google.Apis.Vault.v1.Data.Hold body, string matterId)
            {
                return new CreateRequest(service, body, matterId);
            }

            /// <summary>Creates a hold in the given matter.</summary>
            public class CreateRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Hold>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.Hold body, string matterId)
                    : base(service)
                {
                    MatterId = matterId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Vault.v1.Data.Hold Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/holds";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Removes a hold by ID. This will release any HeldAccounts on this Hold.</summary>
            /// <param name="matterId">The matter ID.</param>
            /// <param name="holdId">The hold ID.</param>
            public virtual DeleteRequest Delete(string matterId, string holdId)
            {
                return new DeleteRequest(service, matterId, holdId);
            }

            /// <summary>Removes a hold by ID. This will release any HeldAccounts on this Hold.</summary>
            public class DeleteRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string matterId, string holdId)
                    : base(service)
                {
                    MatterId = matterId;
                    HoldId = holdId;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>The hold ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("holdId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string HoldId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/holds/{holdId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "holdId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "holdId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Gets a hold by ID.</summary>
            /// <param name="matterId">The matter ID.</param>
            /// <param name="holdId">The hold ID.</param>
            public virtual GetRequest Get(string matterId, string holdId)
            {
                return new GetRequest(service, matterId, holdId);
            }

            /// <summary>Gets a hold by ID.</summary>
            public class GetRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Hold>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string matterId, string holdId)
                    : base(service)
                {
                    MatterId = matterId;
                    HoldId = holdId;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>The hold ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("holdId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string HoldId { get; private set; }

                /// <summary>Specifies which parts of the Hold to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Specifies which parts of the Hold to return.</summary>
                public enum ViewEnum
                {
                    /// <summary>There is no specified view. Defaults to FULL_HOLD.</summary>
                    [Google.Apis.Util.StringValueAttribute("HOLD_VIEW_UNSPECIFIED")]
                    HOLDVIEWUNSPECIFIED,
                    /// <summary>Response includes the id, name, update time, corpus, and query.</summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC_HOLD")]
                    BASICHOLD,
                    /// <summary>Full representation of a Hold. Response includes all fields of 'BASIC' and the entities
                    /// the Hold applies to, such as accounts, or OU.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL_HOLD")]
                    FULLHOLD,
                }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/holds/{holdId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "holdId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "holdId",
                            IsRequired = true,
                            ParameterType = "path",
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

            /// <summary>Lists holds within a matter. An empty page token in ListHoldsResponse denotes no more holds to
            /// list.</summary>
            /// <param name="matterId">The matter ID.</param>
            public virtual ListRequest List(string matterId)
            {
                return new ListRequest(service, matterId);
            }

            /// <summary>Lists holds within a matter. An empty page token in ListHoldsResponse denotes no more holds to
            /// list.</summary>
            public class ListRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.ListHoldsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string matterId)
                    : base(service)
                {
                    MatterId = matterId;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>The number of holds to return in the response, between 0 and 100 inclusive. Leaving this
                /// empty, or as 0, is the same as page_size = 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The pagination token as returned in the response. An empty token means start from the
                /// beginning.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Specifies which parts of the Hold to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Specifies which parts of the Hold to return.</summary>
                public enum ViewEnum
                {
                    /// <summary>There is no specified view. Defaults to FULL_HOLD.</summary>
                    [Google.Apis.Util.StringValueAttribute("HOLD_VIEW_UNSPECIFIED")]
                    HOLDVIEWUNSPECIFIED,
                    /// <summary>Response includes the id, name, update time, corpus, and query.</summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC_HOLD")]
                    BASICHOLD,
                    /// <summary>Full representation of a Hold. Response includes all fields of 'BASIC' and the entities
                    /// the Hold applies to, such as accounts, or OU.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL_HOLD")]
                    FULLHOLD,
                }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/holds";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
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

            /// <summary>Removes HeldAccounts from a hold. Returns a list of statuses in the same order as the request.
            /// If this request leaves the hold with no held accounts, the hold will not apply to any
            /// accounts.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="matterId">The matter ID.</param>
            /// <param name="holdId">The hold ID.</param>
            public virtual RemoveHeldAccountsRequest RemoveHeldAccounts(Google.Apis.Vault.v1.Data.RemoveHeldAccountsRequest body, string matterId, string holdId)
            {
                return new RemoveHeldAccountsRequest(service, body, matterId, holdId);
            }

            /// <summary>Removes HeldAccounts from a hold. Returns a list of statuses in the same order as the request.
            /// If this request leaves the hold with no held accounts, the hold will not apply to any
            /// accounts.</summary>
            public class RemoveHeldAccountsRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.RemoveHeldAccountsResponse>
            {
                /// <summary>Constructs a new RemoveHeldAccounts request.</summary>
                public RemoveHeldAccountsRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.RemoveHeldAccountsRequest body, string matterId, string holdId)
                    : base(service)
                {
                    MatterId = matterId;
                    HoldId = holdId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>The hold ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("holdId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string HoldId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Vault.v1.Data.RemoveHeldAccountsRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "removeHeldAccounts";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/holds/{holdId}:removeHeldAccounts";

                /// <summary>Initializes RemoveHeldAccounts parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "holdId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "holdId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Updates the OU and/or query parameters of a hold. You cannot add accounts to a hold that covers
            /// an OU, nor can you add OUs to a hold that covers individual accounts. Accounts listed in the hold will
            /// be ignored.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="matterId">The matter ID.</param>
            /// <param name="holdId">The ID of the hold.</param>
            public virtual UpdateRequest Update(Google.Apis.Vault.v1.Data.Hold body, string matterId, string holdId)
            {
                return new UpdateRequest(service, body, matterId, holdId);
            }

            /// <summary>Updates the OU and/or query parameters of a hold. You cannot add accounts to a hold that covers
            /// an OU, nor can you add OUs to a hold that covers individual accounts. Accounts listed in the hold will
            /// be ignored.</summary>
            public class UpdateRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Hold>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.Hold body, string matterId, string holdId)
                    : base(service)
                {
                    MatterId = matterId;
                    HoldId = holdId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The matter ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>The ID of the hold.</summary>
                [Google.Apis.Util.RequestParameterAttribute("holdId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string HoldId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Vault.v1.Data.Hold Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "update";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/holds/{holdId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "holdId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "holdId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }
        /// <summary>Gets the SavedQueries resource.</summary>
        public virtual SavedQueriesResource SavedQueries { get; }

        /// <summary>The "savedQueries" collection of methods.</summary>
        public class SavedQueriesResource
        {
            private const string Resource = "savedQueries";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SavedQueriesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates a saved query.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="matterId">The matter ID of the parent matter for which the saved query is to be created.</param>
            public virtual CreateRequest Create(Google.Apis.Vault.v1.Data.SavedQuery body, string matterId)
            {
                return new CreateRequest(service, body, matterId);
            }

            /// <summary>Creates a saved query.</summary>
            public class CreateRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.SavedQuery>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.SavedQuery body, string matterId)
                    : base(service)
                {
                    MatterId = matterId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The matter ID of the parent matter for which the saved query is to be created.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Vault.v1.Data.SavedQuery Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/savedQueries";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Deletes a saved query by Id.</summary>
            /// <param name="matterId">The matter ID of the parent matter for which the saved query is to be
            /// deleted.</param>
            /// <param name="savedQueryId">ID of the saved query to be deleted.</param>
            public virtual DeleteRequest Delete(string matterId, string savedQueryId)
            {
                return new DeleteRequest(service, matterId, savedQueryId);
            }

            /// <summary>Deletes a saved query by Id.</summary>
            public class DeleteRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string matterId, string savedQueryId)
                    : base(service)
                {
                    MatterId = matterId;
                    SavedQueryId = savedQueryId;
                    InitParameters();
                }


                /// <summary>The matter ID of the parent matter for which the saved query is to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>ID of the saved query to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("savedQueryId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SavedQueryId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/savedQueries/{savedQueryId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "savedQueryId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "savedQueryId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Retrieves a saved query by Id.</summary>
            /// <param name="matterId">The matter ID of the parent matter for which the saved query is to be
            /// retrieved.</param>
            /// <param name="savedQueryId">ID of the saved query to be retrieved.</param>
            public virtual GetRequest Get(string matterId, string savedQueryId)
            {
                return new GetRequest(service, matterId, savedQueryId);
            }

            /// <summary>Retrieves a saved query by Id.</summary>
            public class GetRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.SavedQuery>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string matterId, string savedQueryId)
                    : base(service)
                {
                    MatterId = matterId;
                    SavedQueryId = savedQueryId;
                    InitParameters();
                }


                /// <summary>The matter ID of the parent matter for which the saved query is to be retrieved.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>ID of the saved query to be retrieved.</summary>
                [Google.Apis.Util.RequestParameterAttribute("savedQueryId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SavedQueryId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/savedQueries/{savedQueryId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "savedQueryId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "savedQueryId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Lists saved queries within a matter. An empty page token in ListSavedQueriesResponse denotes no
            /// more saved queries to list.</summary>
            /// <param name="matterId">The matter ID of the parent matter for which the saved queries are to be
            /// retrieved.</param>
            public virtual ListRequest List(string matterId)
            {
                return new ListRequest(service, matterId);
            }

            /// <summary>Lists saved queries within a matter. An empty page token in ListSavedQueriesResponse denotes no
            /// more saved queries to list.</summary>
            public class ListRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.ListSavedQueriesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string matterId)
                    : base(service)
                {
                    MatterId = matterId;
                    InitParameters();
                }


                /// <summary>The matter ID of the parent matter for which the saved queries are to be
                /// retrieved.</summary>
                [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string MatterId { get; private set; }

                /// <summary>The maximum number of saved queries to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The pagination token as returned in the previous response. An empty token means start from
                /// the beginning.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/matters/{matterId}/savedQueries";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "matterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matterId",
                            IsRequired = true,
                            ParameterType = "path",
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
                }

            }
        }

        /// <summary>Adds an account as a matter collaborator.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="matterId">The matter ID.</param>
        public virtual AddPermissionsRequest AddPermissions(Google.Apis.Vault.v1.Data.AddMatterPermissionsRequest body, string matterId)
        {
            return new AddPermissionsRequest(service, body, matterId);
        }

        /// <summary>Adds an account as a matter collaborator.</summary>
        public class AddPermissionsRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.MatterPermission>
        {
            /// <summary>Constructs a new AddPermissions request.</summary>
            public AddPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.AddMatterPermissionsRequest body, string matterId)
                : base(service)
            {
                MatterId = matterId;
                Body = body;
                InitParameters();
            }


            /// <summary>The matter ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MatterId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vault.v1.Data.AddMatterPermissionsRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "addPermissions";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/matters/{matterId}:addPermissions";

            /// <summary>Initializes AddPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "matterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "matterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Closes the specified matter. Returns matter with updated state.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="matterId">The matter ID.</param>
        public virtual CloseRequest Close(Google.Apis.Vault.v1.Data.CloseMatterRequest body, string matterId)
        {
            return new CloseRequest(service, body, matterId);
        }

        /// <summary>Closes the specified matter. Returns matter with updated state.</summary>
        public class CloseRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.CloseMatterResponse>
        {
            /// <summary>Constructs a new Close request.</summary>
            public CloseRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.CloseMatterRequest body, string matterId)
                : base(service)
            {
                MatterId = matterId;
                Body = body;
                InitParameters();
            }


            /// <summary>The matter ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MatterId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vault.v1.Data.CloseMatterRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "close";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/matters/{matterId}:close";

            /// <summary>Initializes Close parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "matterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "matterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Creates a new matter with the given name and description. The initial state is open, and the owner
        /// is the method caller. Returns the created matter with default view.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Vault.v1.Data.Matter body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a new matter with the given name and description. The initial state is open, and the owner
        /// is the method caller. Returns the created matter with default view.</summary>
        public class CreateRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Matter>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.Matter body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vault.v1.Data.Matter Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "create";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/matters";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes the specified matter. Returns matter with updated state.</summary>
        /// <param name="matterId">The matter ID</param>
        public virtual DeleteRequest Delete(string matterId)
        {
            return new DeleteRequest(service, matterId);
        }

        /// <summary>Deletes the specified matter. Returns matter with updated state.</summary>
        public class DeleteRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Matter>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string matterId)
                : base(service)
            {
                MatterId = matterId;
                InitParameters();
            }


            /// <summary>The matter ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MatterId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/matters/{matterId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "matterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "matterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Gets the specified matter.</summary>
        /// <param name="matterId">The matter ID.</param>
        public virtual GetRequest Get(string matterId)
        {
            return new GetRequest(service, matterId);
        }

        /// <summary>Gets the specified matter.</summary>
        public class GetRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Matter>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string matterId)
                : base(service)
            {
                MatterId = matterId;
                InitParameters();
            }


            /// <summary>The matter ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MatterId { get; private set; }

            /// <summary>Specifies which parts of the Matter to return in the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>Specifies which parts of the Matter to return in the response.</summary>
            public enum ViewEnum
            {
                /// <summary>There is no specified view.</summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                VIEWUNSPECIFIED,
                /// <summary>Response includes the matter_id, name, description, and state. Default choice.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC,
                /// <summary>Full representation of matter is returned. Everything above and including MatterPermissions
                /// list.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/matters/{matterId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "matterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "matterId",
                        IsRequired = true,
                        ParameterType = "path",
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

        /// <summary>Lists matters the user has access to.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists matters the user has access to.</summary>
        public class ListRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.ListMattersResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>The number of matters to return in the response. Default and maximum are 100.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The pagination token as returned in the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>If set, list only matters with that specific state. The default is listing matters of all
            /// states.</summary>
            [Google.Apis.Util.RequestParameterAttribute("state", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StateEnum> State { get; set; }

            /// <summary>If set, list only matters with that specific state. The default is listing matters of all
            /// states.</summary>
            public enum StateEnum
            {
                /// <summary>The matter has no specified state.</summary>
                [Google.Apis.Util.StringValueAttribute("STATE_UNSPECIFIED")]
                STATEUNSPECIFIED,
                /// <summary>This matter is open.</summary>
                [Google.Apis.Util.StringValueAttribute("OPEN")]
                OPEN,
                /// <summary>This matter is closed.</summary>
                [Google.Apis.Util.StringValueAttribute("CLOSED")]
                CLOSED,
                /// <summary>This matter is deleted.</summary>
                [Google.Apis.Util.StringValueAttribute("DELETED")]
                DELETED,
            }

            /// <summary>Specifies which parts of the matter to return in response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>Specifies which parts of the matter to return in response.</summary>
            public enum ViewEnum
            {
                /// <summary>There is no specified view.</summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                VIEWUNSPECIFIED,
                /// <summary>Response includes the matter_id, name, description, and state. Default choice.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC,
                /// <summary>Full representation of matter is returned. Everything above and including MatterPermissions
                /// list.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/matters";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

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
                    "state", new Google.Apis.Discovery.Parameter
                    {
                        Name = "state",
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

        /// <summary>Removes an account as a matter collaborator.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="matterId">The matter ID.</param>
        public virtual RemovePermissionsRequest RemovePermissions(Google.Apis.Vault.v1.Data.RemoveMatterPermissionsRequest body, string matterId)
        {
            return new RemovePermissionsRequest(service, body, matterId);
        }

        /// <summary>Removes an account as a matter collaborator.</summary>
        public class RemovePermissionsRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Empty>
        {
            /// <summary>Constructs a new RemovePermissions request.</summary>
            public RemovePermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.RemoveMatterPermissionsRequest body, string matterId)
                : base(service)
            {
                MatterId = matterId;
                Body = body;
                InitParameters();
            }


            /// <summary>The matter ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MatterId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vault.v1.Data.RemoveMatterPermissionsRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "removePermissions";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/matters/{matterId}:removePermissions";

            /// <summary>Initializes RemovePermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "matterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "matterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Reopens the specified matter. Returns matter with updated state.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="matterId">The matter ID.</param>
        public virtual ReopenRequest Reopen(Google.Apis.Vault.v1.Data.ReopenMatterRequest body, string matterId)
        {
            return new ReopenRequest(service, body, matterId);
        }

        /// <summary>Reopens the specified matter. Returns matter with updated state.</summary>
        public class ReopenRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.ReopenMatterResponse>
        {
            /// <summary>Constructs a new Reopen request.</summary>
            public ReopenRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.ReopenMatterRequest body, string matterId)
                : base(service)
            {
                MatterId = matterId;
                Body = body;
                InitParameters();
            }


            /// <summary>The matter ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MatterId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vault.v1.Data.ReopenMatterRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "reopen";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/matters/{matterId}:reopen";

            /// <summary>Initializes Reopen parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "matterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "matterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Undeletes the specified matter. Returns matter with updated state.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="matterId">The matter ID.</param>
        public virtual UndeleteRequest Undelete(Google.Apis.Vault.v1.Data.UndeleteMatterRequest body, string matterId)
        {
            return new UndeleteRequest(service, body, matterId);
        }

        /// <summary>Undeletes the specified matter. Returns matter with updated state.</summary>
        public class UndeleteRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Matter>
        {
            /// <summary>Constructs a new Undelete request.</summary>
            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.UndeleteMatterRequest body, string matterId)
                : base(service)
            {
                MatterId = matterId;
                Body = body;
                InitParameters();
            }


            /// <summary>The matter ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MatterId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vault.v1.Data.UndeleteMatterRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "undelete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/matters/{matterId}:undelete";

            /// <summary>Initializes Undelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "matterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "matterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates the specified matter. This updates only the name and description of the matter, identified
        /// by matter ID. Changes to any other fields are ignored. Returns the default view of the matter.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="matterId">The matter ID.</param>
        public virtual UpdateRequest Update(Google.Apis.Vault.v1.Data.Matter body, string matterId)
        {
            return new UpdateRequest(service, body, matterId);
        }

        /// <summary>Updates the specified matter. This updates only the name and description of the matter, identified
        /// by matter ID. Changes to any other fields are ignored. Returns the default view of the matter.</summary>
        public class UpdateRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Matter>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Vault.v1.Data.Matter body, string matterId)
                : base(service)
            {
                MatterId = matterId;
                Body = body;
                InitParameters();
            }


            /// <summary>The matter ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("matterId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MatterId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Vault.v1.Data.Matter Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/matters/{matterId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "matterId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "matterId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "operations" collection of methods.</summary>
    public class OperationsResource
    {
        private const string Resource = "operations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OperationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes a long-running operation. This method indicates that the client is no longer interested in
        /// the operation result. It does not cancel the operation. If the server doesn't support this method, it
        /// returns `google.rpc.Code.UNIMPLEMENTED`.</summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes a long-running operation. This method indicates that the client is no longer interested in
        /// the operation result. It does not cancel the operation. If the server doesn't support this method, it
        /// returns `google.rpc.Code.UNIMPLEMENTED`.</summary>
        public class DeleteRequest : VaultBaseServiceRequest<Google.Apis.Vault.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>The name of the operation resource to be deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
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
                        Pattern = @"^operations/.*$",
                    });
            }

        }
    }
}

namespace Google.Apis.Vault.v1.Data
{    

    /// <summary>Accounts to search</summary>
    public class AccountInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of accounts to search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A status detailing the status of each account creation, and the HeldAccount, if successful.</summary>
    public class AddHeldAccountResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, this account was successfully created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual HeldAccount Account { get; set; } 

        /// <summary>This represents the success status. If failed, check message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Add a list of accounts to a hold.</summary>
    public class AddHeldAccountsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account IDs to identify which accounts to add. Only account_ids or only emails should be specified,
        /// but not both.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountIds")]
        public virtual System.Collections.Generic.IList<string> AccountIds { get; set; } 

        /// <summary>Emails to identify which accounts to add. Only emails or only account_ids should be specified, but
        /// not both.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<string> Emails { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for batch create held accounts.</summary>
    public class AddHeldAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of responses, in the same order as the batch request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<AddHeldAccountResult> Responses { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Add an account with the permission specified. The role cannot be owner. If an account already has a
    /// role in the matter, it will be overwritten.</summary>
    public class AddMatterPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Only relevant if send_emails is true. True to CC requestor in the email message. False to not CC
        /// requestor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ccMe")]
        public virtual System.Nullable<bool> CcMe { get; set; } 

        /// <summary>The MatterPermission to add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matterPermission")]
        public virtual MatterPermission MatterPermission { get; set; } 

        /// <summary>True to send notification email to the added account. False to not send notification
        /// email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendEmails")]
        public virtual System.Nullable<bool> SendEmails { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Close a matter by ID.</summary>
    public class CloseMatterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response to a CloseMatterRequest.</summary>
    public class CloseMatterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated matter, with state CLOSED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matter")]
        public virtual Matter Matter { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An export file on cloud storage</summary>
    public class CloudStorageFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cloud storage bucket name of this export file. Can be used in cloud storage JSON/XML API, but
        /// not to list the bucket contents. Instead, you can get individual export files by object name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; } 

        /// <summary>The md5 hash of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; } 

        /// <summary>The cloud storage object name of this export file. Can be used in cloud storage JSON/XML
        /// API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectName")]
        public virtual string ObjectName { get; set; } 

        /// <summary>The size of the export file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export sink for cloud storage files.</summary>
    public class CloudStorageSink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The exported files on cloud storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<CloudStorageFile> Files { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Corpus specific queries.</summary>
    public class CorpusQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details pertaining to Drive holds. If set, corpus must be Drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveQuery")]
        public virtual HeldDriveQuery DriveQuery { get; set; } 

        /// <summary>Details pertaining to Groups holds. If set, corpus must be Groups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupsQuery")]
        public virtual HeldGroupsQuery GroupsQuery { get; set; } 

        /// <summary>Details pertaining to Hangouts Chat holds. If set, corpus must be Hangouts Chat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hangoutsChatQuery")]
        public virtual HeldHangoutsChatQuery HangoutsChatQuery { get; set; } 

        /// <summary>Details pertaining to mail holds. If set, corpus must be mail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mailQuery")]
        public virtual HeldMailQuery MailQuery { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The options for Drive export.</summary>
    public class DriveExportOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set to true to include access level information for users with indirect access to files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeAccessInfo")]
        public virtual System.Nullable<bool> IncludeAccessInfo { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Drive search advanced options</summary>
    public class DriveOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set to true to include shared drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeSharedDrives")]
        public virtual System.Nullable<bool> IncludeSharedDrives { get; set; } 

        /// <summary>Set to true to include Team Drive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeTeamDrives")]
        public virtual System.Nullable<bool> IncludeTeamDrives { get; set; } 

        /// <summary>Search the versions of the Drive file as of the reference date. These timestamps are in GMT and
        /// rounded down to the given date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionDate")]
        public virtual object VersionDate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An export</summary>
    public class Export : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Export sink for cloud storage files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStorageSink")]
        public virtual CloudStorageSink CloudStorageSink { get; set; } 

        /// <summary>Output only. The time when the export was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Advanced options of the export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportOptions")]
        public virtual ExportOptions ExportOptions { get; set; } 

        /// <summary>Output only. The generated export ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Output only. The matter ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matterId")]
        public virtual string MatterId { get; set; } 

        /// <summary>The export name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The search query being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual Query Query { get; set; } 

        /// <summary>Output only. The requester of the export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requester")]
        public virtual UserInfo Requester { get; set; } 

        /// <summary>Output only. Export statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual ExportStats Stats { get; set; } 

        /// <summary>Output only. The export status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Export advanced options</summary>
    public class ExportOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Option available for Drive export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveOptions")]
        public virtual DriveExportOptions DriveOptions { get; set; } 

        /// <summary>Option available for groups export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupsOptions")]
        public virtual GroupsExportOptions GroupsOptions { get; set; } 

        /// <summary>Option available for hangouts chat export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hangoutsChatOptions")]
        public virtual HangoutsChatExportOptions HangoutsChatOptions { get; set; } 

        /// <summary>Option available for mail export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mailOptions")]
        public virtual MailExportOptions MailOptions { get; set; } 

        /// <summary>The requested export location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Stats of an export.</summary>
    public class ExportStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of documents already processed by the export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportedArtifactCount")]
        public virtual System.Nullable<long> ExportedArtifactCount { get; set; } 

        /// <summary>The size of export in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeInBytes")]
        public virtual System.Nullable<long> SizeInBytes { get; set; } 

        /// <summary>The number of documents to be exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalArtifactCount")]
        public virtual System.Nullable<long> TotalArtifactCount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The options for groups export.</summary>
    public class GroupsExportOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The export format for groups export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportFormat")]
        public virtual string ExportFormat { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The options for hangouts chat export.</summary>
    public class HangoutsChatExportOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The export format for hangouts chat export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportFormat")]
        public virtual string ExportFormat { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Accounts to search</summary>
    public class HangoutsChatInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of rooms to search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roomId")]
        public virtual System.Collections.Generic.IList<string> RoomId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Hangouts chat search advanced options</summary>
    public class HangoutsChatOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set to true to include rooms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeRooms")]
        public virtual System.Nullable<bool> IncludeRooms { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An account being held in a particular hold. This structure is immutable. This can be either a single
    /// user or a google group, depending on the corpus.</summary>
    public class HeldAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account's ID as provided by the Admin SDK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>The primary email address of the account. If used as an input, this takes precedence over account
        /// ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; } 

        /// <summary>Output only. The first name of the account holder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstName")]
        public virtual string FirstName { get; set; } 

        /// <summary>Output only. When the account was put on hold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holdTime")]
        public virtual object HoldTime { get; set; } 

        /// <summary>Output only. The last name of the account holder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastName")]
        public virtual string LastName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Query options for Drive holds.</summary>
    public class HeldDriveQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, include files in shared drives in the hold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeSharedDriveFiles")]
        public virtual System.Nullable<bool> IncludeSharedDriveFiles { get; set; } 

        /// <summary>If true, include files in Team Drives in the hold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeTeamDriveFiles")]
        public virtual System.Nullable<bool> IncludeTeamDriveFiles { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Query options for group holds.</summary>
    public class HeldGroupsQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end time range for the search query. These timestamps are in GMT and rounded down to the start
        /// of the given date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>The start time range for the search query. These timestamps are in GMT and rounded down to the
        /// start of the given date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; } 

        /// <summary>The search terms for the hold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terms")]
        public virtual string Terms { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Query options for hangouts chat holds.</summary>
    public class HeldHangoutsChatQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, include rooms the user has participated in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeRooms")]
        public virtual System.Nullable<bool> IncludeRooms { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Query options for mail holds.</summary>
    public class HeldMailQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end time range for the search query. These timestamps are in GMT and rounded down to the start
        /// of the given date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>The start time range for the search query. These timestamps are in GMT and rounded down to the
        /// start of the given date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; } 

        /// <summary>The search terms for the hold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terms")]
        public virtual string Terms { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A organizational unit being held in a particular hold. This structure is immutable.</summary>
    public class HeldOrgUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>When the org unit was put on hold. This property is immutable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holdTime")]
        public virtual object HoldTime { get; set; } 

        /// <summary>The org unit's immutable ID as provided by the Admin SDK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a hold within Vault. A hold restricts purging of artifacts based on the combination of the
    /// query and accounts restrictions. A hold can be configured to either apply to an explicitly configured set of
    /// accounts, or can be applied to all members of an organizational unit.</summary>
    public class Hold : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, the hold applies to the enumerated accounts and org_unit must be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<HeldAccount> Accounts { get; set; } 

        /// <summary>The corpus to be searched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corpus")]
        public virtual string Corpus { get; set; } 

        /// <summary>The unique immutable ID of the hold. Assigned during creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holdId")]
        public virtual string HoldId { get; set; } 

        /// <summary>The name of the hold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>If set, the hold applies to all members of the organizational unit and accounts must be empty. This
        /// property is mutable. For groups holds, set the accounts field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnit")]
        public virtual HeldOrgUnit OrgUnit { get; set; } 

        /// <summary>The corpus-specific query. If set, the corpusQuery must match corpus type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual CorpusQuery Query { get; set; } 

        /// <summary>The last time this hold was modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The holds for a matter.</summary>
    public class ListExportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of exports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exports")]
        public virtual System.Collections.Generic.IList<Export> Exports { get; set; } 

        /// <summary>Page token to retrieve the next page of results in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Returns a list of held accounts for a hold.</summary>
    public class ListHeldAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The held accounts on a hold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<HeldAccount> Accounts { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The holds for a matter.</summary>
    public class ListHoldsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of holds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("holds")]
        public virtual System.Collections.Generic.IList<Hold> Holds { get; set; } 

        /// <summary>Page token to retrieve the next page of results in the list. If this is empty, then there are no
        /// more holds to list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Provides the list of matters.</summary>
    public class ListMattersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of matters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matters")]
        public virtual System.Collections.Generic.IList<Matter> Matters { get; set; } 

        /// <summary>Page token to retrieve the next page of results in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Definition of the response for method ListSaveQuery.</summary>
    public class ListSavedQueriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page token to retrieve the next page of results in the list. If this is empty, then there are no
        /// more saved queries to list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>List of output saved queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savedQueries")]
        public virtual System.Collections.Generic.IList<SavedQuery> SavedQueries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The options for mail export.</summary>
    public class MailExportOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The export file format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportFormat")]
        public virtual string ExportFormat { get; set; } 

        /// <summary>Set to true to export confidential mode content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showConfidentialModeContent")]
        public virtual System.Nullable<bool> ShowConfidentialModeContent { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Mail search advanced options</summary>
    public class MailOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set to true to exclude drafts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeDrafts")]
        public virtual System.Nullable<bool> ExcludeDrafts { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a matter.</summary>
    public class Matter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the matter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The matter ID which is generated by the server. Should be blank when creating a new
        /// matter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matterId")]
        public virtual string MatterId { get; set; } 

        /// <summary>List of users and access to the matter. Currently there is no programmer defined limit on the
        /// number of permissions a matter can have.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matterPermissions")]
        public virtual System.Collections.Generic.IList<MatterPermission> MatterPermissions { get; set; } 

        /// <summary>The name of the matter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The state of the matter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Currently each matter only has one owner, and all others are collaborators. When an account is purged,
    /// its corresponding MatterPermission resources cease to exist.</summary>
    public class MatterPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account ID, as provided by Admin SDK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>The user's role in this matter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Org Unit to search</summary>
    public class OrgUnitInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Org unit to search, as provided by the Admin SDK Directory API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A query definition relevant for search & export.</summary>
    public class Query : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>When 'ACCOUNT' is chosen as search method, account_info needs to be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountInfo")]
        public virtual AccountInfo AccountInfo { get; set; } 

        /// <summary>The corpus to search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corpus")]
        public virtual string Corpus { get; set; } 

        /// <summary>The data source to search from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataScope")]
        public virtual string DataScope { get; set; } 

        /// <summary>For Drive search, specify more options in this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveOptions")]
        public virtual DriveOptions DriveOptions { get; set; } 

        /// <summary>The end time range for the search query. These timestamps are in GMT and rounded down to the start
        /// of the given date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>When 'ROOM' is chosen as search method, hangout_chats_info needs to be specified. (read-
        /// only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hangoutsChatInfo")]
        public virtual HangoutsChatInfo HangoutsChatInfo { get; set; } 

        /// <summary>For hangouts chat search, specify more options in this field. (read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hangoutsChatOptions")]
        public virtual HangoutsChatOptions HangoutsChatOptions { get; set; } 

        /// <summary>For mail search, specify more options in this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mailOptions")]
        public virtual MailOptions MailOptions { get; set; } 

        /// <summary>The search method to use. This field is similar to the search_method field but is introduced to
        /// support shared drives. It supports all search method types. In case the search_method is TEAM_DRIVE the
        /// response of this field will be SHARED_DRIVE only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; } 

        /// <summary>When 'ORG_UNIT' is chosen as as search method, org_unit_info needs to be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitInfo")]
        public virtual OrgUnitInfo OrgUnitInfo { get; set; } 

        /// <summary>The search method to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchMethod")]
        public virtual string SearchMethod { get; set; } 

        /// <summary>When 'SHARED_DRIVE' is chosen as search method, shared_drive_info needs to be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedDriveInfo")]
        public virtual SharedDriveInfo SharedDriveInfo { get; set; } 

        /// <summary>The start time range for the search query. These timestamps are in GMT and rounded down to the
        /// start of the given date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; } 

        /// <summary>When 'TEAM_DRIVE' is chosen as search method, team_drive_info needs to be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamDriveInfo")]
        public virtual TeamDriveInfo TeamDriveInfo { get; set; } 

        /// <summary>The corpus-specific search operators used to generate search results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terms")]
        public virtual string Terms { get; set; } 

        /// <summary>The time zone name. It should be an IANA TZ name, such as "America/Los_Angeles". For more
        /// information, see Time Zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Remove a list of accounts from a hold.</summary>
    public class RemoveHeldAccountsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account IDs to identify HeldAccounts to remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountIds")]
        public virtual System.Collections.Generic.IList<string> AccountIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for batch delete held accounts.</summary>
    public class RemoveHeldAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of statuses for deleted accounts. Results have the same order as the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statuses")]
        public virtual System.Collections.Generic.IList<Status> Statuses { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Remove an account as a matter collaborator.</summary>
    public class RemoveMatterPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Reopen a matter by ID.</summary>
    public class ReopenMatterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response to a ReopenMatterRequest.</summary>
    public class ReopenMatterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated matter, with state OPEN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matter")]
        public virtual Matter Matter { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Definition of the saved query.</summary>
    public class SavedQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The server generated timestamp at which saved query was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Name of the saved query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. The matter ID of the associated matter. The server does not look at this field during
        /// create and always uses matter id in the URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matterId")]
        public virtual string MatterId { get; set; } 

        /// <summary>The underlying Query object which contains all the information of the saved query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual Query Query { get; set; } 

        /// <summary>A unique identifier for the saved query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savedQueryId")]
        public virtual string SavedQueryId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Shared drives to search</summary>
    public class SharedDriveInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Shared drive IDs, as provided by Drive API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedDriveIds")]
        public virtual System.Collections.Generic.IList<string> SharedDriveIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details. You can find out more about
    /// this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; } 

        /// <summary>A list of messages that carry the error details. There is a common set of message types for APIs to
        /// use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,object>> Details { get; set; } 

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Team Drives to search</summary>
    public class TeamDriveInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Team Drive IDs, as provided by Drive API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamDriveIds")]
        public virtual System.Collections.Generic.IList<string> TeamDriveIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Undelete a matter by ID.</summary>
    public class UndeleteMatterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>User's information.</summary>
    public class UserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The displayed name of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The email address of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
