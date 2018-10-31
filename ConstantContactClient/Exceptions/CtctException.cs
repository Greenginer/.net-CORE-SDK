using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ConstantContactClient.Exceptions
{
    /// <summary>
    /// General exception.
    /// </summary>
    [Serializable]
    public class ConstantContactClientException : Exception
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ConstantContactClientException()
        {
        }

        /// <summary>
        /// Constructor used with a message.
        /// </summary>
        /// <param name="message">String message of exception.</param>
        public ConstantContactClientException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Constructor used with a message and an inner exception.
        /// </summary>
        /// <param name="message">String message of exception.</param>
        /// <param name="inner">Reference to inner exception.</param>
        public ConstantContactClientException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Constructor used in serializing the data.
        /// </summary>
        /// <param name="info">Data stored to serialize/de-serialize</param>
        /// <param name="context">Defines the source/destinantion of the straeam.</param>
        public ConstantContactClientException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
