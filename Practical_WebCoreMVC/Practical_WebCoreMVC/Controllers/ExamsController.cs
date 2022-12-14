using Microsoft.AspNetCore.Mvc;
using Practical_WebCoreMVC.Models;
using Practical_WebCoreMVC.Models.Domain;
using Practical_WebCoreMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace Practical_WebCoreMVC.Controllers
{
    public class ExamsController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public ExamsController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var exams = await mvcDbContext.Exams.ToListAsync();
            return View(exams);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddExamViewModel addExamRequest)
        {
            var exam = new Exam()
            {
                Id = Guid.NewGuid(),
                Subject = addExamRequest.Subject,
                StartTime = addExamRequest.StartTime,
                ExamDate = addExamRequest.ExamDate,
                ExamDuration = addExamRequest.ExamDuration,
                Classroom = addExamRequest.Classroom,
                Faculty = addExamRequest.Faculty,
                Status = addExamRequest.Status,
            };

            await mvcDbContext.Exams.AddAsync(exam);
            await mvcDbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
