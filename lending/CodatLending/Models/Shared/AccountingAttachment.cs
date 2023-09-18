
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// The Codat API supports pulling and pushing of file attachments for invoices, bills, direct costs, and direct incomes.&lt;br/&gt;
    /// 
    /// <remarks>
    /// <br/>
    /// &gt; **Retrieving attachments**<br/>
    /// &gt; <br/>
    /// &gt; If a company is authorized, you can query the Codat API to read, download, and upload attachments without requiring a fresh sync of data.<br/>
    /// <br/>
    /// Unlike other data types, Codat doesn&apos;t support sync settings for attachments.<br/>
    /// <br/>
    /// Note that different integrations have different requirements to file size and extension of attachments.<br/>
    /// <br/>
    /// | Integration       | File size | File extension                                                                                                                                               |<br/>
    /// |-------------------|-----------|--------------------------------------------------------------------------------------------------------------------------------------------------------------|<br/>
    /// | Xero              | 4 MB      | 7Z, BMP, CSV, DOC, DOCX, EML, GIF, JPEG, JPG, KEYNOTE, MSG, NUMBERS, ODF,   ODS, ODT, PAGES, PDF, PNG, PPT, PPTX, RAR, RTF, TIF, TIFF, TXT, XLS, XLSX,   ZIP |<br/>
    /// | QuickBooks Online | 100 MB    | AI, CSV, DOC, DOCX, EPS, GIF, JPEG, JPG, ODS, PAGES, PDF, PNG, RTF, TIF,   TXT, XLS, XLSX, XML                                                               |<br/>
    /// | NetSuite          | 100 MB    | BMP, CSV, XLS, XLSX, JSON, PDF, PJPG, PJPEG, PNG, TXT, SVG, TIF, TIFF,   DOC, DOCX, ZIP                                                                      |<br/>
    /// <br/>
    /// View the coverage for accounts in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=chartOfAccounts&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class AccountingAttachment
    {

        /// <summary>
        /// File type of the attachment. This is represented by appending the file type to the &lt;a href=&quot;https://tools.ietf.org/html/rfc6838&quot;&gt;IETF standard file naming requirements&lt;/a&gt;. For example, for a jpeg file the output is **image/jpeg**.&lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// Supported file types vary per platform. 
        /// </remarks>
        /// </summary>
        [JsonProperty("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// In Codat&amp;apos;s data model, dates and times are represented using the &amp;lt;a class=&amp;quot;external&amp;quot; href=&amp;quot;https://en.wikipedia.org/wiki/ISO_8601&amp;quot; target=&amp;quot;_blank&amp;quot;&amp;gt;ISO 8601 standard&amp;lt;/a&amp;gt;. Date and time fields are formatted as strings; for example:&lt;br/&gt;
        /// 
        /// <remarks>
        /// <br/>
        /// ```<br/>
        /// 2020-10-08T22:40:50Z<br/>
        /// 2021-01-01T00:00:00<br/>
        /// ```<br/>
        /// <br/>
        /// <br/>
        /// <br/>
        /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:<br/>
        /// <br/>
        /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`<br/>
        /// - Unqualified local time: `2021-11-15T01:00:00`<br/>
        /// - UTC time offsets: `2021-11-15T01:00:00-05:00`<br/>
        /// <br/>
        /// &gt; Time zones<br/>
        /// &gt; <br/>
        /// &gt; Not all dates from Codat will contain information about time zones.  <br/>
        /// &gt; Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
        /// </remarks>
        /// </summary>
        [JsonProperty("dateCreated")]
        public string? DateCreated { get; set; }

        /// <summary>
        /// File size in bytes. For example, if this reads **46153**, then the file size is 46kb.
        /// </summary>
        [JsonProperty("fileSize")]
        public int? FileSize { get; set; }

        /// <summary>
        /// Identifier for the attachment, unique for the company in the accounting platform.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// If `true`, then the attachment is included with the associated invoice, bill or direct costs when it is printed, emailed, or sent to a customer, if the underlying accounting platform allows this.
        /// </summary>
        [JsonProperty("includeWhenSent")]
        public bool? IncludeWhenSent { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// Name of the attachment file.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }
    }
}