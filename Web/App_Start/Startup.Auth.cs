using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;
using WebApplicationOAuth.Models;
using Microsoft.Owin.Security.Twitter;
using Microsoft.Owin.Security;

namespace WebApplicationOAuth
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context, user manager and signin manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            // Configure the sign in cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    // Enables the application to validate the security stamp when the user logs in.
                    // This is a security feature which is used when you change a password or add an external login to your account.  
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });            
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Enables the application to temporarily store user information when they are verifying the second factor in the two-factor authentication process.
            app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5));

            // Enables the application to remember the second login verification factor such as phone or email.
            // Once you check this option, your second step of verification during the login process will be remembered on the device where you logged in from.
            // This is similar to the RememberMe option when you log in.
            app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie);

            // https://docs.microsoft.com/en-us/aspnet/mvc/overview/security/create-an-aspnet-mvc-5-app-with-facebook-and-google-oauth2-and-openid-sign-on
            // https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/external-authentication-services

            // Uncomment the following lines to enable logging in with third party login providers
            // https://apps.dev.microsoft.com/?mkt=nb-no&referrer=https%3a%2f%2fdocs.microsoft.com%2fen-us%2faspnet%2fweb-api%2foverview%2fsecurity%2fexternal-authentication-services#/appList
            //app.UseMicrosoftAccountAuthentication (
            //    clientId: "000000004820504D" ,
            //    clientSecret: "uxhCQ836|~fjvmXBONL64%#" );
            //String XmlSchemaString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims";
            //var msaccountOptions = new Microsoft.Owin.Security.MicrosoftAccount.MicrosoftAccountAuthenticationOptions ( ) {
            //    ClientId = "000000004820504D",
            //    ClientSecret = "uxhCQ836|~fjvmXBONL64%#",
            //    Provider = new Microsoft.Owin.Security.MicrosoftAccount.MicrosoftAccountAuthenticationProvider ( ) {
            //        OnAuthenticated = ( context ) =>
            //        {
            //            context.Identity.AddClaim ( new System.Security.Claims.Claim ( "urn:microsoftaccount:access_token", context.AccessToken, XmlSchemaString, "Microsoft" ) );
            //            return Task.FromResult ( 0 );
            //        }
            //    }
            //};

            //app.UseMicrosoftAccountAuthentication ( msaccountOptions );

            // http://developer.linkedin.com 
            //app.UseLinkedInAuthentication (
            //    clientId: "77lyvtup2tnq0m" ,
            //    clientSecret: "vcIUnWzcTNNBy9xb" );

            // https://apps.twitter.com/
            app.UseTwitterAuthentication ( new TwitterAuthenticationOptions {
                ConsumerKey = "Neo2jvuVMVoara5DB3B3VSLK9",
                ConsumerSecret = "jCWHGcVNziYX0W31FJOaLOB2erYe1N2e0Y61ojT8kG7K0IdEjK",
                BackchannelCertificateValidator = new CertificateSubjectKeyIdentifierValidator ( new[]
                {
        "A5EF0B11CEC04103A34A659048B21CE0572D7D47", // VeriSign Class 3 Secure Server CA - G2
        "0D445C165344C1827E1D20AB25F40163D8BE79A5", // VeriSign Class 3 Secure Server CA - G3
        "7FD365A7C2DDECBBF03009F34339FA02AF333133", // VeriSign Class 3 Public Primary Certification Authority - G5
        "39A55D933676616E73A761DFA16A7E59CDE66FAD", // Symantec Class 3 Secure Server CA - G4
        "5168FF90AF0207753CCCD9656462A212B859723B", //DigiCert SHA2 High Assurance Server C?A 
        "B13EC36903F8BF4701D498261A0802EF63642BC3" //DigiCert High Assurance EV Root CA
    } )
            } );

            //app.UseTwitterAuthentication (
            //   consumerKey: "Neo2jvuVMVoara5DB3B3VSLK9",
            //   consumerSecret: "jCWHGcVNziYX0W31FJOaLOB2erYe1N2e0Y61ojT8kG7K0IdEjK" );

            // https://developers.facebook.com/apps
            //app.UseFacebookAuthentication (
            //   appId: "1715967025142143" ,
            //   appSecret: "c059e5f11cfa2904ad3c9b1e1785bde7" );
            //String XmlSchemaString = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims";
            //var facebookOptions = new Microsoft.Owin.Security.Facebook.FacebookAuthenticationOptions ( ) {
            //    AppId = "1715967025142143",
            //    AppSecret = "c059e5f11cfa2904ad3c9b1e1785bde7",
            //    Provider = new Microsoft.Owin.Security.Facebook.FacebookAuthenticationProvider ( ) {
            //        OnAuthenticated = ( context ) =>
            //        {
            //            JObject wholeUser = context.User;

            //            context.Identity.AddClaim ( new System.Security.Claims.Claim ( "urn:facebook:access_token", context.AccessToken, XmlSchemaString, "Facebook" ) );
            //            context.Identity.AddClaim ( new System.Security.Claims.Claim ( "urn:facebook:email", context.Email, XmlSchemaString, "Facebook" ) );
            //            return Task.FromResult ( 0 );
            //        }
            //    }
            //};
            //facebookOptions.Scope.Add ( "email" );
            //app.UseFacebookAuthentication ( facebookOptions );
            // https://console.developers.google.com/apis/credentials?project=vibrant-catbird-91318
            app.UseGoogleAuthentication ( new GoogleOAuth2AuthenticationOptions () {
                ClientId = "770255532133-cq5egbdea1u75hc42h5mg8qkhnjurao8.apps.googleusercontent.com" ,
                ClientSecret = "jln1tlWwtjPGsLt5Ox27WxDo" } );
        }
    }
}
