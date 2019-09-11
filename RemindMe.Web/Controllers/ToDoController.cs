using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemindMe.EF.Models;
using RemindMe.EF.Repositories;

namespace RemindMe.Web.Controllers
{
    public class ToDoController : Controller
    {
        public ToDoController(IRepository<ToDo> repository) => ToDoRepo = repository;        

        private IRepository<ToDo> ToDoRepo { get; }

        // GET: ToDo
        public ActionResult Index()
        {
            return View(ToDoRepo.Get());
        }

        // GET: ToDo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]ToDo toDo)
        {
            try
            {
                ToDoRepo.Create(toDo);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDo/Edit/5
        public ActionResult Edit(int id)
        {
            return View(ToDoRepo.Get(id));
        }

        // POST: ToDo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm]ToDo toDo)
        {
            try
            {
                ToDoRepo.Update(toDo);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: ToDo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                ToDoRepo.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}