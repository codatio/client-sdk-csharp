
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Operations
{
    using CodatLending.Models.Shared;
    using CodatLending.Utils;
    
    public class RefreshDataTypeRequest
    {

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Optionally, provide a data connection id to only queue pull operations on that connection.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=connectionId")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// The key of a Codat data type
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=dataType")]
        public DataType DataType { get; set; } = default!;
    }
}