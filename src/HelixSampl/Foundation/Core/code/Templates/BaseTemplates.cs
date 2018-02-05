using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelixSampl.Foundation.Core.Templates
{
    public static class BaseTemplates
    {
        public struct StandardItem
        {
            public const string Id = "{1930BBEB-7805-471A-A3BE-4858AC7CF696}";
        }

        public struct SiteRoot
        {
            public const string Id = "{F7A13916-9F08-44A0-BFAC-A65B999EE0C4}";
            public struct Fields
            {
                public const string Logo = "{B5E7F5E1-87C1-40BC-973A-561177A7DF6A}";
                public const string Copyright = "{007842A1-5006-419F-BAD1-41FC186F8778}";
                public const string OrganisationName = "{F7A13916-9F08-44A0-BFAC-A65B999EE0C4}";
                public const string OrganisationAddress = "{92E04668-E00B-42D5-B3B0-ADC7FCDB720F}";
                public const string OrganisationPhone = "{8FF7BDD1-2474-45BE-BADD-DA86D59030D9}";
                public const string OrganisationEmail = "{A9E8449B-44AF-44A5-BF99-9D79B041A91E}";
                public const string Languages = "{15D6EBDC-AA5D-4AF1-828B-1BFB8F4A9DA9}";
            }
        }

        public struct Metadata
        {
            public const string Id = "{AC9CED62-83C3-487D-8362-38DE228BAAF9}";
            public struct Fields
            {
                public const string PageTitle = "{56231F54-2712-4D6C-93B6-BEA8EF6F14E6}";
                public const string PageDescription = "{490DD3DE-3FEC-4543-9EC2-D8425E38D2AA}";
                public const string PageKeywords = "{E2EA6DFA-85EB-40EF-93D1-8AAE1E465590}";
                public const string MetaTitle = "{EF79008B-82A1-4C4A-8020-AF231407AF0E}";
                public const string MetaDescription = "{CDCF5F10-49EC-4CA2-987A-449DEA38E8B5}";
                public const string MetaImage = "{AE893AF1-1D53-42EF-A56E-443E520498E9}";
                public const string MetaType = "{41C7D91E-A871-438F-AC15-E3478EEE840D}";
                public const string MetaCard = "{427E395F-B1C7-4CE8-89D8-CB0806B7E41C}";
            }
        }

        public struct BaseContent
        {
            public const string Id = "{CFB4EA78-857E-447B-8426-AB910D06CAA5}";

            public struct Fields
            {
                public const string Headline = "{AF322FEC-1307-4D2B-8510-B662FAE2407D}";
                public const string ShortDescription = "{84E063F7-3F26-41EE-B8B9-F5775CB24713}";
                public const string Body = "{9E4D4FD3-6D98-494A-94D7-962C43DBF12A}";
            }
        }

        public struct ContentFolder
        {
            public const string Id = "{B5E7F5E1-87C1-40BC-973A-561177A7DF6A}";
        }

        public struct OptionFolder
        {
            public const string Id = "{3A558212-F615-4BC0-996F-FF3E2DA66659}";
        }

        public struct SettingsFolder
        {
            public const string Id = "{81194B8A-DB9E-4F11-B237-DC7AE3D627EC}";
        }

        public struct BasePage
        {
            public const string Id = "{329AA89C-91E2-4E16-806C-A48A7B862AD3}";
        }

        public struct Option
        {
            public const string Id = "{33F3A764-0672-4684-839A-39C39D0C8CD9}";
            public struct Fields
            {
                public const string Value = "{FF804E78-FFF5-4F09-97C1-3C2414CE3FE9}";
            }
        }
    }
}