using System;
using System.Runtime.Serialization;

namespace ConstantContactClient
{
    /// <summary>
    /// AuthenticationRequest class.
    /// </summary>
    [DataContract]
    [Serializable]
    class AuthenticationRequest
    {
        /// <summary>
        /// Activity id.
        /// </summary>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Activity id.
        /// </summary>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// Activity id.
        /// </summary>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }
    }
}
