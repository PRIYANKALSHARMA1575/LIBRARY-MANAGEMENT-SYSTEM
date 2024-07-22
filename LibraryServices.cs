using Dapper;
using Microsoft.AspNetCore.Mvc;
using ProWebAPI.Model;
using ProWebAPIAroject.Context;
using ProWebAPIProject.Contracts;
using ProWebAPIProject.Dto;
using ProWebAPIProject.Model;

namespace ProWebAPIProject.Repository
{
    public class LibraryServices : ILibrary
    {
        private readonly LibraryContext _Context;
        public LibraryServices(LibraryContext context)
        {
            _Context = context;
        }
        public async Task<int> CreateBook(BookForCreateDto book)
        {
            var query = "insert Book (genre,book_title,author,year_published,created_on,created_by,modified_on,modified_by,is_available,language_id) values (@genre,@book_title,@author,@year_published,@created_on,@created_by,@modified_on,@modified_by,@is_available,@language_id)";
            var parameter = new DynamicParameters();
            parameter.Add("genre", book.genre, System.Data.DbType.String);
            parameter.Add("book_title", book.book_title, System.Data.DbType.String);
            parameter.Add("author", book.author, System.Data.DbType.String);
            parameter.Add("year_published", book.year_published, System.Data.DbType.Date);
            parameter.Add("created_on", book.created_on, System.Data.DbType.DateTime);
            parameter.Add("created_by", book.created_by, System.Data.DbType.String);
            parameter.Add("modified_on", book.modified_on, System.Data.DbType.DateTime);
            parameter.Add("modified_by", book.modified_by, System.Data.DbType.String);
            parameter.Add("is_available", book.is_available, System.Data.DbType.Boolean);
            parameter.Add("language_id", book.language_id, System.Data.DbType.Int32);

            using (var connection = _Context.dbConnection())
            {
                var Book = await connection.ExecuteAsync(query, parameter);
                return Book;
            }
        }
        public async Task<int> CreateLanguage(LanguageForCreateDto language)
        {
            var query = "insert Language (language,description,created_on,created_by,modified_on,modified_by) values (@language,@description,@created_on,@created_by,@modified_on,@modified_by)";
            var parameter = new DynamicParameters();
            parameter.Add("language", language.language, System.Data.DbType.String);
            parameter.Add("description", language.description, System.Data.DbType.String);
            parameter.Add("created_on", language.created_on, System.Data.DbType.DateTime);
            parameter.Add("created_by", language.created_by, System.Data.DbType.String);
            parameter.Add("modified_on", language.modified_on, System.Data.DbType.DateTime);
            parameter.Add("modified_by", language.modified_by, System.Data.DbType.String);

            using (var connection = _Context.dbConnection())
            {
                var Language = await connection.ExecuteAsync(query, parameter);
                return Language;
            }

        }
        public async Task<int> CreateMembers(MembersForCreateDto members)
        {
            var query = "insert Members (address,email,contact_no,created_on,created_by,modified_on,modified_by,is_available) values (@address,@email,@contact_no,@created_on,@created_by,@modified_on,@modified_by,@is_available)";
            var parameter = new DynamicParameters();
            parameter.Add("address", members.address, System.Data.DbType.String);
            parameter.Add("email", members.email, System.Data.DbType.String);
            parameter.Add("contact_no", members.contact_no, System.Data.DbType.String);
            parameter.Add("created_on", members.created_on, System.Data.DbType.DateTime);
            parameter.Add("created_by", members.created_by, System.Data.DbType.String);
            parameter.Add("modified_on", members.modified_on, System.Data.DbType.DateTime);
            parameter.Add("modified_by", members.modified_by, System.Data.DbType.String);
            parameter.Add("is_available", members.is_available, System.Data.DbType.Boolean);

            using (var connection = _Context.dbConnection())
            {
                var Members = await connection.ExecuteAsync(query, parameter);
                return Members;
            }

        }
        public async Task<int> CreateOrder(Order_detailsForCreateDto order)
        {
            var query = "insert Order_details (book_id,member_id,purchase_date,due_date,created_on,created_by,modified_on,modified_by,is_active) values (@book_id,@member_id,@purchase_date,@due_date,@created_on,@created_by,@modified_on,@modified_by,@is_active)";
            var parameter = new DynamicParameters();
            parameter.Add("book_id", order.book_id, System.Data.DbType.Int32);
            parameter.Add("member_id", order.member_id, System.Data.DbType.Int32);
            parameter.Add("purchase_date", order.purchase_date, System.Data.DbType.DateTime);
            parameter.Add("due_date", order.due_date, System.Data.DbType.DateTime);
            parameter.Add("created_on", order.created_on, System.Data.DbType.DateTime);
            parameter.Add("created_by", order.created_by, System.Data.DbType.String);
            parameter.Add("modified_on", order.modified_on, System.Data.DbType.DateTime);
            parameter.Add("modified_by", order.modified_by, System.Data.DbType.String);
            parameter.Add("is_active", order.is_active, System.Data.DbType.Boolean);

            using (var connection = _Context.dbConnection())
            {
                var Order = await connection.ExecuteAsync(query, parameter);
                return Order;
            }

        }

        public async Task<IEnumerable<BookModel>> GetBookDetails()
        {
            var query = "Select * from Book";
            using (var connection = _Context.dbConnection())
            {
                var product = await connection.QueryAsync<BookModel>(query);
                return product;
            }

        }

        public async Task<IEnumerable<Order_detailsModel>> GetOrderDetails()
        {
            var query = "Select * from Book";
            using (var connection = _Context.dbConnection())
            {
                var product = await connection.QueryAsync<BookModel>(query);
                return product;
            }

        }
        public async Task<IEnumerable<Language>>GetLanguageDetails()
        {
            var query = "Select * from Language";
            using (var connection = _Context.dbConnection())
            {
                var product = await connection.QueryAsync<Language>(query);
                return product;
            }

        }
        public async Task<IEnumerable<Members>> GetMembersDetails()
        {
            var query = "Select * from Members";
            using (var connection = _Context.dbConnection())
            {
                var product = await connection.QueryAsync<Members>(query);
                return product;
            }

        }
        public async Task<IEnumerable<BookModel>> GetBookDetails(int isbn)
        {
            var query = "DELETE FROM Book WHERE id = @isbn;";

            using (var connection = _Context.dbConnection())
            {
                var customer = await connection.QueryAsync<BookModel>(query, new { isbn });
                return customer;
            }

        }
       
    }
}
