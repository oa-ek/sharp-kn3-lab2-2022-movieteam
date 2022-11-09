﻿using Microsoft.AspNetCore.Identity;
namespace MoviesCore

{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual ICollection<Bookmark>? Bookmarks { get; set; } = new List<Bookmark>();
    }
}