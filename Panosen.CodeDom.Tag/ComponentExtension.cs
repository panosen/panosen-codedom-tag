using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag
{
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
