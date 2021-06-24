using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.CodeDom.Tag.Engine
{
    /// <summary>
    /// GenerateOptions
    /// </summary>
    public class GenerateOptions
    {
        /// <summary>
        /// TabString
        /// </summary>
        public string TabString { get; set; } = "    ";

        private int indentSize = 0;

        /// <summary>
        /// ComponentEngineMap
        /// </summary>
        public Dictionary<Type, ComponentEngine> ComponentEngineMap { get; set; }

        /// <summary>
        /// 缩进个数
        /// </summary>
        public int IndentSize
        {
            get
            {
                return this.indentSize;
            }
            set
            {
                this.indentSize = value;
                BuildIndentString();
            }
        }

        /// <summary>
        /// 缩进字符
        /// </summary>
        public string IndentString { get; private set; } = string.Empty;

        /// <summary>
        /// 增加缩进
        /// </summary>
        public void PushIndent()
        {
            this.indentSize = this.indentSize + 1;

            BuildIndentString();
        }

        /// <summary>
        /// 减少缩进
        /// </summary>
        public void PopIndent()
        {
            if (this.indentSize > 0)
            {
                this.indentSize = this.indentSize - 1;
            }

            BuildIndentString();
        }

        /// <summary>
        /// 构建缩进
        /// </summary>
        /// <returns></returns>
        private void BuildIndentString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.indentSize; i++)
            {
                builder.Append(this.TabString);
            }
            this.IndentString = builder.ToString();
        }
    }

    /// <summary>
    /// GenerateOptionsExtension
    /// </summary>
    public static class GenerateOptionsExtension
    {
        /// <summary>
        /// AddTagEngine
        /// </summary>
        /// <typeparam name="TComponent"></typeparam>
        /// <param name="options"></param>
        /// <param name="tagEngine"></param>
        public static GenerateOptions AddComponentEngine<TComponent>(this GenerateOptions options, ComponentEngine tagEngine)
            where TComponent : Component
        {
            var type = typeof(TComponent);

            if (options.ComponentEngineMap == null)
            {
                options.ComponentEngineMap = new Dictionary<Type, ComponentEngine>();
            }

            if (options.ComponentEngineMap.ContainsKey(type))
            {
                return options;
            }

            options.ComponentEngineMap.Add(type, tagEngine);

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
            if (options.ComponentEngineMap == null || options.ComponentEngineMap.Count == 0)
            {
                return null;
            }

            if (options.ComponentEngineMap.ContainsKey(component.GetType()))
            {
                return options.ComponentEngineMap[component.GetType()];
            }

            foreach (var item in options.ComponentEngineMap)
            {
                var engine = item.Value;
                if (engine.GetType().BaseType.GetGenericArguments()[0].IsAssignableFrom(component.GetType()))
                {
                    return engine;
                }
            }

            return null;
        }
    }
}
