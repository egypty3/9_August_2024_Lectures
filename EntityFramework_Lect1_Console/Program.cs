using EntityFramework_Lect1_Console.Data;
using EntityFramework_Lect1_Console.Models;

namespace EntityFramework_Lect1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BloggingContext context = new BloggingContext();

            // Create

            //Console.WriteLine("Inserting a new blog");

            //Blog blog = new Blog { Url = "http://kiablog.com" };

            //context.Blogs.Add(blog);

            //context.SaveChanges();

            //Read

            Console.WriteLine("Querying for a blog");
            Blog blog = context.Blogs.FirstOrDefault();

            Console.WriteLine($"Blog: {blog.BlogId} {blog.Url}");


            // Update
            Console.WriteLine("Updating the blog and adding a post");
            blog.Url = "http://mykiaPicanantoblog.com";
            blog.Posts.Add(new Post { Title = "My first post", Content = "Hello World!" });
            context.SaveChanges();


            //Read

            Console.WriteLine("Querying for a blog");
            blog = context.Blogs.FirstOrDefault();

            Console.WriteLine($"Blog: {blog.BlogId} {blog.Url}");


            // Delete
            Console.WriteLine("Delete the blog");
            context.Blogs.Remove(blog);
            context.SaveChanges();
        }
    }
}
