using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace AdventureWorks.CommomData
{
    /// <summary>
    /// Response for getting data of a passed type.
    /// </summary>
    /// <typeparam name="T">Item type.</typeparam>
    public class GetApiResponse<T> where T : class
    {
        /// <summary>
        /// The list of result items.
        /// </summary>
        public List<T> Items { get; set; }

        /// <summary>
        /// Getting data Status Code.
        /// 200 (OK): getting data has been successfully finished.
        /// 500 (InternalServerError): getting data failed.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// The reason for receiving 500 (InternalServerError) response.
        /// </summary>
        public string FailureReason { get; set; }

    }
}