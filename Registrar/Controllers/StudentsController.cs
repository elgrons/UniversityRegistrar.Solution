using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Registrar.Controllers
{
  public class StudentsController : Controller
  {
    private readonly RegistrarContext _db;

    public StudentsController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Student> model = _db.Students
                                .Include(student => student.Course)
                                .ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      Student thisStudent = _db.Students
                          .Include(student => student.Course)
                          .FirstOrDefault(student => student.StudentId == id);
      return View(thisStudent);
    }

    public ActionResult Create()
    {
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddCourse(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      ViewBag.CourseId = new SelectList(_db.Students, "CourseId", "StudentName");
      return View(thisStudent);
    }

    public ActionResult Edit(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult Edit(Student student)
    {
      _db.Students.Update(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

        // [HttpPost]
    // public ActionResult AddCourse(Student student, int courseId)
    // {
    //   #nullable enable
    //   CourseStudent? joinEntity = _db.CourseStudents.FirstOrDefault(join => (join.CourseId == courseId && join.StudentId == student.StudentId));
    //   #nullable disable
    //   if (joinEntity == null && courseId != 0)
    //   {
    //     _db.CourseStudents.Add(new CourseStudent() { CourseId = courseId, StudentId = student.StudentId });
    //     _db.SaveChanges();
    //   }
    //   return RedirectToAction("Details", new { id = student.StudentId });
    // }

  }
}
