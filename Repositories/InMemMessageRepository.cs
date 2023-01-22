using ClickMe.Entities;

namespace ClickMe.Repositories
{
    class InMemMessageRepository
    {
        private readonly List<Message> messages = new(){
            new Message { 
                Id=Guid.NewGuid(),
                Content="this is your message",
                },
        };
        // public IEnumerable<Message> GetItems(){
        //     return messages;
        // }
        public Message? GetItem(){
            return messages.FirstOrDefault();
        }
        // public Message? GetItem(Guid id){
        //     return messages.Where(message => message.Id == id).SingleOrDefault();
        // }
    }
}