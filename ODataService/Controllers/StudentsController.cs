using ODataService.DataSource;
using ODataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData;

namespace ODataService.Controllers
{
    [EnableQuery]
    public class StudentsController : ODataController
    {
        //private List<Student> students = new List<Student>()
        //{
        //new Student()
        //{
        //    ID = 1,
        //    Name = "Nasstasia Zahnetova",
        //    Course = 3
        //}, 
        //new Student()
        //{
        //    ID = 2,
        //    Name = "Yaroslav Polyakov",
        //    Course = 3
        //},
        //new Student()
        //{
        //    ID = 3,
        //    Name = "Yura Mihnovets",
        //    Course = 2
        //},
        //new Student()
        //{
        //    ID = 4,
        //    Name = "Artem Dadichenko",
        //    Course = 1
        //},
        //new Student()
        //{
        //    ID = 5,
        //    Name = "Vlad Khahel",
        //    Course = 2
        //}
        //};

        //public List<Student> Get()
        //{
        //    return students;
        //}

        public IHttpActionResult Get()
        {
            return Ok(DemoDataSources.Instance.Students.AsQueryable());
        }

    }
}