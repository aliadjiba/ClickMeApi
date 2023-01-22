using Microsoft.AspNetCore.Mvc;
using ClickMe.Repositories;
using ClickMe.Entities;
namespace ClickMe.Controllers{
    // GET /items
    [ApiController]
    [Route("message")]
    public class MessagesController : ControllerBase {
        private readonly InMemMessageRepository repository;
        public MessagesController(){
            repository = new InMemMessageRepository();
        }
        [HttpGet]
        public Message? GetItem(){
            var message = repository.GetItem(); 
            return message;
        }
        // public IEnumerable<Message> GetItems(){
        //     var messages = repository.GetItems(); 
        //     return messages;
        // }
    }
}