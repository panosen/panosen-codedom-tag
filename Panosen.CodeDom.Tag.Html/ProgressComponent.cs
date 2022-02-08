using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// ProgressComponent 任何类型的任务的进度
    /// </summary>
    public class ProgressComponent : HtmlComponent
    {

        /// <summary>
        /// progress
        /// </summary>
        public override string Name { get; set; } = "progress";
    }
}
