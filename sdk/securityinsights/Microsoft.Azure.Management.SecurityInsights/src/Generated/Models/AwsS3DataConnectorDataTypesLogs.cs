// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using System.Linq;

    /// <summary>
    /// Logs data type.
    /// </summary>
    public partial class AwsS3DataConnectorDataTypesLogs : DataConnectorDataTypeCommon
    {
        /// <summary>
        /// Initializes a new instance of the AwsS3DataConnectorDataTypesLogs
        /// class.
        /// </summary>
        public AwsS3DataConnectorDataTypesLogs()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AwsS3DataConnectorDataTypesLogs
        /// class.
        /// </summary>
        /// <param name="state">Describe whether this data type connection is
        /// enabled or not. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        public AwsS3DataConnectorDataTypesLogs(string state)
            : base(state)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
