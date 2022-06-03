// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies the hardware settings for the virtual machine scale set.
    /// </summary>
    public partial class VirtualMachineScaleSetHardwareProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetHardwareProfile class.
        /// </summary>
        public VirtualMachineScaleSetHardwareProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetHardwareProfile class.
        /// </summary>
        /// <param name="vmSizeProperties">Specifies the properties for
        /// customizing the size of the virtual machine. Minimum api-version:
        /// 2022-08-01. &lt;br&gt;&lt;br&gt; Please follow the instructions in
        /// [VM Customization](https://aka.ms/vmcustomization) for more
        /// details.</param>
        public VirtualMachineScaleSetHardwareProfile(VMSizeProperties vmSizeProperties = default(VMSizeProperties))
        {
            VmSizeProperties = vmSizeProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the properties for customizing the size of
        /// the virtual machine. Minimum api-version: 2022-08-01.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Please follow the instructions
        /// in [VM Customization](https://aka.ms/vmcustomization) for more
        /// details.
        /// </summary>
        [JsonProperty(PropertyName = "vmSizeProperties")]
        public VMSizeProperties VmSizeProperties { get; set; }

    }
}
