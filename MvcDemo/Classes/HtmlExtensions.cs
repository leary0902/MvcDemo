using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Classes
{
    /// <summary>
    /// 自定义一个@html.Submit()
    /// </summary>
    /// <param name="helper"></param>
    /// <param name="value">value属性</param>
    /// <returns></returns>
    public static class HtmlExtensions
    {
        /// <summary>
        /// 自定义一个@html.Submit()
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="value">value属性</param>
        /// <returns></returns>
        public static MvcHtmlString Submit(this HtmlHelper helper, string value)
        {
            var builder = new TagBuilder("input");
            builder.MergeAttribute("type", "submit");
            builder.MergeAttribute("value", value);
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }

        public static MvcHtmlString Img(this HtmlHelper helper, string src)
        {
            var builder = new TagBuilder("img");
            builder.MergeAttribute("src", src);
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}