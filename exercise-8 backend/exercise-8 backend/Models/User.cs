﻿namespace exercise_8_backend.Models
{
    public class User
    {
        public string UserName { get; set; } = String.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string RefreshToken { get; set; }
        public DateTime TokenCreatedAt { get; set; }
        public DateTime TokenExpiresAt { get; set; }
    }
}
