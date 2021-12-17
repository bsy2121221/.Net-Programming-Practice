using ApiWithEFDemo.Data;
using ApiWithEFDemo.Model;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWithEFDemo.Repository
{
    public class BookRepository:IBookRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public BookRepository(BookStoreContext context,IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BookModel>> GetAllBookAsync()
        {
            //Without using automapper

            ////var records = await _context.tb_Book.Select(x => new BookModel()
            ////{
            ////    ID=x.ID,
            ////    Title=x.Title,
            ////    Description=x.Description
            ////}).ToListAsync();
            //return records;

            //With using automapper
            var records = await _context.tb_Book.ToArrayAsync();
            return _mapper.Map<List<BookModel>>(records);
        }

        public async Task<BookModel> GetBookByIdAsync(int bookid)
        {
            //Binding data without using automapper
            //var book = await _context.tb_Book.Where(x => x.ID == bookid).Select(x => new BookModel()
            //{
            //    ID=x.ID,
            //    Title=x.Title,
            //    Description=x.Description
            //}).FirstOrDefaultAsync();
            //return book;

            //Binding data by using of automapper
            var book = await _context.tb_Book.FindAsync(bookid);
            return _mapper.Map<BookModel>(book);
        }
        public async Task<int> AddBooksAsync(BookModel bookModel)
        {
            var book = new Books()
            {
                Title = bookModel.Title,
                Description = bookModel.Description
            };
            _context.tb_Book.Add(book);
            await _context.SaveChangesAsync();
            return book.ID;
        }
        public async Task UpdateBookAsync(int id, BookModel bookModel)
        {

            //in this scenerio we are htting database two time
            //so we are wasting unnecessory time
            //var book =await  _context.tb_Book.FindAsync(id);
            //if (book != null)
            //{
            //    book.Title = bookModel.Title;
            //    book.Description = bookModel.Description;
            //   await _context.SaveChangesAsync();

            //}

            //another process 
            //In this proecess we will make new book object and than we can assign this object to context 
            var book = new Books()
            {
                ID = id,
                Title = bookModel.Title,
                Description = bookModel.Description
            };
            _context.tb_Book.Update(book);
            await _context.SaveChangesAsync();
        }



        //for patch request you need to intall two nuget package
        //1. JasonPtch
        //2.NewtonsoftJson
        public async Task PatchBookAsync(int id, JsonPatchDocument bookModel)
        {
            var book = await _context.tb_Book.FindAsync(id);
            if (book != null)
            {
                bookModel.ApplyTo(book);
                await _context.SaveChangesAsync();
            }
        }

        //Method to delete the data from the databse based upon the primary key
        //or any other whatever you want
        public async Task DeleteDataAsync(int bookId)
        {
            //delete data based upon the selected column
            //var book = _context.tb_Book.Select(x => x.Title == "");

            //IF you have primary key than you don't need to hit database two time 
            var book = new Books()
            {
                ID = bookId
            };
            _context.tb_Book.Remove(book);
            await _context.SaveChangesAsync();
        }


    }
}
