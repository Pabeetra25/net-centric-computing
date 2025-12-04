using ASPNETCRUD.Data;
using ASPNETCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCRUD.Controllers
{
    public class StudentsController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;

        public StudentsController(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
           var students=await mvcDemoDbContext.Students.ToListAsync();
            return View(students);
        }



        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel addStudentRequest)
        {
            var student = new Student()
            {
                Id = Guid.NewGuid(),
                Name = addStudentRequest.Name,
                
                Email = addStudentRequest.Email,
                Address = addStudentRequest.Address
            };
             await mvcDemoDbContext.Students.AddAsync(student);
           await mvcDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> View(Guid id) 
        {
           var student =await mvcDemoDbContext.Students.FirstOrDefaultAsync(x=>x.Id == id);
            if (student != null) {
                var viewModel = new UpdateStudentViewModel()
                {

                    Id = student.Id,
                    Name = student.Name,

                    Email = student.Email,
                    Address = student.Address

                };
                return await Task.Run(()=>View("View",viewModel));
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> View(UpdateStudentViewModel model)
        {
            var student=await mvcDemoDbContext.Students.FindAsync(model.Id);
            if (student != null)
            {
                student.Name = model.Name;
                student.Email = model.Email;
                student.Address = model.Address;

              await  mvcDemoDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

            
        }
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateStudentViewModel model)
        {
            var student =await mvcDemoDbContext.Students.FindAsync(model.Id);
            if (student != null)
            {
                mvcDemoDbContext.Students.Remove(student);
                await mvcDemoDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
