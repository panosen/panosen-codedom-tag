using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{
    /// <summary>
    /// h1 ~ h6
    /// </summary>
    public class HComponent : HtmlComponent
    {
        private int level;

        /// <summary>
        /// Level
        /// </summary>
        public int Level
        {
            get { return this.level; }
            set
            {
                this.level = value;
                this.Name = "h" + level;
            }
        }

        /// <summary>
        /// h1 ~ h6
        /// </summary>
        /// <param name="level"></param>
        public HComponent(int level)
        {
            this.Level = level;
            this.Name = "h" + level;
        }
    }

    /// <summary>
    /// h1
    /// </summary>
    public class H1Component : HtmlComponent
    {
        /// <summary>
        /// h1
        /// </summary>
        public override string Name { get; set; } = "h1";
    }

    /// <summary>
    /// h2
    /// </summary>
    public class H2Component : HtmlComponent
    {
        /// <summary>
        /// h2
        /// </summary>
        public override string Name { get; set; } = "h2";
    }

    /// <summary>
    /// h3
    /// </summary>
    public class H3Component : HtmlComponent
    {
        /// <summary>
        /// h3
        /// </summary>
        public override string Name { get; set; } = "h3";
    }

    /// <summary>
    /// h4
    /// </summary>
    public class H4Component : HtmlComponent
    {
        /// <summary>
        /// h4
        /// </summary>
        public override string Name { get; set; } = "h4";
    }

    /// <summary>
    /// h5
    /// </summary>
    public class H5Component : HtmlComponent
    {
        /// <summary>
        /// h5
        /// </summary>
        public override string Name { get; set; } = "h5";
    }

    /// <summary>
    /// h6
    /// </summary>
    public class H6Component : HtmlComponent
    {
        /// <summary>
        /// h6
        /// </summary>
        public override string Name { get; set; } = "h6";
    }
}
