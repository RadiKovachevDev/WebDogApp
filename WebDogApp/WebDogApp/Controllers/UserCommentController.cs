using Microsoft.AspNetCore.Mvc;
using WebDogApp.Core.Contracts;
using WebDogApp.Models.UserComment;
namespace WebDogApp.Controllers;
public class UserCommentController : Controller { private readonly IUserCommentService _service; public UserCommentController(IUserCommentService service){_service=service;} public IActionResult Index()=>View(_service.GetAll().Select(c=>new IndexVM{Id=c.Id,UserName=c.UserName,Comment=c.Comment}).ToList()); public IActionResult Create()=>View(new CreateVM()); [HttpPost][ValidateAntiForgeryToken] public IActionResult Create(CreateVM model){if(!ModelState.IsValid)return View(model); if(_service.Add(model.UserName,model.Email,model.Comment))return RedirectToAction(nameof(Index)); ModelState.AddModelError("","Коментарът не беше запазен.");return View(model);} }
