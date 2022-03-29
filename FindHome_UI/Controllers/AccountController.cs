using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindHome_UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();

        }

        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterViewModel model)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View(model);
        //        }
        //        var checkUserForUserName = await _userManager.FindByNameAsync(model.TCNumber);
        //        if (checkUserForUserName != null)
        //        {
        //            ModelState.AddModelError(nameof(model.TCNumber), "Bu TCKimlik zaten sistemde kayıtlıdır.");
        //            return View(model);
        //        }
        //        var checkUserForEmail = await _userManager.FindByEmailAsync(model.Email);
        //        if (checkUserForEmail != null)
        //        {
        //            ModelState.AddModelError(nameof(model.Email), "Bu email zaten sistemde kayıtlıdır!");
        //            return View(model);
        //        }
        //        // Yeni kullanıcı oluşturalım
        //        AppUser newUser = new AppUser()
        //        {
        //            Email = model.Email,
        //            Name = model.Name,
        //            Surname = model.Surname,
        //            UserName = model.TCNumber,
        //            Gender = model.Gender
        //            //TODO: Birthdate?
        //            //TODO: Phone Number?
        //        };
        //        var result = await _userManager.CreateAsync(newUser, model.Password);
        //        if (result.Succeeded)
        //        {
        //            var roleResult = await _userManager.AddToRoleAsync(newUser, RoleNames.Passive.ToString());

        //            //email gönderilmelidir
        //            var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
        //            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        //            var callBackUrl = Url.Action("ConfirmEmail", "Account", new { userId = newUser.Id, code = code }, protocol: Request.Scheme);

        //            var emailMessage = new EmailMessage()
        //            {
        //                Contacts = new string[] { newUser.Email },
        //                Subject = "MHRSLITE - Email Aktivasyonu",
        //                Body = $"Merhaba {newUser.Name} {newUser.Surname}, <br/>Hesabınızı aktifleştirmek için <a href='{HtmlEncoder.Default.Encode(callBackUrl)}'>buraya</a> tıklayınız."
        //            };

        //            await _emailSender.SendAsync(emailMessage);

        //            //patient tablosuna ekleme yapılmalıdır.
        //            Patient newPatient = new Patient()
        //            {
        //                TCNumber = model.TCNumber,
        //                UserId = newUser.Id
        //            };
        //            if (_unitOfWork.PatientRepository.Add(newPatient) == false)
        //            {
        //                var emailMessageToAdmin = new EmailMessage()
        //                {
        //                    Contacts = new string[]
        //                { _configuration.GetSection("ManagerEmails:Email").Value },
        //                    CC = new string[] { _configuration.GetSection("ManagerEmails:EmailToCC").Value },
        //                    Subject = "MHRSLITE - HATA! Patient Tablosu",
        //                    Body = $"Aşağıdaki bilgilere sahip kişi eklenirken hata olmuş. Patient Tablosuna bilgileri ekleyiniz. <br/> Bilgiler: TcNumber:{model.TCNumber} <br/> UserId:{newUser.Id}"
        //                };
        //                await _emailSender.SendAsync(emailMessageToAdmin);
        //            }
        //            return RedirectToAction("Login", "Account");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Beklenmedik bir hata oluştu!");
        //            return View(model);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        return View();
        //    }

        //}
    }
}