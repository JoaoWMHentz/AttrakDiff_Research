using AttrakDiffResearch.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttrakDiffResearch.Domain.Entities.Access
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public UserRule Rule { get; set; }

        public Company Company { get; set; }
    }
}
