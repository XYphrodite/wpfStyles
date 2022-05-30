using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_OOP11.Models
{
    internal class ToDoModel
    {
        
        private bool _isDone;
        private string _priority;
        private string _text;

        public DateTime CreationDate { get; set; } = DateTime.Now;
        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        public string Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }
    }
}
