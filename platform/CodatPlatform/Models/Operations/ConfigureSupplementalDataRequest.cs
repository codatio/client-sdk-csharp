
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform.Models.Operations
{
    using CodatPlatform.Models.Shared;
    using CodatPlatform.Utils;
    
    public class ConfigureSupplementalDataRequest
    {

        /// <summary>
        /// The configuration for the specified platform and data type.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public SupplementalDataConfiguration? SupplementalDataConfiguration { get; set; }

        /// <summary>
        /// Supported supplemental data data type.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=dataType")]
        public ConfigureSupplementalDataDataType DataType { get; set; } = default!;

        /// <summary>
        /// A unique 4-letter key to represent a platform in each integration. View &lt;a href=&quot;https://docs.codat.io/integrations/accounting/overview#platform-keys&quot;&gt;accounting&lt;/a&gt;, &lt;a href=&quot;https://docs.codat.io/integrations/banking/overview#platform-keys&quot;&gt;banking&lt;/a&gt;, and &lt;a href=&quot;https://docs.codat.io/integrations/commerce/overview#platform-keys&quot;&gt;commerce&lt;/a&gt; platform keys.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=platformKey")]
        public string PlatformKey { get; set; } = default!;
    }
}