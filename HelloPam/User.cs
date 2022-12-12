﻿namespace HelloPam
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public int Profile { get; set; }
        public bool Status { get; set; }
        public byte[] Picture { get; set; }
        public DateTime CreatedAt { get; set; }

        public User(int id, string username, string password,string fullname, int profile, bool status, byte[] picture, DateTime createdAt)
        {
            Id = id;
            Username = username;
            Password = password;
            Fullname = fullname;
            Profile = profile;
            Status = status;
            Picture = picture;
            CreatedAt = createdAt;
        }
        public override bool Equals(object obj)
        {
            return obj is User user && Id==user.Id;
        }

    }
}