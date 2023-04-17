///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace Codat.Models.Shared;
using Codat.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public enum InvoiceStatusEnum
{
    	[JsonProperty("Unknown")]
	Unknown,
	[JsonProperty("Draft")]
	Draft,
	[JsonProperty("Submitted")]
	Submitted,
	[JsonProperty("PartiallyPaid")]
	PartiallyPaid,
	[JsonProperty("Paid")]
	Paid,
	[JsonProperty("Void")]
	Void,
}
