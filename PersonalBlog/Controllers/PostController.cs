using System.Web.Mvc;
using PersonalBlog.DAL.DALs;
using PersonalBlog.DAL.MockDAL;
using PersonalBlog.DAL.Results;

namespace PersonalBlog.Controllers
{
    public class PostController : Controller
    {
        public ActionResult Index(long postId)
        {
            var postResult = PostDal.Get(postId);

            if (postResult.ProblemType == ProblemType.NoProblem)
                return View(postResult.Result);

            return new HttpNotFoundResult();
        }
    }
}