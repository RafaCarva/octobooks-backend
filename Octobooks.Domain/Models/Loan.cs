using Octobooks.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Domain.Models
{
    public class Loan : Entity
    {
        public int idClient { get; set; }
        public int idBook { get; set; }
        public string clientFeedback { get; set; }
        public DateTime loanDate { get; set; }
    }
}
