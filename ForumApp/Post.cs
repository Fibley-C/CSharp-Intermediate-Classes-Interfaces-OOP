using System;

namespace ForumApp
{
    public class Post
    {
        private string Title;
        private string Description;
        private DateTime PostDate;
        private int UpVotes;
        private int DownVotes;

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
            else
                throw new InvalidOperationException("Post has not yet been created!");
        }

        public void DownVote()
        {
            if (Title != null)
            {
                DownVotes++;
            }
            else
                throw new InvalidOperationException("Post has not yet been created!");
        }
    }
}