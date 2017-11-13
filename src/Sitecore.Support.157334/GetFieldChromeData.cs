using Sitecore.Data.Fields;
using Sitecore.Pipelines.GetChromeData;
using System;
using System.Web;

namespace Sitecore.Support.Pipelines.GetChromeData
{
  public class GetFieldChromeData : Sitecore.Pipelines.GetChromeData.GetFieldChromeData
  {
    public override void Process(GetChromeDataArgs args)
    {
      base.Process(args);
      if ("field".Equals(args.ChromeType, StringComparison.OrdinalIgnoreCase))
      {
        args.ChromeData.DisplayName = HttpUtility.HtmlEncode((args.CustomData["field"] as Field).Title).Replace("&quot;", "\"");
        args.ChromeData.ExpandedDisplayName = HttpUtility.HtmlEncode((args.CustomData["field"] as Field).ToolTip).Replace("&quot;", "\"");
      }
    }
  }
}