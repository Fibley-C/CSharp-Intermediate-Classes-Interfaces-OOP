using System;

namespace ForumApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var post = new Post();
            var choice = 0;

            do
            {
                Console.WriteLine("1 - Create a new post\n2 - Read last post\n3 - Upvote post\n4 - Downvote post\n0 - End");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
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
