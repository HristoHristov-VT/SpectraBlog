using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarkdownSharp;

namespace SpectraBlog.Web.Models
{
    public static class MardownEx
    {
        public static IHtmlString Markdown(this string input)
        {
            var m = new Markdown();
            var html = m.Transform(input);
            return new HtmlString(html);

        }

    }
}