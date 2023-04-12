using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SpartaTodo.App.Data;
using SpartaTodo.App.Models;
using SpartaTodo.App.Models.ViewModels;
using SpartaTodo.App.Services;

namespace SpartaTodo.App.Controllers
{
    // GET: TodoItems/Details/5
    [Authorize]
    public class TodoItemsController : Controller
    {
        private readonly ITodoService _service;
        private readonly UserManager<Spartan> _userManager;
        private readonly IMapper _mapper;

        public TodoItemsController(
            ITodoService service,
            IMapper mapper,
            UserManager<Spartan> userManager)
        {
            _service = service;
            _mapper = mapper;
            _userManager = userManager;
        }

        // GET: TodoItems
        [Authorize(Roles = "Trainee, Trainer")]
        public async Task<IActionResult> Index(string? filter)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var response = await _service.GetTodoItemsAsync(currentUser, GetRole(), filter);
            if (response.Success)
            {
                return View(response.Data);
            }
            return Problem(response.Message);
        }

        private string GetRole()
        {
            return HttpContext.User.IsInRole("Trainee") ? "Trainee" : "Trainer";
        }
        // GET: TodoItems/Details/5
        [Authorize(Roles = "Trainee, Trainer")]
        public async Task<IActionResult> Details(int? id)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var response = await _service.GetDetailsAsync(id, currentUser, GetRole());
            if (response.Success)
            {
                return View(response.Data);
            }
            if (response.Message.IsNullOrEmpty()) return NotFound();
            return Problem(response.Message);
        }

        // GET: TodoItems/Create
        [Authorize(Roles = "Trainee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: TodoItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Trainee")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTodoVM createTodoVM)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                var response = await _service.CreateTodoAsync(createTodoVM, currentUser);

                if (response.Success) return RedirectToAction(nameof(Index));

                return Problem(response.Message);
            }
            return View(createTodoVM);
        }

        // GET: TodoItems/Edit/5
        [Authorize(Roles = "Trainee")]
        public async Task<IActionResult> Edit(int? id)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var response = await _service.GetDetailsAsync(id, currentUser);
            if (response.Success)
            {
                return View(response.Data);
            }
            if (response.Message.IsNullOrEmpty()) return NotFound();
            return Problem(response.Message);
        }

        // POST: TodoItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Trainee")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TodoVM todoVM)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                var response = await _service.EditTodoAsync(id, todoVM, currentUser);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                if (response.Message.IsNullOrEmpty()) return NotFound();
                return Problem(response.Message);
            }
            return View(todoVM);
        }

        [Authorize(Roles = "Trainee")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateTodoComplete(int id, MarkCompleteVM markCompleteVM)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var response = await _service.UpdateTodoCompleteAsync(id, markCompleteVM, currentUser);
            if (response.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            if (response.Message.IsNullOrEmpty()) return NotFound();
            return Problem(response.Message);
        }

        // GET: TodoItems/Delete/5
        [Authorize(Roles = "Trainee")]
        public async Task<IActionResult> Delete(int? id)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var response = await _service.GetDetailsAsync(id, currentUser);
            if (response.Success)
            {
                return View(response.Data);
            }
            return NotFound();
        }

        // POST: TodoItems/Delete/5
        [Authorize(Roles = "Trainee")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var response = await _service.DeleteTodoAsync(id, currentUser);
            if (response.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            return Problem(response.Message);
        }
    }
}
