using System.Collections.Generic;
using System;

namespace Registrar.Models
{
  public class Student 
  {
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public int CourseId { get; set; }
    public Course Course {get; set; }
  }
}