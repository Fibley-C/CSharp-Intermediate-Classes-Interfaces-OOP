using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp
{
    public class Post
    {
        string Title;
        string Description;
        DateTime PostDate;
        int UpVotes;
        int DownVotes;

        public void NewPost()
        {
            UpVotes = 0;
            DownVotes = 0;

            Console.WriteLine("Please enter a title: ");
            Title = Console.ReadLine();

            Console.WriteLine("Please enter your description: ");
            Description = Console.ReadLine();

            PostDate = DateTime.Now;
        }

        public void ReadPost()
        {
            if (Title != null)
            {
                Console.WriteLine("Title: {0}", Title);
                Console.WriteLine("Description: {0}", Description);
                Console.WriteLine("Date Posted: {0}", PostDate);
                Console.WriteLine("Upvotes: {0}", UpVotes);
                Console.WriteLine("Downvotes: {0}", DownVotes);

            }
            else
            throw new InvalidOperationException("Post has not yet been created!");
        }

        public void UpVote()
        {
            if (Title != null)
            {
                UpVotes++;
            }
            throw new InvalidOperationException("Post has not yet been created!");
        }

        public void DownVote()
        {
            if (Title != null)
            {
                DownVotes++;
            }
            throw new InvalidOperationException("Post has not yet been created!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            var choice = 0;

            do
            {
                Console.WriteLine("1 - Create a new post\n2 - Read last post\n3 - Upvote post\n4 - Downvote post\n0 - End");
                choice = Convert.ToInt32(Console.ReadLine());
                
                switch(choice)
                {
                    case 1:
                        post.NewPost();
                        break;
                    case 2:
                        post.ReadPost();
                        break;
                    case 3:
                        post.UpVote();
                        break;
                    case 4:
                        post.DownVote();
                        break;
                }
            } while (choice != 0);
        }
    }
}
