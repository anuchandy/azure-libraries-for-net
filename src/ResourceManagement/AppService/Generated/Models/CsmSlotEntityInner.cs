// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment slot parameters.
    /// </summary>
    public partial class CsmSlotEntityInner
    {
        /// <summary>
        /// Initializes a new instance of the CsmSlotEntityInner class.
        /// </summary>
        public CsmSlotEntityInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CsmSlotEntityInner class.
        /// </summary>
        /// <param name="targetSlot">Destination deployment slot during swap
        /// operation.</param>
        /// <param name="preserveVnet">&lt;code&gt;true&lt;/code&gt; to
        /// preserve Virtual Network to the slot during swap; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        public CsmSlotEntityInner(string targetSlot, bool preserveVnet)
        {
            TargetSlot = targetSlot;
            PreserveVnet = preserveVnet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets destination deployment slot during swap operation.
        /// </summary>
        [JsonProperty(PropertyName = "targetSlot")]
        public string TargetSlot { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to
        /// preserve Virtual Network to the slot during swap; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "preserveVnet")]
        public bool PreserveVnet { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetSlot == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetSlot");
            }
        }
    }
}