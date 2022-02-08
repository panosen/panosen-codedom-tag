using System.Collections.Generic;

namespace Panosen.CodeDom.Tag.Engine
{
    /// <summary>
    /// GenerateOptionsExtension
    /// </summary>
    public static class GenerateOptionsExtension
    {
        private static readonly BasicComponentEngine basicComponentEngine = new BasicComponentEngine();

        /// <summary>
        /// AddTagEngine
        /// </summary>
        public static GenerateOptions AddComponentEngine(this GenerateOptions options, ComponentEngine componentEngine)
        {
            if (options.ComponentEngineList == null)
            {
                options.ComponentEngineList = new List<ComponentEngine>();
            }

            options.ComponentEngineList.Add(componentEngine);

            return options;
        }

        /// <summary>
        /// GetTagEngine
        /// </summary>
        /// <param name="options"></param>
        /// <param name="component"></param>
        /// <returns></returns>
        public static ComponentEngine GetComponentEngine(this GenerateOptions options, Component component)
        {
            if (options.ComponentEngineList != null && options.ComponentEngineList.Count != 0)
            {
                foreach (var componentEngine in options.ComponentEngineList)
                {
                    if (componentEngine.GetType().BaseType.GetGenericArguments()[0].IsAssignableFrom(component.GetType()))
                    {
                        return componentEngine;
                    }
                }
            }

            if (typeof(BasicComponent).IsAssignableFrom(component.GetType()))
            {
                return basicComponentEngine;
            }

            return null;
        }
    }
}
