// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for InformationProtectionPoliciesOperations
    /// </summary>
    public static partial class InformationProtectionPoliciesOperationsExtensions
    {
        /// <summary>
        /// Details of the information protection policy.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName).
        /// </param>
        /// <param name='informationProtectionPolicyName'>
        /// Name of the information protection policy.
        /// </param>
        public static InformationProtectionPolicy Get(this IInformationProtectionPoliciesOperations operations, string scope, string informationProtectionPolicyName)
        {
                return ((IInformationProtectionPoliciesOperations)operations).GetAsync(scope, informationProtectionPolicyName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Details of the information protection policy.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName).
        /// </param>
        /// <param name='informationProtectionPolicyName'>
        /// Name of the information protection policy.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<InformationProtectionPolicy> GetAsync(this IInformationProtectionPoliciesOperations operations, string scope, string informationProtectionPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(scope, informationProtectionPolicyName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Details of the information protection policy.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName).
        /// </param>
        /// <param name='informationProtectionPolicyName'>
        /// Name of the information protection policy.
        /// </param>
        public static InformationProtectionPolicy CreateOrUpdate(this IInformationProtectionPoliciesOperations operations, string scope, string informationProtectionPolicyName, System.Collections.Generic.IDictionary<string, SensitivityLabel> labels = default(System.Collections.Generic.IDictionary<string, SensitivityLabel>), System.Collections.Generic.IDictionary<string, InformationType> informationTypes = default(System.Collections.Generic.IDictionary<string, InformationType>))
        {
                return ((IInformationProtectionPoliciesOperations)operations).CreateOrUpdateAsync(scope, informationProtectionPolicyName, labels, informationTypes).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Details of the information protection policy.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName).
        /// </param>
        /// <param name='informationProtectionPolicyName'>
        /// Name of the information protection policy.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<InformationProtectionPolicy> CreateOrUpdateAsync(this IInformationProtectionPoliciesOperations operations, string scope, string informationProtectionPolicyName, System.Collections.Generic.IDictionary<string, SensitivityLabel> labels = default(System.Collections.Generic.IDictionary<string, SensitivityLabel>), System.Collections.Generic.IDictionary<string, InformationType> informationTypes = default(System.Collections.Generic.IDictionary<string, InformationType>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(scope, informationProtectionPolicyName, labels, informationTypes, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Information protection policies of a specific management group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName).
        /// </param>
        public static Microsoft.Rest.Azure.IPage<InformationProtectionPolicy> List(this IInformationProtectionPoliciesOperations operations, string scope)
        {
                return ((IInformationProtectionPoliciesOperations)operations).ListAsync(scope).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Information protection policies of a specific management group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// Scope of the query, can be subscription (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management group (/providers/Microsoft.Management/managementGroups/mgName).
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<InformationProtectionPolicy>> ListAsync(this IInformationProtectionPoliciesOperations operations, string scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Information protection policies of a specific management group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<InformationProtectionPolicy> ListNext(this IInformationProtectionPoliciesOperations operations, string nextPageLink)
        {
                return ((IInformationProtectionPoliciesOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Information protection policies of a specific management group.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<InformationProtectionPolicy>> ListNextAsync(this IInformationProtectionPoliciesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
