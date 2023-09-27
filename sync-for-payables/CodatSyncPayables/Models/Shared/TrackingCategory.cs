
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// Details of a category used for tracking transactions.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// &gt; Language tip<br/>
    /// &gt;<br/>
    /// &gt; Parameters used to track types of spend in various parts of an organization can be called  **dimensions**, **projects**, **classes**, or **locations** in different accounting platforms. In Codat, we refer to these as tracking categories.<br/>
    /// <br/>
    /// View the coverage for tracking categories in the &lt;a className=&quot;external&quot; href=&quot;https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&amp;dataType=trackingCategories&quot; target=&quot;_blank&quot;&gt;Data coverage explorer&lt;/a&gt;.<br/>
    /// <br/>
    /// ## Overview<br/>
    /// <br/>
    /// Tracking categories are used to monitor cost centres and control budgets that sit outside the standard chart of accounts. Customers may use tracking categories to group together and track the income and costs of specific departments, projects, locations or customers.<br/>
    /// <br/>
    /// From their accounting system, customers can: <br/>
    /// <br/>
    /// - Create and maintain tracking categories and tracking category types.<br/>
    /// - View all tracking categories that are available for use.<br/>
    /// - View the relationships between the categories.<br/>
    /// - Assign invoices, bills, credit notes, or bill credit notes to one or more categories.<br/>
    /// - View the categories that a transaction belongs to.<br/>
    /// - View all transactions in a tracking category.<br/>
    /// <br/>
    /// ### Tracking categories per platform<br/>
    /// <br/>
    /// Review the platform-specific tracking categories that Codat supports, and the level they are assigned to in the source platform. <br/>
    /// <br/>
    /// &lt;table&gt;<br/>
    /// &lt;thead&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;th&gt;Platform&lt;/th&gt;<br/>
    ///     &lt;th&gt;Tracking category&lt;/th&gt;<br/>
    ///     &lt;th&gt;Tracking level&lt;/th&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    /// &lt;/thead&gt;<br/>
    /// &lt;tbody&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;b&gt;Dynamics 365&lt;/b&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Dimensions&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;b&gt;Freshbooks&lt;/b&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Expense&amp;nbsp;categories&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;b&gt;MYOB&lt;/b&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Categories&lt;/td&gt;<br/>
    ///     &lt;td&gt;Transaction&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td rowspan=4&gt;&lt;b&gt;Netsuite&lt;/b&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Classes&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;Locations&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;Departments&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;Custom&amp;nbsp;segments&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td rowspan=2&gt;&lt;b&gt;QuickBooks Desktop&lt;/b&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Classes&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item or transaction level&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;Locations&lt;/td&gt;<br/>
    ///     &lt;td&gt;Transaction&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td rowspan=2&gt;&lt;b&gt;QuickBooks Online&lt;/b&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Classes&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item or transaction level&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;Locations&lt;/td&gt;<br/>
    ///     &lt;td&gt;Transaction&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td rowspan=3&gt;&lt;b&gt;Sage 200&lt;/b&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Cost&amp;nbsp;centers&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///       &lt;td&gt;Departments&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;Analysis&amp;nbsp;codes&lt;/td&gt;<br/>
    ///     &lt;td&gt;Transaction&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td rowspan=3&gt;&lt;b&gt;Sage 50&lt;/b&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Departments&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///      &lt;td&gt;Costcodes&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;Projects&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;b&gt;Sage Intacct&lt;/b&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Dimensions&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    ///   &lt;tr&gt;<br/>
    ///     &lt;td&gt;&lt;b&gt;Xero&lt;/b&gt;&lt;/td&gt;<br/>
    ///     &lt;td&gt;Tracking&amp;nbsp;categories&lt;/td&gt;<br/>
    ///     &lt;td&gt;Line item&lt;/td&gt;<br/>
    ///   &lt;/tr&gt;<br/>
    /// &lt;/tbody&gt;<br/>
    /// &lt;/table&gt;<br/>
    /// <br/>
    /// &gt; **Example use case**<br/>
    /// &gt;<br/>
    /// &gt; Monitor the budget for your annual conference using a tracking category called &apos;AnnualConference2020&apos; with the **type** set to **Costing**.<br/>
    /// <br/>
    /// If a tracking category has a parent category, the ID of that parent category is displayed. There is also a `hasChildren` field that shows whether there are child subcategories nested beneath. 
    /// </remarks>
    /// </summary>
    public class TrackingCategory
    {

        /// <summary>
        /// Boolean value indicating whether this category has SubCategories.
        /// </summary>
        [JsonProperty("hasChildren")]
        public bool? HasChildren { get; set; }

        /// <summary>
        /// The identifier for the item, unique per tracking category.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }

        /// <summary>
        /// The name of the tracking category.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The identifier for this item&apos;s immediate parent.
        /// </summary>
        [JsonProperty("parentId")]
        public string? ParentId { get; set; }

        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }

        /// <summary>
        /// Current state of the tracking category.
        /// </summary>
        [JsonProperty("status")]
        public Status? Status { get; set; }
    }
}