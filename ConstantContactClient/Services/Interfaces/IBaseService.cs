using System;
using ConstantContactClient.Util;

namespace ConstantContactClient.Services
{
    /// <summary>
    /// Interface for BaseService class.
    /// </summary>
    public interface IBaseService
    {
        /// <summary>
        /// User service context
        /// </summary>
        IUserServiceContext UserServiceContext { get; }

        /// <summary>
        /// Returns the REST client object.
        /// </summary>
        IRestClient RestClient { get; }
    }
}
