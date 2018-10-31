namespace ConstantContactClient.Services
{
    /// <summary>
    /// User service context class
    /// </summary>
    public class UserServiceContext : IUserServiceContext
    {
        /// <summary>
        /// User access token
        /// </summary>
        public string AccessToken { get; protected set; }

        /// <summary>
        /// Application api key
        /// </summary>
        public string ApiKey { get; protected set; }

        /// <summary>
        /// Account service constructor
        /// </summary>
        /// <param name="accessToken">Constant Contact OAuth2 access token.</param>
        /// <param name="apiKey">The API key for the application</param>
        public UserServiceContext(string accessToken, string apiKey)
        {
            this.AccessToken = accessToken;
            this.ApiKey = apiKey;
        }
    }
}
