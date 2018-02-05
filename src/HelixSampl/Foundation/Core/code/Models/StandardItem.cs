using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelixSampl.Foundation.Core.Models
{
    public class StandardItem
    {
        [SitecoreType(TemplateId = Templates.StandardItem.Id, AutoMap = true)]
        public class StandardItem : IStandardItem
        {
            [SitecoreId, IndexField("_group")]
            public virtual Guid Id { get; set; }

            [SitecoreInfo(SitecoreInfoType.Name), IndexField("_name")]
            public virtual string Name { get; set; }

            [SitecoreInfo(SitecoreInfoType.TemplateId), IndexField("_template")]
            public virtual Guid TemplateId { get; set; }

            [SitecoreInfo(SitecoreInfoType.TemplateName), IndexField("_templatename")]
            public virtual string TemplateName { get; set; }

            [SitecoreField("__Sortorder"), IndexField("__Sortorder")]
            public virtual string SortOrder { get; set; }

            [SitecoreField("__created"), IndexField("__created")]
            public virtual DateTime CreatedDate { get; set; }

            [SitecoreField("__updated"), IndexField("__updated")]
            public virtual DateTime UpdatedDate { get; set; }

            [SitecoreInfo(SitecoreInfoType.Language), IndexField("_language")]
            public virtual Language Language { get; set; }

            [TypeConverter(typeof(IndexFieldItemUriValueConverter)), XmlIgnore, IndexField("_uniqueid")]
            public virtual ItemUri Uri { get; set; }

            [SitecoreInfo(SitecoreInfoType.DisplayName)]
            public virtual string DisplayName { get; set; }

            [SitecoreInfo(SitecoreInfoType.Version)]
            public virtual int Version { get; set; }

            [SitecoreInfo(SitecoreInfoType.Path), IndexField("_path")]
            public virtual string Path { get; set; }

            [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
            public virtual string Url { get; set; }

            [IndexField("_fullpath")]
            public virtual string FullPath { get; set; }

            [SitecoreInfo(SitecoreInfoType.Url,
                UrlOptions = SitecoreInfoUrlOptions.AlwaysIncludeServerUrl | SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
            public virtual string FullUrl { get; set; }

        }
    }