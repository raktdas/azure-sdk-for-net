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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the dedicated host group that the dedicated
    /// host should be assigned to. Only tags may be updated.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DedicatedHostGroupUpdate : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the DedicatedHostGroupUpdate class.
        /// </summary>
        public DedicatedHostGroupUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DedicatedHostGroupUpdate class.
        /// </summary>
        /// <param name="platformFaultDomainCount">Number of fault domains that
        /// the host group can span.</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="hosts">A list of references to all dedicated hosts in
        /// the dedicated host group.</param>
        /// <param name="instanceView">The dedicated host group instance view,
        /// which has the list of instance view of the dedicated hosts under
        /// the dedicated host group.</param>
        /// <param name="supportAutomaticPlacement">Specifies whether virtual
        /// machines or virtual machine scale sets can be placed automatically
        /// on the dedicated host group. Automatic placement means resources
        /// are allocated on dedicated hosts, that are chosen by Azure, under
        /// the dedicated host group. The value is defaulted to 'false' when
        /// not provided. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2020-06-01.</param>
        /// <param name="additionalCapabilities">Enables or disables a
        /// capability on the dedicated host group.&lt;br&gt;&lt;br&gt;Minimum
        /// api-version: 2022-08-01.</param>
        /// <param name="zones">Availability Zone to use for this host group.
        /// Only single zone is supported. The zone can be assigned only during
        /// creation. If not provided, the group supports all zones in the
        /// region. If provided, enforces each host in the group to be in the
        /// same zone.</param>
        public DedicatedHostGroupUpdate(int platformFaultDomainCount, IDictionary<string, string> tags = default(IDictionary<string, string>), IList<SubResourceReadOnly> hosts = default(IList<SubResourceReadOnly>), DedicatedHostGroupInstanceView instanceView = default(DedicatedHostGroupInstanceView), bool? supportAutomaticPlacement = default(bool?), DedicatedHostGroupPropertiesAdditionalCapabilities additionalCapabilities = default(DedicatedHostGroupPropertiesAdditionalCapabilities), IList<string> zones = default(IList<string>))
            : base(tags)
        {
            PlatformFaultDomainCount = platformFaultDomainCount;
            Hosts = hosts;
            InstanceView = instanceView;
            SupportAutomaticPlacement = supportAutomaticPlacement;
            AdditionalCapabilities = additionalCapabilities;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of fault domains that the host group can span.
        /// </summary>
        [JsonProperty(PropertyName = "properties.platformFaultDomainCount")]
        public int PlatformFaultDomainCount { get; set; }

        /// <summary>
        /// Gets a list of references to all dedicated hosts in the dedicated
        /// host group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hosts")]
        public IList<SubResourceReadOnly> Hosts { get; private set; }

        /// <summary>
        /// Gets the dedicated host group instance view, which has the list of
        /// instance view of the dedicated hosts under the dedicated host
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public DedicatedHostGroupInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Gets or sets specifies whether virtual machines or virtual machine
        /// scale sets can be placed automatically on the dedicated host group.
        /// Automatic placement means resources are allocated on dedicated
        /// hosts, that are chosen by Azure, under the dedicated host group.
        /// The value is defaulted to 'false' when not provided.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2020-06-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportAutomaticPlacement")]
        public bool? SupportAutomaticPlacement { get; set; }

        /// <summary>
        /// Gets or sets enables or disables a capability on the dedicated host
        /// group.&amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2022-08-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalCapabilities")]
        public DedicatedHostGroupPropertiesAdditionalCapabilities AdditionalCapabilities { get; set; }

        /// <summary>
        /// Gets or sets availability Zone to use for this host group. Only
        /// single zone is supported. The zone can be assigned only during
        /// creation. If not provided, the group supports all zones in the
        /// region. If provided, enforces each host in the group to be in the
        /// same zone.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PlatformFaultDomainCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PlatformFaultDomainCount", 1);
            }
        }
    }
}
