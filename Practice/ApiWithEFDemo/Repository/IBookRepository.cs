using ApiWithEFDemo.Model;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiWithEFDemo.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBookAsync();
        Task<BookModel> GetBookByIdAsync(int id);
        Task<int> AddBooksAsync(BookModel bookModel);
        Task UpdateBookAsync(int id, BookModel bookModel);
        Task PatchBookAsync(int id, JsonPatchDocument bookModel);
        Task DeleteDataAsync(int bookId);
    }
}
