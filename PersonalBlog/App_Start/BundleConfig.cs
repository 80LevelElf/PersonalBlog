using System.Web.Optimization;

namespace PersonalBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/markdown-editor")
                .Include("~/Scripts/markdown/markdown.js")
                .Include("~/Scripts/markdown/simplemde.js")
                .Include("~/Scripts/markdown/md-editor.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
			bundles.Add(new StyleBundle("~/Content/css/blog").Include("~/Content/blog.css"));
            bundles.Add(new StyleBundle("~/Content/css/aboutMe").Include("~/Content/pages/aboutMe.css"));
			bundles.Add(new StyleBundle("~/Content/css/myProjects").Include("~/Content/pages/myProjects.css"));
            bundles.Add(new StyleBundle("~/Content/css/post-previews").Include("~/Content/pages/post-previews.css"));
            bundles.Add(new StyleBundle("~/Content/css/post").Include("~/Content/pages/post.css"));
            bundles.Add(new StyleBundle("~/Content/css/login").Include("~/Content/pages/login.css"));
            bundles.Add(new StyleBundle("~/Content/css/adminLayout").Include("~/Content/pages/adminLayout.css"));

            bundles.Add(new StyleBundle("~/Content/css/markdown-editor").Include("~/Content/markdown/simplemde.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.min.theme.css",       
                        "~/Content/themes/base/jquery-ui.css",
                        "~/Content/themes/base/jquery-ui.structure.css"));
        }
    }
}