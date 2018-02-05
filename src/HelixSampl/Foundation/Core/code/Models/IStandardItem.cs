using HelixSampl.Foundation.Core.Templates;
using System;

namespace HelixSampl.Foundation.Core.Models
{
    [SitecoreType(TemplateId = BaseTemplates.StandardItem.Id, AutoMap = true)]
    public interface IStandardItem
    {
        [SitecoreId, IndexField("_group")]
        Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name), IndexField("_name")]
        string Name { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId), IndexField("_template")]
        Guid TemplateId { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName), IndexField("_templatename")]
        string TemplateName { get; set; }

        [SitecoreField("__Sortorder"), IndexField("__Sortorder")]
        string SortOrder { get; set; }

        [SitecoreField("__created"), IndexField("__created")]
        DateTime CreatedDate { get; set; }

        [SitecoreField("__updated"), IndexField("__updated")]
        DateTime UpdatedDate { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language), IndexField("_language")]
        Language Language { get; set; }

        [TypeConverter(typeof(IndexFieldItemUriValueConverter)), XmlIgnore, IndexField("_uniqueid")]
        ItemUri Uri { get; set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        string DisplayName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; set; }

        [SitecoreInfo(SitecoreInfoType.Path), IndexField("_path")]
        string Path { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        string Url { get; set; }

        [IndexField("_fullpath")]
        string FullPath { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url,
            UrlOptions = SitecoreInfoUrlOptions.AlwaysIncludeServerUrl | SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        string FullUrl { get; set; }
    }
}
