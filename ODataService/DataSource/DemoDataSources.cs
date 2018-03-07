using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ODataService.Models;

namespace ODataService.DataSource
{
    public class DemoDataSources
    {
        private static DemoDataSources instance = null;
        public static DemoDataSources Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DemoDataSources();
                }
                return instance;
            }
        }
        public List<Student> Students { get; set; }
        private DemoDataSources()
        {
            this.Reset();
            this.Initialize();
        }
        public void Reset()
        {
            this.Students = new List<Student>();
        }
        public void Initialize()
        {
            this.Students.AddRange(new List<Student>()
            {
                new Student()
                {
                    ID = 1,
                    Name = "Nasstasia Zahnetova",
                    Course = 3
                },
                new Student()
                {
                    ID = 2,
                    Name = "Yaroslav Polyakov",
                    Course = 3
                },
                new Student()
                {
                    ID = 3,
                    Name = "Yura Mihnovets",
                    Course = 2
                },
                new Student()
                {
                    ID = 4,
                    Name = "Artem Dadichenko",
                    Course = 1
                },
                new Student()
                {
                    ID = 5,
                    Name = "Vlad Khahel",
                    Course = 2
                }
            });
        }
    }
}