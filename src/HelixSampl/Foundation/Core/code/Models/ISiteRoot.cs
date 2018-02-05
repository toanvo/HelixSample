using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelixSampl.Foundation.Core.Models
{
    public interface ISiteRoot
    {
        [SitecoreField(Templates.SiteRoot.Fields.Logo)]
        Image Logo { get; set; }

        [SitecoreField(Templates.SiteRoot.Fields.Copyright)]
        string Copyright { get; set; }

        [SitecoreField(Templates.SiteRoot.Fields.OrganisationName)]
        string OrganisationName { get; set; }

        [SitecoreField(Templates.SiteRoot.Fields.OrganisationAddress)]
        string OrganisationAddress { get; set; }

        [SitecoreField(Templates.SiteRoot.Fields.OrganisationPhone)]
        string OrganisationPhone { get; set; }

        [SitecoreField(Templates.SiteRoot.Fields.OrganisationEmail)]
        string OrganisationEmail { get; set; }

        [SitecoreField(BaseTemplates.SiteRoot.Fields.Languages)]
        IEnumerable<Item> Languages { get; set; }
    }
}