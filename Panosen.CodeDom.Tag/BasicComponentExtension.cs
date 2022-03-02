using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Panosen.CodeDom.Tag
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
        /// 在前面(外)和后面(外)插入空行
        /// </summary>
        public static TBasicComponent SetMargin<TBasicComponent>(this TBasicComponent component, bool margin)
            where TBasicComponent : BasicComponent
        {
            component.Margin = margin;

            return component;
        }

        /// <summary>
        /// 在前面(外)插入空行
        /// </summary>
        public static TBasicComponent SetMarginTop<TBasicComponent>(this TBasicComponent component, bool marginTop)
            where TBasicComponent : BasicComponent
        {
            component.MarginTop = marginTop;

            return component;
        }

        /// <summary>
        /// 在后面(外)插入空行
        /// </summary>
        public static TBasicComponent SetMarginBottom<TBasicComponent>(this TBasicComponent component, bool marginBottom)
            where TBasicComponent : BasicComponent
        {
            component.MarginBottom = marginBottom;

            return component;
        }

        /// <summary>
        /// 在前面(内)和后面(内)插入空行
        /// </summary>
        public static TBasicComponent SetPadding<TBasicComponent>(this TBasicComponent component, bool padding)
            where TBasicComponent : BasicComponent
        {
            component.Padding = padding;

            return component;
        }

        /// <summary>
        /// 在前面(内)插入空行
        /// </summary>
        public static TBasicComponent SetPaddingTop<TBasicComponent>(this TBasicComponent component, bool paddingTop)
            where TBasicComponent : BasicComponent
        {
            component.PaddingTop = paddingTop;

            return component;
        }

        /// <summary>
        /// 在后面(内)插入空行
        /// </summary>
        public static TBasicComponent SetPaddingBotom<TBasicComponent>(this TBasicComponent component, bool paddingBottom)
            where TBasicComponent : BasicComponent
        {
            component.PaddingBottom = paddingBottom;

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
        public static TBasicComponent AddChildren<TBasicComponent>(this TBasicComponent component, IEnumerable<Component> components)
            where TBasicComponent : BasicComponent
        {
            if (components == null || components.Count() == 0)
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

        /// <summary>
        /// 添加一批子节点
        /// </summary>
        public static TBasicComponent AddChildren<TBasicComponent>(this TBasicComponent component, ComponentCollection componentCollection)
            where TBasicComponent : BasicComponent
        {
            if (componentCollection == null || componentCollection.Components == null || componentCollection.Components.Count == 0)
            {
                return component;
            }

            if (component.Children == null)
            {
                component.Children = new List<Component>();
            }

            component.Children.AddRange(componentCollection.Components);

            return component;
        }
    }
}
