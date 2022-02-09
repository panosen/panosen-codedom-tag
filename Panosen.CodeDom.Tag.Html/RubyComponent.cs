using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// RubyComponent  ruby 注释
    /// </summary>
    public class RubyComponent : HtmlComponent
    {

        /// <summary>
        /// ruby
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Ruby;
    }
}
