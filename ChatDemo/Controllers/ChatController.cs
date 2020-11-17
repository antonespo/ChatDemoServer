using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ChatDemo.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class ChatController : ControllerBase{
        private readonly DataContext _context;

        public ChatController (DataContext context) {
            this._context = context;
        }

        [HttpGet("all")]
        public List<Message> Get(){
            return _context.Messages.ToList(); 
        }

        [HttpPost("new")]
        public bool Post (Message message){
            message.CreatedAt = DateTime.Now; 
            _context.Messages.Add(message);
            var success = _context.SaveChanges() > 0; 
            return success; 
        }
    }
}