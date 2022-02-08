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
        public List<ComponentEngine> ComponentEngineList { get; set; }

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
            this.indentSize++;

            BuildIndentString();
        }

        /// <summary>
        /// 减少缩进
        /// </summary>
        public void PopIndent()
        {
            if (this.indentSize > 0)
            {
                this.indentSize--;
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
}
