using System;
using System.Collections.Generic;

namespace TodoApi.Controllers
{
    public class Message
    {
        public string id { get; set;}
        public IDictionary<string, string> parameters { get; } 

        public Message(string id, string key, string param)
        {
            this.id = id;
            this.parameters = new Dictionary<string, string>();
            this.parameters.Add(key, param);
        }
    }
}
