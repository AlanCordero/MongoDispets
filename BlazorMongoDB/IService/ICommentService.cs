using BlazorMongoDB.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMongoDB.IService
{
    public interface ICommentService
    {
        Task<List<Comment>> GetComments();
        Task AddComment(Comment comment);
    }
}
