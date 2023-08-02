using DtoLayer.Dtos.AppUserDto;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net.Mail;

namespace UILayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager;
        public RegisterController(Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager)
        {

            _userManager = userManager; 

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            Random random = new Random();

            int code = random.Next(100000, 1000000);


			if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.Username,
                    Name = appUserRegisterDto.Name,
                    Surname = appUserRegisterDto.Surname,
                    Email = appUserRegisterDto.Email,
                    City="aa",
                    District="bb",
                    ImageUrl="cc",
                    ConfirmCode=code
                   
                };
                var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);

                if (result.Succeeded)
                {
                    MimeMessage mimeMessage = new MimeMessage();
                    MailboxAddress mailboxAddressFrom = new MailboxAddress("Easy Cash Admin", "kaipoglu267@gmail.com");
                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);

                    mimeMessage.From.Add(mailboxAddressFrom);
                    mimeMessage.To.Add(mailboxAddressTo);


                    var bodybuilder = new BodyBuilder();
                    bodybuilder.TextBody = "Kayıt işlemini gerçekleştirmek için onay kodunuz: " + code;
                    mimeMessage.Body=bodybuilder.ToMessageBody();

                    mimeMessage.Subject = "easy cash onay kodu";

                    MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("kaipoglu267@gmail.com", "mczvwazmpzmkctgi");
                    client.Send(mimeMessage);
                    client.Disconnect(true);






                    return RedirectToAction("Index", "ConfirmMail");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
 

            }

            return View();

        }
    }
}
