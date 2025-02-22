// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using System.Linq;

    /// <summary>
    /// Resource information with extended details.
    /// </summary>
    public partial class ManagedHsm : ManagedHsmResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedHsm class.
        /// </summary>
        public ManagedHsm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedHsm class.
        /// </summary>

        /// <param name="id">The Azure Resource Manager resource ID for the managed HSM Pool.
        /// </param>

        /// <param name="name">The name of the managed HSM Pool.
        /// </param>

        /// <param name="type">The resource type of the managed HSM Pool.
        /// </param>

        /// <param name="location">The supported Azure location where the managed HSM Pool should be created.
        /// </param>

        /// <param name="sku">SKU details
        /// </param>

        /// <param name="tags">Resource tags
        /// </param>

        /// <param name="systemData">Metadata pertaining to creation and last modification of the key vault
        /// resource.
        /// </param>

        /// <param name="properties">Properties of the managed HSM
        /// </param>
        public ManagedHsm(string id = default(string), string name = default(string), string type = default(string), string location = default(string), ManagedHsmSku sku = default(ManagedHsmSku), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), SystemData systemData = default(SystemData), ManagedHsmProperties properties = default(ManagedHsmProperties))

        : base(id, name, type, location, sku, tags, systemData)
        {
            this.Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets properties of the managed HSM
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public ManagedHsmProperties Properties {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();

        }
    }
}