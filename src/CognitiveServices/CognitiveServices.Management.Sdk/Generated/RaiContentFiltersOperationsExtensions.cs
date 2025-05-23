// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.CognitiveServices
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for RaiContentFiltersOperations
    /// </summary>
    public static partial class RaiContentFiltersOperationsExtensions
    {
        /// <summary>
        /// List Content Filters types.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// Resource location.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<RaiContentFilter> List(this IRaiContentFiltersOperations operations, string location)
        {
                return ((IRaiContentFiltersOperations)operations).ListAsync(location).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Content Filters types.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// Resource location.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<RaiContentFilter>> ListAsync(this IRaiContentFiltersOperations operations, string location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get Content Filters by Name.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// Resource location.
        /// </param>
        /// <param name='filterName'>
        /// The name of the RAI Content Filter.
        /// </param>
        public static RaiContentFilter Get(this IRaiContentFiltersOperations operations, string location, string filterName)
        {
                return ((IRaiContentFiltersOperations)operations).GetAsync(location, filterName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get Content Filters by Name.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// Resource location.
        /// </param>
        /// <param name='filterName'>
        /// The name of the RAI Content Filter.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<RaiContentFilter> GetAsync(this IRaiContentFiltersOperations operations, string location, string filterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(location, filterName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List Content Filters types.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<RaiContentFilter> ListNext(this IRaiContentFiltersOperations operations, string nextPageLink)
        {
                return ((IRaiContentFiltersOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Content Filters types.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<RaiContentFilter>> ListNextAsync(this IRaiContentFiltersOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
