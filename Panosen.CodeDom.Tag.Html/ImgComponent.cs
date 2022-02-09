using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// ImgComponent 图像
    /// </summary>
    public class ImgComponent : HtmlComponent
    {

        /// <summary>
        /// img
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Img;

        /// <summary>
        /// SelfClosing
        /// </summary>
        public override bool SelfClosing { get; set; } = true;
    }

    /// <summary>
    /// ImgComponentExtension
    /// </summary>
    public static class ImgComponentExtension
    {
        /// <summary>
        /// src
        /// </summary>
        public static ImgComponent SetSrc(this ImgComponent imgComponent, string src)
        {
            imgComponent.AddProperty("src", src);

            return imgComponent;
        }

        /// <summary>
        /// alt
        /// </summary>
        public static ImgComponent SetAlt(this ImgComponent imgComponent, string alt)
        {
            imgComponent.AddProperty("alt", alt);

            return imgComponent;
        }
    }
}
