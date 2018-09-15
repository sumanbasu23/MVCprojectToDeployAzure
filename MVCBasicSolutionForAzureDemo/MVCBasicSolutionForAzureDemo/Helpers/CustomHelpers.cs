using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Helpers
{
    public static class CustomHelpers
    {
        public static MvcHtmlString File(this HtmlHelper helper, string id)
        {
            TagBuilder tbg = new TagBuilder("input");
            tbg.Attributes.Add("type", "text");
            tbg.Attributes.Add("id", id);
            tbg.Attributes.Add("width", "250px");
            tbg.Attributes.Add("height", "150px");
            return new MvcHtmlString(tbg.ToString());
        }
    }
}