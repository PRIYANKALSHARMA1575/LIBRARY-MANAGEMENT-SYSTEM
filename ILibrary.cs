using ProWebAPIProject.Dto;
using ProWebAPIProject.Model;

namespace ProWebAPIProject.Contracts
{
    public interface ILibrary
    {

        public Task<int> CreateBook(BookForCreateDto book);
        public Task<int> CreateLanguage(LanguageForCreateDto language);

        public Task<int> CreateMembers(MembersForCreateDto members);
        public Task<int> CreateOrder(Order_detailsForCreateDto order);



        public Task<IEnumerable<BookModel>> GetBookDetails();
        public Task<IEnumerable<Order_detailsModel>> GetOrderDetails();
        public Task<IEnumerable<Language>> GetLanguageDetails();
        public Task<IEnumerable<Members>> GetMembersDetails();

        public Task<IEnumerable<BookModel>>GetBookDetails(int isbn);




    }
}