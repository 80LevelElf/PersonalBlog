using System.Web.Mvc;
using PersonalBlog.DAL.DALs;
using PersonalBlog.DAL.Results;
using PersonalBlog.Logic.Managers;
using PersonalBlog.Models;

namespace PersonalBlog.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
		public ActionResult Index()
        {
            return View(PostBaseDal.GetList(1, 10));
        }

        public ActionResult Add()
        {
            return View("AddOrUpdatePost", new AddOrUpdatePostModel
            {
                PostId = null,
                Source = string.Empty
            });
        }

        public ActionResult Update(int postId)
        {
            var result = PostDal.Get(postId);
            if (result.ProblemType != ProblemType.NoProblem)
                return HttpNotFound();

            var post = result.Result;

            return View("AddOrUpdatePost", new AddOrUpdatePostModel
            {
                PostId = postId,
                Source = PostManager.RestoreSource(post.Source, post.PreviewEndIndex),
                Title = post.Title
            });
        }

        public ActionResult Delete(int postId)
        {
            PostDal.Delete(postId);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddOrUpdate(AddOrUpdatePostModel model)
        {
            if (model.PostId == null)
                PostDal.Insert(model.ToPostDto());
            else
                PostDal.Update(model.ToPostDto());

            return Content(Url.Action("Index"));
        }
    }
}