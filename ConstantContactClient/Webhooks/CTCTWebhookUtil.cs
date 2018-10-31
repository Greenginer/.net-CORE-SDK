using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConstantContactClient.Webhooks.Model;
using ConstantContactClient.Components;
using ConstantContactClient.Exceptions;
using ConstantContactClient.Util;
using ConstantContactClient.Webhooks.Helper;

namespace ConstantContactClient.Webhooks
{
    /// <summary>
    /// Main Webhook Utility class 
    /// This is meant to be used by users to validate and parse Webhooks received from ConstantContact
    /// </summary>
    public class ConstantContactClientWebhookUtil
    {
        /// <summary>
        /// The client secret associated with the api key
        /// </summary>
        public string ClientSecret { get; private set; }

        /// <summary>
        /// Header name of the HmacSha256 hash
        /// </summary>
        public const string HmacHeaderName = "x-ConstantContactClient-hmac-sha256";

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="clientSecret">Client secret key</param>
        public ConstantContactClientWebhookUtil(string clientSecret)
        {
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Validates and parses the bodyMessage into BillingChangeNotification
        /// </summary>
        /// <param name="xConstantContactClientHmacSHA256">The value in the x-ConstantContactClient-hmac-sha256 header</param>
        /// <param name="bodyMessage">The body message from the POST received from ConstantContact in Webhook callback</param>
        /// <returns>BillingChangeNotification object corresponding to bodyMessage in case of success; an exception is thrown otherwise.</returns>
        public BillingChangeNotification GetBillingChangeNotification(string xConstantContactClientHmacSHA256, string bodyMessage)  
        {
            if (IsValidWebhook(xConstantContactClientHmacSHA256, bodyMessage)) 
            {
                return Component.FromJSON<BillingChangeNotification>(bodyMessage);
            } 
            else 
            {
                throw new ConstantContactClientException(ConstantContactClient.Resources.Errors.InvalidWebhook);
            }
        }

        /// <summary>
        /// Validates a Webhook message
        /// </summary>
        /// <param name="xConstantContactClientHmacSHA256">The value in the x-ConstantContactClient-hmac-sha256 header</param>
        /// <param name="bodyMessage">The body message from the POST received from ConstantContact in Webhook callback</param>
        /// <returns>True if in case of success; False if the Webhook is invalid</returns>
        public bool IsValidWebhook(string xConstantContactClientHmacSHA256, string bodyMessage) 
        {
            if (ClientSecret == null) 
            {
                throw new ConstantContactClientException(ConstantContactClient.Resources.Errors.NoClientSecret);
            }
            return new WebHookValidator(xConstantContactClientHmacSHA256, bodyMessage, ClientSecret).IsValid();
        }
    }
}
