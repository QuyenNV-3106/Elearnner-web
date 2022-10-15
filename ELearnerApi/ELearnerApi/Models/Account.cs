using System;
using System.Collections.Generic;

#nullable disable

namespace ELearnerApi.Models
{
    public partial class Account
    {
        public Account()
        {
            Vocabularies = new HashSet<Vocabulary>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string Address { get; set; }
        public int? TopicId { get; set; }
        public string Role { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual ICollection<Vocabulary> Vocabularies { get; set; }
    }
}
