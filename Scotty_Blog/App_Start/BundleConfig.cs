using System.Web;
using System.Web.Optimization;

namespace Scotty_Blog
{
    public class BundleConfig
    {
    //<link href = '//fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>


        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Blog/Scripts").Include(
                 "~/Scripts/jquery.min.js" ,
                 "~/Scripts/bootstrap.bundle.min.js" ,
                 "~/Scripts/clean-blog.min.js" ,
                 "~/Scripts/tinymce/tinymce.min.js",
                 "~/Scripts/tinymce/jquery.tinymce.min.js" ));

            bundles.Add(new StyleBundle("~/Blog/Styles").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/all.min.css",
                "~/Content/clean-blog.min.css"));
        }
    }
}
