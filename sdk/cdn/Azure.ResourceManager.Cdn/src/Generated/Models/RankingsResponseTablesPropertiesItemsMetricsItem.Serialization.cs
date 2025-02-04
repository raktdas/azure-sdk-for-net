// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RankingsResponseTablesPropertiesItemsMetricsItem
    {
        internal static RankingsResponseTablesPropertiesItemsMetricsItem DeserializeRankingsResponseTablesPropertiesItemsMetricsItem(JsonElement element)
        {
            Optional<string> metric = default;
            Optional<long> value = default;
            Optional<float> percentage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("percentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    percentage = property.Value.GetSingle();
                    continue;
                }
            }
            return new RankingsResponseTablesPropertiesItemsMetricsItem(metric.Value, Optional.ToNullable(value), Optional.ToNullable(percentage));
        }
    }
}
