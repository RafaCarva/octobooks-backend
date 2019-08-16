using Dapper.Contrib.Extensions;
using Octobooks.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Domain.Models
{
    [Table("Book")]
    public class Book : Entity
    {
        [Key]
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public bool IsLock { get; set; }
        public bool Isborrowed { get; set; }
    }
}
