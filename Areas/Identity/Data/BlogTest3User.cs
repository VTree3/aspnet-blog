using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using BlogTest3.Models;

namespace BlogTest3.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BlogTest3User class
public class BlogTest3User : IdentityUser
{
    public ICollection<Blog> Blogs { get; set; } = new List<Blog>();
}

