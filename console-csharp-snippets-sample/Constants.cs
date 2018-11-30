using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_csharp_snippets_sample
{
    internal class Constants
    {
        public const string ClientIdForUserAuthn = "5dcc3935-b448-400d-9990-def3345dbcf7";

        // Admin consent flow
        public const string Tenant = "8f2a6aec-d764-4677-8664-490e38b79701";
        public const string AuthorityUri = "https://login.microsoftonline.com/" + Tenant + "/oauth2/v2.0/token";
        public const string RedirectUriForAppAuthn = "https://login.microsoftonline.com";
        public const string ClientIdForAppAuthn = "58355c4a-8734-419d-b761-81ab08188d94";
        public const string ClientSecret = "qfkRTS807}{vcltTVKO23-[";
        // Consent URI: 
        // https://login.microsoftonline.com/{tenant name}/adminconsent?client_id={application id}&state=12345&redirect_uri=https://login.microsoftonline.com
    }
}
