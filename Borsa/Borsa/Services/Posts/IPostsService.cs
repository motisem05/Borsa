using Borsa.ViewModels;

namespace Borsa.Services.Posts
{
    public interface IPostsService
    {
        Task<List<Entities.Posts>> Get();
        Task<Entities.Posts> Get(int id);
        Task<Entities.Posts> Insert(PostsModel Post);
        Task<Entities.Posts> Update(PostsModel Post);
        Task<Entities.Posts> Delete(int id);
        void DeleteAll();
    }
}
