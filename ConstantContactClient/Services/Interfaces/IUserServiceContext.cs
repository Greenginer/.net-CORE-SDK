namespace ConstantContactClient.Services
{
    /// <summary>
    /// User service context interface
    /// </summary>
    public interface IUserServiceContext
    {
        /// <summary>
        /// User access token
        /// </summary>
        string AccessToken { get; }

        /// <summary>
        /// Application api key
        /// </summary>
        string ApiKey { get; }
    }
}
