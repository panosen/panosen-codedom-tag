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
        public static TChildComponent AddChild<TChildComponent>(this BasicComponent component, string childComponentName = null)
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
        public static TBasicComponent AddChild<TBasicComponent>(this TBasicComponent component, Component childComponent)
            where TBasicComponent : BasicComponent
        {
            if (component.Children == null)
            {
                component.Children = new List<Component>();
            }

            component.Children.Add(childComponent);

            return component;
        }

        /// <summary>
        /// 添加一批子节点
        /// </summary>
        public static TBasicComponent AddChildren<TBasicComponent>(this TBasicComponent component, List<Component> components)
            where TBasicComponent : BasicComponent
        {
            if (components == null || components.Count == 0)
            {
                return component;
            }

            if (component.Children == null)
            {
                component.Children = new List<Component>();
            }

            component.Children.AddRange(components);

            return component;
        }
    }
}
