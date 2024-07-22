using HS14MVC.Applicationn.DTOs.ArticleDTOs;
using HS14MVC.Applicationn.Services.ArticleServices;
using HS14MVC.Applicationn.Services.AuthorServices;
using HS14MVC.Applicationn.Services.SubjectServices;
using HS14MVC.UI.Areas.Author.Models.ArticleVMs;
using HS14MVC.UI.Extentions;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using System.Security.Claims;

namespace HS14MVC.UI.Areas.Author.Controllers
{
    public class ArticleController : AuthorBaseController
    {
        private readonly IAuthorService _authorService;
        private readonly IArticleService _articleService;
        private readonly ISubjectService _subjectService;
        private readonly IStringLocalizer<ModelResource> _stringLocalizer; // Burdaki ModelResource dosyamızı boş olarak oluşturduk.

        public ArticleController(IAuthorService authorService, IArticleService articleService, ISubjectService subjectService, IStringLocalizer<ModelResource> stringLocalizer)
        {
            _authorService = authorService;
            _articleService = articleService;
            _subjectService = subjectService;
            _stringLocalizer = stringLocalizer;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var authorId = await _authorService.GetAuthorIdByIdentityId(userId);
            var result = await _articleService.GetAllAsync(authorId);
            var articleListVms = result.Data.Adapt<List<ArticleListVM>>();
            if (!result.IsSuccess)
            {
                NotifiyError(result.Messages);
                return View(articleListVms);
            }
            NotifiySuccess(_stringLocalizer["Success"]);
            return View(articleListVms);
        }


        public async Task<IActionResult> Create()
        {
            var createVM = new ArticleCreateVM()
            {
                Subjects = await GetSubjects()
            };
            return View(createVM);
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var authorId = await _authorService.GetAuthorIdByIdentityId(userId);
            var result = await _articleService.DeleteAsync(id,authorId);
            if (!result.IsSuccess)
            {
                NotifiyError(result.Messages);
                return RedirectToAction("Index");
            }
            NotifiySuccess(result.Messages);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArticleCreateVM model)
        {
            if (!ModelState.IsValid)
            {
                model.Subjects = await GetSubjects();
                return View(model);
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var authorId = await _authorService.GetAuthorIdByIdentityId(userId);
            var articleCreateDto = model.Adapt<ArticleCreateDTO>();
            articleCreateDto.ReadTime = await model.Content.CalculeTimeForString();
            articleCreateDto.AuthorId = authorId;
            if (model.NewImage !=null && model.NewImage.Length>0)
            {
                articleCreateDto.Image = await model.NewImage.StringToByteArrayAsync();
            }
            var result = await _articleService.AddAsync(articleCreateDto);
            if (!result.IsSuccess)
            {
                NotifiyError(result.Messages);
                model.Subjects = await GetSubjects();
                return View(model);
            }
            NotifiySuccess(result.Messages);
            return RedirectToAction("Index");

        }

        private async Task<SelectList> GetSubjects(Guid? subjectId = null)
        {
            var subjects = (await _subjectService.GetAllAsync()).Data;
            return new SelectList(subjects.Select(src => new SelectListItem
            {
                Value = src.Id.ToString(),
                Text = src.Name,
                Selected = src.Id == (subjectId != null ? subjectId.Value : subjectId)
            }).OrderBy(x => x.Text), "Value", "Text");
        }
    }
}
