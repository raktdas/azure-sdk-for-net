// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GcpParentOrganizationalInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ExcludedProjectNumbers))
            {
                writer.WritePropertyName("excludedProjectNumbers"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedProjectNumbers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ServiceAccountEmailAddress))
            {
                writer.WritePropertyName("serviceAccountEmailAddress"u8);
                writer.WriteStringValue(ServiceAccountEmailAddress);
            }
            if (Optional.IsDefined(WorkloadIdentityProviderId))
            {
                writer.WritePropertyName("workloadIdentityProviderId"u8);
                writer.WriteStringValue(WorkloadIdentityProviderId);
            }
            writer.WritePropertyName("organizationMembershipType"u8);
            writer.WriteStringValue(OrganizationMembershipType.ToString());
            writer.WriteEndObject();
        }

        internal static GcpParentOrganizationalInfo DeserializeGcpParentOrganizationalInfo(JsonElement element)
        {
            Optional<IList<string>> excludedProjectNumbers = default;
            Optional<string> serviceAccountEmailAddress = default;
            Optional<string> workloadIdentityProviderId = default;
            OrganizationMembershipType organizationMembershipType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("excludedProjectNumbers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedProjectNumbers = array;
                    continue;
                }
                if (property.NameEquals("serviceAccountEmailAddress"u8))
                {
                    serviceAccountEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationMembershipType"u8))
                {
                    organizationMembershipType = new OrganizationMembershipType(property.Value.GetString());
                    continue;
                }
            }
            return new GcpParentOrganizationalInfo(organizationMembershipType, Optional.ToList(excludedProjectNumbers), serviceAccountEmailAddress.Value, workloadIdentityProviderId.Value);
        }
    }
}
