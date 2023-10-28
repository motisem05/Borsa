using Borsa.Entities;
using Borsa.Services.Posts;
using Microsoft.AspNetCore.Mvc;

namespace Borsa.Controllers
{
        [Route("Api/[Controller]")]
        [ApiController]
    public class PostsController : Controller
    {
        public class PostsControlle : ControllerBase
        {
            private readonly IPostsService _postsService;
            public PostsControlle(IPostsService postsService)
            {
                 _postsService = postsService;
            }
            [HttpGet("{id}")]
            public async Task<ActionResult<Posts>> GetPosts(int id)
            { 
                var post = await _postsService.Get(id);
                if (post == null)
                { return NotFound(); }
                return Ok(post);
            }
        }

    }
}
