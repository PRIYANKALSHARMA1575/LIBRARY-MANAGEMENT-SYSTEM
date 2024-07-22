
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;

using ProWebAPIProject.Contracts;

using ProWebAPIProject.Dto;
using ProWebAPIProject.Contracts;

namespace ProWebAPIProject.Controller

{

    [Route("api/[controller]")]

    [ApiController]

    public class LibraryController : ControllerBase

    {

        private readonly ILibrary _library;

        public LibraryController(ILibrary library)

        {

            _library = library;

        }

        [HttpPost("Book")]

        public async Task<IActionResult> CreateBook(BookForCreateDto book)

        {

            try

            {

                var Book = await _library.CreateBook(book);

                return Ok(Book);

            }

            catch (Exception ex)

            {

                return StatusCode(500, ex.Message);

            }

        }

        [HttpPost("Language")]

        public async Task<IActionResult> CreateLanguage(LanguageForCreateDto language)

        {

            try

            {

                var Language = await _library.CreateLanguage(language);

                return Ok(Language);

            }

            catch (Exception ex)

            {

                return StatusCode(500, ex.Message);

            }

        }

        [HttpPost("Members")]

        public async Task<IActionResult> CreateMembers(MembersForCreateDto members)

        {

            try

            {

                var Members = await _library.CreateMembers(members);

                return Ok(Members);

            }

            catch (Exception ex)

            {

                return StatusCode(500, ex.Message);

            }

        }

        [HttpPost("Order")]

        public async Task<IActionResult> CreateOrder(Order_detailsForCreateDto order)

        {

            try

            {

                var Order = await _library.CreateOrder(order);

                return Ok(Order);

            }

            catch (Exception ex)

            {

                return StatusCode(500, ex.Message);

            }

        }
        [HttpGet]
        public async Task<IActionResult> GetBookDetails()
        {
            try
            {
                var book = await _library.GetBookDetails();
                return Ok(book);
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }
        [HttpGet]
        public async Task<IActionResult> GetLanguageDetails()
        {
            try
            {
                var language = await _library.GetLanguageDetails();
                return Ok(language);
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

        [HttpGet]
        public async Task<IActionResult> GetMembersDetails()
        {
            try
            {
                var members = await _library.GetMembersDetails();
                return Ok(members);
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderDetails()
        {
            try
            {
                var order = await _library.GetOrderDetails();
                return Ok(order);
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }
        /// <returns></returns>
        [HttpGet("book data-deletion")]
        public async Task<IActionResult> GetBookCustomer(int isbn)
        {
            try
            {
                await _library.GetBookDetails(isbn);
                return Ok("ROW DELETED");
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

    }

}
