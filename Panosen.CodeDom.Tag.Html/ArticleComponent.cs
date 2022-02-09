using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Html
{

    /// <summary>
    /// ArticleComponent 文章
    /// </summary>
    public class ArticleComponent : HtmlComponent
    {

        /// <summary>
        /// article
        /// </summary>
        public override string Name { get; set; } = HtmlTagNames.Article;
    }
}
