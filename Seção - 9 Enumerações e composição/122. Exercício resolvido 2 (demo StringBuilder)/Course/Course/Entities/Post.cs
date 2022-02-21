using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities {
    internal class Post {
        public DateTime Moment { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
        public int Likes { get; set; }
    }
}
