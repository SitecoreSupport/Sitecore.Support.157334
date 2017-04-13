namespace Sitecore.Support.Pipelines.GetChromeData
{
    using System;
    using System.Web;
    using Sitecore.Data.Fields;
    using Sitecore.Pipelines.GetChromeData;

    public class GetFieldChromeData : Sitecore.Pipelines.GetChromeData.GetFieldChromeData
    {
        public override void Process(GetChromeDataArgs args)
        {
            base.Process(args);
            #region Added code
            if ("field".Equals(args.ChromeType, StringComparison.OrdinalIgnoreCase))
            {
                args.ChromeData.ExpandedDisplayName = HttpUtility.HtmlEncode((args.CustomData["field"] as Field).ToolTip).Replace("&quot;", "\""); // replacing HTML-encoded quotes with \"
            } 
            #endregion
        }
    }
}