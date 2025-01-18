using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using BlogTest3.Areas.Identity.Data;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Shared;
using Microsoft.Extensions.Identity.Core;

namespace BlogTest3.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string? BlogContent { get; set; }
        public string UserId { get; set; }
        public BlogTest3User User { get; set; } // Navigation property
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
