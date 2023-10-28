using Borsa.Entities;
using Borsa.Services.Posts;
using Microsoft.AspNetCore.Mvc;

namespace Borsa.Controllers
{
        [Route("Api/posts")]
        [ApiController]
    public class PostsController : ControllerBase
    {
      
            private readonly IPostsService _postsService;
            public PostsController(IPostsService postsService)
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
