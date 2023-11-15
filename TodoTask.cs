using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class TodoTask
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Deadline { get; set; }

        public bool IsCompleted { get; set; }

        private readonly List<string> tags = new List<string>();

        public IEnumerable<string> Tags
        {
            get // метод (св-во) позволяет считывать данные
            {
                return (IEnumerable<string>)tags;
            }
        }

        public void AddTag(string tag)
        {
            tags.Add(tag);
        }
        
        public void RemoveTag(string tag)
        {
            if (HasTag(tag))
                tags.Remove(tag);
        }

        public bool HasTag(string tag)
        {
            return Tags.Contains(tag);
        }
    }
}
