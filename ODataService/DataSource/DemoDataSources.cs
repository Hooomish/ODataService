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
        public List<Book> Books { get; set; }
        private DemoDataSources()
        {
            this.Reset();
            this.Initialize();
        }
        public void Reset()
        {
            this.Students = new List<Student>();
            this.Books = new List<Book>();
        }
        public void Initialize()
        {
            this.Books.AddRange(new List<Book>()
            {
                new Book()
                {
                    ID = "0",
                    Name = "Outsider",
                    Year = 2000
                },
                new Book()
                {
                    ID = "1",
                    Name = "Woman in white",
                    Year = 1995
                },
                new Book()
                {
                    ID = "2",
                    Name = "Green mile",
                    Year = 1999
                }
            });
            this.Students.AddRange(new List<Student>()
            {
                new Student()
                {
                    ID = 1,
                    Name = "Nasstasia Zahnetova",
                    Course = 3,
                    Books = new List<Book>{Books[0]}
                },
                new Student()
                {
                    ID = 2,
                    Name = "Yaroslav Polyakov",
                    Course = 3,
                    Books = new List<Book>{Books[1], Books[0]}
                },
                new Student()
                {
                    ID = 3,
                    Name = "Yura Mihnovets",
                    Course = 2,
                    Books = new List<Book>{Books[2]}
                },
                new Student()
                {
                    ID = 4,
                    Name = "Artem Dadichenko",
                    Course = 1,
                    Books = new List<Book>{Books[0], Books[1], Books[2]}
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