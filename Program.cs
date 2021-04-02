using System;

namespace RectPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect()
            {
                x = 4,
                y = 8,
                Width = 2,
                Height = 5,
            };
   
            Post post = new Post()
            {
                author = "Domadanar",
                text = "This is my first post",
                likes = 4,
            };

            post.getLikesNumber();
            post.like();
            int likes = post.getLikesNumber();
            Console.WriteLine(likes);

            post.leaveComment("first comment");
            post.getComments();
            post.leaveComment("second comment");
            post.getComments();
        }
    }
    class Rect
    {
        public int x;
        public int y;
        public int Width;
        public int Height;

        public int getArea()
        {
            int area = Width * Height;
            return area;
        }

        public int getPerimeter()
        {
            int perimeter = 2 * (Width + Height);
            return perimeter;
        }
        public void Move(int step)
        {
            x = x + step;
            y = y + step;
        }


    }
    class Post
    {
        public string author;
        public string text;
        public int likes;
        public string[] comments;

        public void like()
        {
            likes += 1;
        }

        public void getLikesNumber()
        {
            return likes;
        }

        public void leaveComment(string comment)
        {
            if (comments == null)
            {
                comments = new string[1];
            }
            else
            {
                Array.Resize(ref comments, comments.Length + 1);
            }
            comments[comments.Length - 1] = comment;
        }

        public void getComments()
        {
            return comments;
        }


    }
}
