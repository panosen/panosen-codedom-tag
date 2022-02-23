using System.Collections.Generic;

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
        public static TComponent SetName<TComponent>(this TComponent component, string name) where TComponent : Component
        {
            component.Name = name;

            return component;
        }

        /// <summary>
        /// 设置Comment
        /// </summary>
        public static TComponent SetComment<TComponent>(this TComponent component, string comment) where TComponent : Component
        {
            component.Comment = comment;

            return component;
        }

        /// <summary>
        /// 添加一个属性
        /// </summary>
        public static TComponent AddProperty<TComponent>(this TComponent component, string propertyKey, int propertyValue)
            where TComponent : Component
        {
            return AddProperty(component, propertyKey, propertyValue.ToString());
        }

        /// <summary>
        /// 添加一个属性
        /// </summary>
        public static TComponent AddProperty<TComponent>(this TComponent component, string propertyKey, string propertyValue)
            where TComponent : Component
        {
            if (component.PropertyMap == null)
            {
                component.PropertyMap = new Dictionary<string, string>();
            }

            component.PropertyMap[propertyKey] = propertyValue;

            return component;
        }

        /// <summary>
        /// 添加一个特性
        /// </summary>
        public static TComponent AddAttribute<TComponent>(this TComponent component, string attribute)
            where TComponent : Component
        {
            if (component.AttributeSet == null)
            {
                component.AttributeSet = new HashSet<string>();
            }

            component.AttributeSet.Add(attribute);

            return component;
        }
    }
}
