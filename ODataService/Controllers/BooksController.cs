using ODataService.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.OData;

namespace ODataService.Controllers
{
    [EnableQuery]
    public class BooksController : ODataController
    {
        public IHttpActionResult Get()
        {
            return Ok(DemoDataSources.Instance.Books.AsQueryable());
        }

    }
}