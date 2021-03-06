using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Foundation.Cms.Blocks
{
    [ContentType(DisplayName = "Call To Action Block",
        GUID = "f82da800-c923-48f6-b701-fd093078c5d9",
        Description = "Provides a CTA anchor or link",
        GroupName = CmsGroupNames.Content)]
    [ImageUrl("~/assets/icons/cms/blocks/CMS-icon-block-26.png")]
    public class CallToActionBlock : FoundationBlockData
    {
        [CultureSpecific]
        [Display(Name = "Title", Description = "Title displayed", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString Subtext { get; set; }

        [Display(Name = "Text color", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual string TextColor { get; set; }

        [Display(Name = "Background image", GroupName = SystemTabNames.Content, Order = 40)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BackgroundImage { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 50)]
        public virtual ButtonBlock Button { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            TextColor = "#000";
        }
    }
}