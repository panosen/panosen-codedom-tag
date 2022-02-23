using System.Collections.Generic;

namespace Panosen.CodeDom.Tag
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class ComponentCollectionExtension
    {
        /// <summary>
        /// AddComponent
        /// </summary>
        public static TComponentCollection AddComponent<TComponentCollection>(this TComponentCollection componentCollection, Component component)
            where TComponentCollection : ComponentCollection
        {
            if (componentCollection.Components == null)
            {
                componentCollection.Components = new List<Component>();
            }

            componentCollection.Components.Add(component);

            return componentCollection;
        }

        /// <summary>
        /// AddComponent
        /// </summary>
        public static TComponent AddComponent<TComponent>(this ComponentCollection componentCollection)
            where TComponent : Component, new()
        {
            if (componentCollection.Components == null)
            {
                componentCollection.Components = new List<Component>();
            }

            TComponent component = new TComponent();

            componentCollection.Components.Add(component);

            return component;
        }
    }
}
