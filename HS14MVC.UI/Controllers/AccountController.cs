using HS14MVC.Applicationn.DTOs.AuthorDTOs;
using HS14MVC.Applicationn.DTOs.MailDTOs;
using HS14MVC.Applicationn.Services.AuthorServices;
using HS14MVC.Applicationn.Services.MailServices;
using HS14MVC.Domain.Enums;
using HS14MVC.UI.Models;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Licenses;

namespace HS14MVC.UI.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IMailService _mailService;
        private readonly IAuthorService _authorService;

        

        private const string userPassword = "newPassword+1";

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IMailService mailService, IAuthorService authorService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mailService = mailService;
            _authorService = authorService;
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, userPassword);
                if (result.Succeeded)
                {
                   await _userManager.AddToRoleAsync(user, Roles.Author.ToString());
                    var confirmCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = confirmCode }, protocol: Request.Scheme);
                    var mailDTO = new SendMailDTO();
                    mailDTO.Email = model.Email;
                    mailDTO.Subject = "Üyelik İşlemleri";
                    mailDTO.Message = $"Hesabınızın onaylanması için <a href='{url}'>link</a>e tıklayınız!..<br/> Şifreniz = {userPassword}";

                    await _mailService.SendMailAsync(mailDTO);
                    var authorCreateDto = model.Adapt<AuthorCreateDTO>();
                    authorCreateDto.IdentityId = user.Id;
                    await _authorService.AddAsync(authorCreateDto);
                    NotifiyWarning("Üye işlemleriniz tamamlanması için mailinizi kontrol etmelisiniz");
                    return RedirectToAction("Login");
                }
            }
            NotifiyError("Üyelik işlemi yapılırken hata oluştu");
            return View(model);
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.ConfirmEmailAsync(user, code);
            return RedirectToAction("Login");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVm model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user is null)
                {
                    NotifiyError("Kullanıcı veya şifre hatalı");
                    return View(model);
                }
                var checkPassword = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (!checkPassword.Succeeded)
                {
                    NotifiyError("Kullanıcı veya şifre hatalı");
                    return View(model);
                }
                var userRole = await _userManager.GetRolesAsync(user);
                if (userRole == null)
                {
                    NotifiyError("Kullanıcı veya şifre hatalı");
                    return View(model);
                }
                return RedirectToAction("Index", "Home" ); //new { Area = userRole[0].ToString() } area yönlendirmesi için kullanıyoruz
            }
            return View(model);
        }

    }
}
