
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Operations
{
    using Codat.Platform.Utils;
    
    public class GetSupplementalDataConfigurationRequest
    {

        /// <summary>
        /// Supported supplemental data data type.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=dataType")]
        public PathParamDataType DataType { get; set; } = default!;

        /// <summary>
        /// A unique 4-letter key to represent a platform in each integration. View <a href="https://docs.codat.io/integrations/accounting/overview#platform-keys">accounting</a>, <a href="https://docs.codat.io/integrations/banking/overview#platform-keys">banking</a>, and <a href="https://docs.codat.io/integrations/commerce/overview#platform-keys">commerce</a> platform keys.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=platformKey")]
        public string PlatformKey { get; set; } = default!;
    }
}