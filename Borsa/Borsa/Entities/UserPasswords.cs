﻿namespace Borsa.Entities
{
    public class UserPasswords
    {
        public UserPasswords()
        {
            this.UserId = null;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Site { get; set; }
        public string Category { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UserId { get; set; }
    }
}
