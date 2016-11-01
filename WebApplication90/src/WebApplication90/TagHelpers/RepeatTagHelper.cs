using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication90.TagHelpers
{
  // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
  [HtmlTargetElement("repeat")]
  [HtmlTargetElement(Attributes = "count")]
  public class RepeatTagHelper : TagHelper
  {

    /// <summary>
    /// The number of times to repeat
    /// </summary>
    public int Count { get; set; }

    public override void Process(TagHelperContext context, 
      TagHelperOutput output)
    {

      var childContent = output.GetChildContentAsync().Result.GetContent();

      for (var i=0;i<Count;i++)
      {
        output.Content.AppendHtml(childContent);
      }
    }
  }
}
