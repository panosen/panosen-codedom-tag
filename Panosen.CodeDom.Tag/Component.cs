using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag
{
    /// <summary>
    /// ComponentBase
    /// </summary>
    public class Component
    {
        /// <summary>
        /// 示例：BookDataTable
        /// </summary>
        public virtual string Name { get; set; } = "div";

        /// <summary>
        /// 注释、备注
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        public Dictionary<string, string> PropertyMap { get; set; }

        /// <summary>
        /// 特性
        /// </summary>
        public HashSet<string> AttributeSet { get; set; }
    }
}
