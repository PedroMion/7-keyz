using Microsoft.AspNetCore.Mvc;

namespace _7keyz.Services.Interfaces {
    public interface IChatsService {
        public Task<Chats?> GetChatByIdAsync(int id);
    }
}