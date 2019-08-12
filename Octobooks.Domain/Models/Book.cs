using Octobooks.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Domain.Models
{
    public class Book : Entity
    {
        public string author { get; set; }
        public string title { get; set; }
        public string ISBN { get; set; }
        public bool isLock { get; set; }
        public bool isBorrowed { get; set; }
    }
}
