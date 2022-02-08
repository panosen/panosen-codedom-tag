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
}
