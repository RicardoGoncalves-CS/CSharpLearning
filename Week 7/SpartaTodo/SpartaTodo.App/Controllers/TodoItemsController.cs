﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpartaTodo.App.Data;
using SpartaTodo.App.Models;
using SpartaTodo.App.Models.ViewModels;
using SpartaTodo.App.Services;

namespace SpartaTodo.App.Controllers
{
    public class TodoItemsController : Controller
    {
        private readonly SpartaTodoContext _context;
        // Adding automapper
        private readonly IMapper _mapper;
        private readonly ITodoService _service;

        public TodoItemsController(SpartaTodoContext context, IMapper mapper, ITodoService service)
        {
            _context = context;
            _mapper = mapper;
            _service = service;
        }

        // GET: TodoItems
        public async Task<IActionResult> Index(string? filter)
        {
            var response = await _service.GetTodoItemsAsync(filter);
            if (response.Success)
            {
                return View(response.Data);
            }
            return Problem(response.Message);
        }



        // GET: TodoItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var response = await _service.GetDetailsAsync(id);
            if (response.Success)
            {
                return View(response.Data);
            }
            return Problem(response.Message);
        }

        // GET: TodoItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TodoItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTodoViewModel createTodoVM)
        {
            if (ModelState.IsValid)
            {
                var response = await _service.CreateTodoAsync(createTodoVM);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                return Problem(response.Message);
            }
            return View(createTodoVM);
        }


        // GET: TodoItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TodoItems == null)
            {
                return NotFound();
            }

            var todo = await _context.TodoItems.FindAsync(id);

            // var todoVM = _mapper.Map<Todo>()

            if (todo == null)
            {
                return NotFound();
            }
            return View(todo);
        }

        // POST: TodoItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditTodoViewModel editTodoVM)
        {
            if (id != editTodoVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(_mapper.Map<Todo>(editTodoVM));
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoExists(editTodoVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(editTodoVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateTodoComplete(int id, MarkCompleteViewModel markCompleteVM)
        {
            if (id != markCompleteVM.Id)
            {
                return NotFound();
            }
            var todo = await _context.TodoItems.FindAsync(id);
            if (todo == null)
            {
                return NotFound();
            }
            todo.Complete = markCompleteVM.Complete;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: TodoItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TodoItems == null)
            {
                return NotFound();
            }

            var todo = await _context.TodoItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            return View(todo);
        }

        // POST: TodoItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TodoItems == null)
            {
                return Problem("Entity set 'SpartaTodoContext.TodoItems'  is null.");
            }
            var todo = await _context.TodoItems.FindAsync(id);
            if (todo != null)
            {
                _context.TodoItems.Remove(todo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TodoExists(int id)
        {
          return (_context.TodoItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
