﻿namespace CustomHttpServer.Models
{
    using System.Collections.Generic;

    public class HttpSession
    {
        private readonly IDictionary<string, string> parameters;

        public HttpSession(string id)
        {
            this.Id = id;
            this.parameters = new Dictionary<string, string>();
        }

        public string Id { get; set; }

        public string this[string key] => this.parameters[key];

        public void Clear()
        {
            this.parameters.Clear();
        }

        public void Add(string key, string value)
        {
            this.parameters.Add(key, value);
        }
    }
}
