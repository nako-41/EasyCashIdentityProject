using DtoLayer.Dtos.AppUserDto;
using EntityLayer.Concrete;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class RegisterController : Controller
    {
        //private readonly UserManager<AppUser> _userManager;
        //public RegisterController(UserManager<AppUser> userManager)
        //{
        //    _userManager = userManager;
        ////}
        //UserManager<AppUser> _userManager = new UserManager<AppUser>();


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        AppUser appUser = new AppUser()
        //        {
        //            UserName = appUserRegisterDto.Username,
        //            Name= appUserRegisterDto.Name,
        //            Surname = appUserRegisterDto.Surname,
        //            Email = appUserRegisterDto.Email,
        //        };
        //        var result=await _userManager.CreateAsync(appUser,appUserRegisterDto.Password);
        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("Index", "ConfirmMail");
        //        }
        //        return View();

        //    }

        //    return View();
        //}

    }
}
