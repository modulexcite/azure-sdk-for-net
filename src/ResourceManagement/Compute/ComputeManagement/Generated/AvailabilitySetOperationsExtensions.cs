// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute
{
    /// <summary>
    /// The Compute Management Client.
    /// </summary>
    public static partial class AvailabilitySetOperationsExtensions
    {
        /// <summary>
        /// The operation to create or update the availability set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IAvailabilitySetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Availability Set
        /// operation.
        /// </param>
        /// <returns>
        /// The Create Availability Set operation response.
        /// </returns>
        public static AvailabilitySetCreateOrUpdateResponse CreateOrUpdate(this IAvailabilitySetOperations operations, string resourceGroupName, AvailabilitySet parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAvailabilitySetOperations)s).CreateOrUpdateAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to create or update the availability set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IAvailabilitySetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Availability Set
        /// operation.
        /// </param>
        /// <returns>
        /// The Create Availability Set operation response.
        /// </returns>
        public static Task<AvailabilitySetCreateOrUpdateResponse> CreateOrUpdateAsync(this IAvailabilitySetOperations operations, string resourceGroupName, AvailabilitySet parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to delete the availability set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IAvailabilitySetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='availabilitySetName'>
        /// Required. The name of the availability set.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IAvailabilitySetOperations operations, string resourceGroupName, string availabilitySetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAvailabilitySetOperations)s).DeleteAsync(resourceGroupName, availabilitySetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to delete the availability set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IAvailabilitySetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='availabilitySetName'>
        /// Required. The name of the availability set.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IAvailabilitySetOperations operations, string resourceGroupName, string availabilitySetName)
        {
            return operations.DeleteAsync(resourceGroupName, availabilitySetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to get the availability set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IAvailabilitySetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='availabilitySetName'>
        /// Required. The name of the availability set.
        /// </param>
        /// <returns>
        /// GET Availability Set operation response.
        /// </returns>
        public static AvailabilitySetGetResponse Get(this IAvailabilitySetOperations operations, string resourceGroupName, string availabilitySetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAvailabilitySetOperations)s).GetAsync(resourceGroupName, availabilitySetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to get the availability set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IAvailabilitySetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='availabilitySetName'>
        /// Required. The name of the availability set.
        /// </param>
        /// <returns>
        /// GET Availability Set operation response.
        /// </returns>
        public static Task<AvailabilitySetGetResponse> GetAsync(this IAvailabilitySetOperations operations, string resourceGroupName, string availabilitySetName)
        {
            return operations.GetAsync(resourceGroupName, availabilitySetName, CancellationToken.None);
        }
        
        /// <summary>
        /// The operation to list the availability sets.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IAvailabilitySetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// The List Availability Set operation response.
        /// </returns>
        public static AvailabilitySetListResponse List(this IAvailabilitySetOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAvailabilitySetOperations)s).ListAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The operation to list the availability sets.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IAvailabilitySetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <returns>
        /// The List Availability Set operation response.
        /// </returns>
        public static Task<AvailabilitySetListResponse> ListAsync(this IAvailabilitySetOperations operations, string resourceGroupName)
        {
            return operations.ListAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Lists virtual-machine-sizes available to be used for an
        /// availability set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IAvailabilitySetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='availabilitySetName'>
        /// Required. The name of the availability set.
        /// </param>
        /// <returns>
        /// The List Virtual Machine operation response.
        /// </returns>
        public static VirtualMachineSizeListResponse ListAvailableSizes(this IAvailabilitySetOperations operations, string resourceGroupName, string availabilitySetName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAvailabilitySetOperations)s).ListAvailableSizesAsync(resourceGroupName, availabilitySetName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists virtual-machine-sizes available to be used for an
        /// availability set.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IAvailabilitySetOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='availabilitySetName'>
        /// Required. The name of the availability set.
        /// </param>
        /// <returns>
        /// The List Virtual Machine operation response.
        /// </returns>
        public static Task<VirtualMachineSizeListResponse> ListAvailableSizesAsync(this IAvailabilitySetOperations operations, string resourceGroupName, string availabilitySetName)
        {
            return operations.ListAvailableSizesAsync(resourceGroupName, availabilitySetName, CancellationToken.None);
        }
    }
}