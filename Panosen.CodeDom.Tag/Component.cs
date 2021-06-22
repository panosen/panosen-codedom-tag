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

    /// <summary>
    /// 组件扩展
    /// </summary>
    public static class ComponentExtension
    {
        /// <summary>
        /// 设置Name
        /// </summary>
        /// <typeparam name="TComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static TComponent SetName<TComponent>(this TComponent component, string name) where TComponent : Component
        {
            component.Name = name;

            return component;
        }

        /// <summary>
        /// 设置Comment
        /// </summary>
        /// <typeparam name="TComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static TComponent SetComment<TComponent>(this TComponent component, string comment) where TComponent : Component
        {
            component.Comment = comment;

            return component;
        }
    }
}
