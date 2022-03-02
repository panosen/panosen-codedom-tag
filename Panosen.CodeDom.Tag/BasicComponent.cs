using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag
{
    /// <summary>
    /// 组件
    /// </summary>
    public class BasicComponent : Component
    {
        /// <summary>
        /// 在前面(外)和后面(外)插入空行
        /// </summary>
        public bool Margin { get; set; }

        /// <summary>
        /// 在前面(外)插入空行
        /// </summary>
        public bool MarginTop { get; set; }

        /// <summary>
        /// 在后面(外)插入空行
        /// </summary>
        public bool MarginBottom { get; set; }

        /// <summary>
        /// 在前面(内)和后面(内)插入空行
        /// </summary>
        public bool Padding { get; set; }

        /// <summary>
        /// 在前面(内)插入空行
        /// </summary>
        public bool PaddingTop { get; set; }

        /// <summary>
        /// 在后面(内)插入空行
        /// </summary>
        public bool PaddingBottom { get; set; }

        /// <summary>
        /// 主体
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否是内置组件
        /// </summary>
        public virtual bool BuiltIn { get; set; }

        /// <summary>
        /// 组件来源。用于import
        /// </summary>
        public string ComponentFrom { get; set; }

        /// <summary>
        /// 是否带
        /// </summary>
        public virtual bool SelfClosing { get; set; }

        /// <summary>
        /// css
        /// </summary>
        public HashSet<string> CssClassSet { get; set; }

        /// <summary>
        /// 子节点
        /// </summary>
        public List<Component> Children { get; set; }
    }
}
