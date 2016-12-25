using System.Web.Mvc;
using PersonalBlog.DAL.DALs;
using PersonalBlog.DAL.Results;

namespace PersonalBlog.Controllers
{
    public class PostController : Controller
    {
        public ActionResult Index(int postId)
        {
            var postResult = PostDal.Get(postId, true);

            if (postResult.ProblemType == ProblemType.NoProblem)
                return View(postResult.Result);

            return new HttpNotFoundResult();
        }
    }
}