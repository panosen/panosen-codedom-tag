using Panosen.CodeDom.Tag;
using System;

namespace Panosen.CodeDom.Tag.Html
{
    /// <summary>
    /// HtmlComponent
    /// </summary>
    public class HtmlComponent : BasicComponent
    {
        /// <summary>
        /// Name
        /// </summary>
        public override string Name { get; set; } = "html";

        /// <summary>
        /// BuiltIn
        /// </summary>
        public override bool BuiltIn { get; set; } = true;
    }
}
