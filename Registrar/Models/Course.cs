using System.Collections.Generic;
using System;

namespace Registrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }

    public string CourseName {get; set; }

    public string CourseNumber { get; set; }

    public int StudentId { get; set; }
    
    public List<CourseStudent> JoinEntities { get; set; }

  }
}