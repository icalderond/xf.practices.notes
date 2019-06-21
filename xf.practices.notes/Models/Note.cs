using System;
using System.Collections.Generic;
using System.Text;

namespace xf.practices.notes.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateModified { get; set; }
    }
}