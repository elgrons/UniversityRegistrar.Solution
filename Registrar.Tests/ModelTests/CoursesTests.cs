using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registrar.Models;
using System.Collections.Generic; 
using System;

namespace Registrar.Tests
{
  [TestClass]
  public class CourseTests
  {
  [TestMethod]
    public void CourseConstructor_CreatesInstanceOfCourse_Course()
    {
      // Arrange
      Course newCourse = new Course;
      // Act
      //not needed here
      // Assert
    Assert.AreEqual(typeof(Course), newCourse.GetType());
    }
  }
}