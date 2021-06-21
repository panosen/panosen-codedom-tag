using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.CodeDom.Tag.Basic
{
    /// <summary>
    /// BasicComponentExtension
    /// </summary>
    public static class BasicComponentExtension
    {
        /// <summary>
        /// 设置Content
        /// </summary>
        /// <typeparam name="TBasicComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static TBasicComponent SetContent<TBasicComponent>(this TBasicComponent component, string content)
            where TBasicComponent : BasicComponent
        {
            component.Content = content;

            return component;
        }

        /// <summary>
        /// 在前面和后面插入空行
        /// </summary>
        /// <typeparam name="TBasicComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="margin"></param>
        /// <returns></returns>
        public static TBasicComponent SetMargin<TBasicComponent>(this TBasicComponent component, bool margin)
            where TBasicComponent : BasicComponent
        {
            component.Margin = margin;

            return component;
        }

        /// <summary>
        /// 在前面和后面插入空行
        /// </summary>
        /// <typeparam name="TBasicComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="padding"></param>
        /// <returns></returns>
        public static TBasicComponent SetPadding<TBasicComponent>(this TBasicComponent component, bool padding)
            where TBasicComponent : BasicComponent
        {
            component.Padding = padding;

            return component;
        }

        /// <summary>
        /// 设置Content
        /// </summary>
        /// <typeparam name="TBasicComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="builtIn"></param>
        /// <returns></returns>
        public static TBasicComponent SetBuiltIn<TBasicComponent>(this TBasicComponent component, bool builtIn)
            where TBasicComponent : BasicComponent
        {
            component.BuiltIn = builtIn;

            return component;
        }

        /// <summary>
        /// 添加一个属性
        /// </summary>
        /// <typeparam name="TBasicComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="propertyKey"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public static TBasicComponent AddProperty<TBasicComponent>(this TBasicComponent component, string propertyKey, int propertyValue)
            where TBasicComponent : BasicComponent
        {
            return AddProperty(component, propertyKey, propertyValue.ToString());
        }

        /// <summary>
        /// 添加一个属性
        /// </summary>
        /// <typeparam name="TBasicComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="propertyKey"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public static TBasicComponent AddProperty<TBasicComponent>(this TBasicComponent component, string propertyKey, string propertyValue)
            where TBasicComponent : BasicComponent
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
        /// <typeparam name="TBasicComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public static TBasicComponent AddAttribute<TBasicComponent>(this TBasicComponent component, string attribute)
            where TBasicComponent : BasicComponent
        {
            if (component.AttributeSet == null)
            {
                component.AttributeSet = new HashSet<string>();
            }

            component.AttributeSet.Add(attribute);

            return component;
        }

        /// <summary>
        /// 添加一个css样式
        /// </summary>
        /// <typeparam name="TBasicComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="cssClass"></param>
        /// <returns></returns>
        public static TBasicComponent AddCssClass<TBasicComponent>(this TBasicComponent component, string cssClass)
            where TBasicComponent : BasicComponent
        {
            if (component.CssClassSet == null)
            {
                component.CssClassSet = new HashSet<string>();
            }

            component.CssClassSet.Add(cssClass);

            return component;
        }

        /// <summary>
        /// new一个子节点，添加为子节点，返回该子节点
        /// </summary>
        public static TChildComponent AddChild<TBasicComponent, TChildComponent>(this TBasicComponent component, string childComponentName = null)
            where TBasicComponent : BasicComponent
            where TChildComponent : Component, new()
        {
            if (component.Children == null)
            {
                component.Children = new List<Component>();
            }

            TChildComponent childComponent = new TChildComponent();
            if (childComponentName != null)
            {
                childComponent.Name = childComponentName;
            }

            component.Children.Add(childComponent);

            return childComponent;
        }

        /// <summary>
        /// 添加一个子节点
        /// </summary>
        public static void AddChild<TBasicComponent, TChildComponent>(this TBasicComponent component, TChildComponent childComponent)
            where TBasicComponent : BasicComponent
            where TChildComponent : Component
        {
            if (component.Children == null)
            {
                component.Children = new List<Component>();
            }

            component.Children.Add(childComponent);
        }

        /// <summary>
        /// 添加一批子节点
        /// </summary>
        public static void AddChildren<TBasicComponent,TChildComponent>(this TBasicComponent component, List<TChildComponent> components)
            where TBasicComponent : BasicComponent
            where TChildComponent : Component
        {
            if (components == null || components.Count == 0)
            {
                return;
            }

            if (component.Children == null)
            {
                component.Children = new List<Component>();
            }

            component.Children.AddRange(components);
        }
    }
}
