using HS14MVC.Applicationn.DTOs.SubjectDTOs;
using HS14MVC.Applicationn.Services.SubjectServices;
using HS14MVC.UI.Areas.Author.Models.SubjectVMs;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace HS14MVC.UI.Areas.Author.Controllers
{
    public class SubjectController : AuthorBaseController
    {
        private readonly ISubjectService _subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _subjectService.GetAllAsync();
            if (!result.IsSuccess)
            {
                NotifiyError(result.Messages);
                return View(result.Data.Adapt<List<SubjectListVM>>());
            }
            NotifiySuccess(result.Messages);
            return View(result.Data.Adapt<List<SubjectListVM>>());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(SubjectCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await _subjectService.AddAsync(model.Adapt<SubjectCreateDTO>());
                if (!result.IsSuccess)
                {
                    NotifiyError(result.Messages);
                    return View(model);
                }
                NotifiySuccess(result.Messages);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
