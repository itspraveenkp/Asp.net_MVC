using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custom_HTML_helpers
{
    public static class CustomHTML
    {
        public static IHtmlString Image(string src, string alt)
        {
            return new MvcHtmlString(String.Format("<img src ='{0}' alt = '{1}' width=200px height=200px></img>", src, alt));
        }

        public static IHtmlString img(this HtmlHelper htmlHelper, string src, string alt)
        {
            return new MvcHtmlString(String.Format("<img src = '{0}' alt = '{1}' width=200px height=200px>", src, alt));
        }

        public static IHtmlString imageTag(this HtmlHelper htmlHelper, string src, string alt)
        {
            TagBuilder tagBuilder = new TagBuilder("img width=200px height=200px");
            tagBuilder.Attributes.Add("src", src);
            tagBuilder.Attributes.Add("alt", alt);
            return new MvcHtmlString(String.Format(tagBuilder.ToString()));
        }
    }
}