using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoftServe_IT_Academy.Project.Models
{
    public class User
    {
        public User()
        {
            News = new HashSet<NewsAuthor>();
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Pseudonym { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public byte[] ProfilePicture { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public virtual ICollection<NewsAuthor> News { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
