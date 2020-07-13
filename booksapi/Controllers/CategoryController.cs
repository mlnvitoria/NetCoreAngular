using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using booksapi.Models;
using booksapi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace booksapi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
     
        public CategoryService Service { get; set; }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get ([FromServices] BooksApiContext booksApiContext)
        {
            try
            {
                Service = new CategoryService(booksApiContext);

                return await Service.GetCategoriesAsync();
            }
            catch (Exception e)
            {
                return BadRequest(new { status = "error", message = e.Message });
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Post([FromServices] BooksApiContext booksApiContext, [FromBody] Category category)
        {
            try
            {
                Service = new CategoryService(booksApiContext);

                if (ModelState.IsValid)
                {
                    return await Service.PostAsync(category);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch(Exception e)
            {
                return BadRequest(new { status = "error", message = e.Message, detail = e.InnerException.Message });
            }
           
        }

    }
}
