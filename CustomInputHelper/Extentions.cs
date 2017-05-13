using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public enum BulletStyle
    {
        Disk,Square,Circle,LowerRoman,UpperRoman
    }
    public static class Extentions
    {
        public static MvcHtmlString BulletList(this HtmlHelper helper, IEnumerable<string> items,BulletStyle bulletStyle=BulletStyle.Disk)
        {
            string html = "<ul style='list-style-type:{0}'>{1}</ul>";
            string bulletType = "disk";
            switch (bulletStyle)
            {
                case BulletStyle.Disk:
                    bulletType = "disk";
                    break;
                case BulletStyle.Square:
                    bulletType = "square";
                    break;
                case BulletStyle.Circle:
                    bulletType = "circle";
                    break;
                case BulletStyle.LowerRoman:
                    bulletType = "lower-roman";
                    break;
                case BulletStyle.UpperRoman:
                    bulletType = "upper-roman";
                    break;
                default:
                    break;
            }   

            string liTemplate = "<li>{0}</li>";
            string liHtml = "";
            foreach (var item in items)
            {
                var itemLi = string.Format(liTemplate, item);
                liHtml = liHtml + itemLi;
            }
            html = string.Format(html,bulletType,liHtml);
            return new MvcHtmlString(html);
        }
    }
}