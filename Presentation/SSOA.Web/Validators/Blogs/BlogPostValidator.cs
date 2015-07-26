using FluentValidation;
using SSOA.Services.Localization;
using SSOA.Web.Framework.Validators;
using SSOA.Web.Models.Blogs;

namespace SSOA.Web.Validators.Blogs
{
    public class BlogPostValidator : BaseSSOAValidator<BlogPostModel>
    {
        public BlogPostValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.AddNewComment.CommentText).NotEmpty().WithMessage(localizationService.GetResource("Blog.Comments.CommentText.Required")).When(x => x.AddNewComment != null);
        }}
}