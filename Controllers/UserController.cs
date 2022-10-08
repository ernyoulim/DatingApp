using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers

{   [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {   
        public DataContext DataContext { get; }

        public UsersController(DataContext dataContext){
            DataContext = dataContext;

        }

        [HttpGet()]
        public ActionResult<IEnumerable<AppUser>> GetUsers() {
           return  DataContext.Users.ToArray<AppUser>();
        }

         [HttpGet("{id}")]
        public async Task<AppUser> GetUsersById(int id) {
           return await DataContext.Users.FindAsync(id);
        }
        
        [HttpGet("hello")]
         public ActionResult Index()
        {
            return Content("Hello World!");
        }

    
        
    }
    
}
