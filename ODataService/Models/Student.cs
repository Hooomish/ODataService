using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Course { get; set; }

        //public Student(int id, string name, int course)
        //{
        //    ID = id;
        //    Name = name;
        //    Course = course;
        //}
    }
}