using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmvs1.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        //public List<Post> Posts { get; set; }
        public ICollection<Post> Posts { get; set; } //base

        //public Post[] Posts { get; set; }
    }

    public class Post
    {
        public Guid Id { get; set; }

        public string Text { get; set; }

        public User User { get; set; } //optional
        public Guid UserId { get; set; } //100%


    }

    class test
    {
        void ttt()
        {
            var user1 = new User();

            var hisPosts = user1.Posts;

            foreach (var post in hisPosts)
            {
                //i++
            }
        }
    }
}