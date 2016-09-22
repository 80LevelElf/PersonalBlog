﻿using System.Web.Mvc;
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
	        return RedirectToAction("Posts", new { pageIndex = 1 });
        }

		public ActionResult Posts(int pageIndex)
        {
			return View(PostBaseDal.GetList(pageIndex));
        }

		public ActionResult Logs(int pageIndex)
        {
			return View(LogEntryDal.GetList(pageIndex));
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
            //Get post title from DB too expensive for logging
            LogManager.LogPost(postId.ToString(), "Post was deleted");
            PostDal.Delete(postId);

			return RedirectToAction("Posts", new { pageIndex = 1 });
        }

        [HttpPost]
        public ActionResult AddOrUpdate(AddOrUpdatePostModel model)
        {
            if (model.PostId == null)
            {
                LogManager.LogPost(model.Title, "Post was added");
                PostDal.Insert(model.ToPostDto());
            }
            else
            {
                LogManager.LogPost(model.Title, "Post was updated");
                PostDal.Update(model.ToPostDto());
            }

            return Content(Url.Action("Posts", new { pageIndex = 1 }));
        }
    }
}