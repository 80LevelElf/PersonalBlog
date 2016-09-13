using System.Web.Optimization;

namespace PersonalBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/markdown-editor")
                .Include("~/Scripts/markdown/simplemde.js")
                .Include("~/Scripts/markdown/md-editor.js"));

            //Turn off minification of this bundle, because it's crush all :(
            var markDownBundle = new ScriptBundle("~/bundles/markdown").Include(
                "~/Scripts/markdown/markdown.js");
            markDownBundle.Transforms.Clear();
            bundles.Add(markDownBundle);

            bundles.Add(new ScriptBundle("~/bundles/utils").Include("~/Scripts/utils.js"));
			bundles.Add(new ScriptBundle("~/bundles/highlight").Include("~/Scripts/highlight.js"));
			bundles.Add(new ScriptBundle("~/bundles/postManager").Include("~/Scripts/postManager.js"));

            bundles.Add(new ScriptBundle("~/bundles/addOrUpdatePost").Include("~/Scripts/pages/addOrUpdatePost.js"));
            bundles.Add(new ScriptBundle("~/bundles/postPreview").Include("~/Scripts/pages/postPreview.js"));
			bundles.Add(new ScriptBundle("~/bundles/post").Include("~/Scripts/pages/post.js"));

            //CSS
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
			bundles.Add(new StyleBundle("~/Content/css/blog").Include("~/Content/blog.css"));
            bundles.Add(new StyleBundle("~/Content/css/aboutMe").Include("~/Content/pages/aboutMe.css"));
			bundles.Add(new StyleBundle("~/Content/css/myProjects").Include("~/Content/pages/myProjects.css"));
            bundles.Add(new StyleBundle("~/Content/css/post-previews")
				.Include("~/Content/pages/post-previews.css")
				.Include("~/Content/postMarkup.css"));
            bundles.Add(new StyleBundle("~/Content/css/post")
				.Include("~/Content/pages/post.css")
				.Include("~/Content/postMarkup.css"));
            bundles.Add(new StyleBundle("~/Content/css/login").Include("~/Content/pages/login.css"));
            bundles.Add(new StyleBundle("~/Content/css/adminLayout").Include("~/Content/pages/adminLayout.css"));

            bundles.Add(new StyleBundle("~/Content/css/markdown-editor").Include("~/Content/markdown/simplemde.css"));

			bundles.Add(new StyleBundle("~/Content/css/highlightStyle").Include("~/Content/highlightStyles/vs.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(      
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}