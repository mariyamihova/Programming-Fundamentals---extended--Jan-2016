

namespace _04.Social_Media_Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split();
            var post = new Dictionary<string, List<int>>();
            var comment = new Dictionary<string, Dictionary<string, List<string>>>();
            while (inputLine[0] != "drop")
            {

                var name = inputLine[1];
                if (inputLine[0] == "post")
                {


                    if (!post.ContainsKey(name))
                    {
                        post[name] = new List<int>();
                    }
                    post[name].Add(0);
                    post[name].Add(0);

                }
                else if (inputLine[0] == "like")
                {

                    post[name][0]++;
                }
                else if (inputLine[0] == "dislike")
                {
                    post[name][1]++;
                }
                else if (inputLine[0] == "comment")
                {
                    var nameCommentator = inputLine[2];

                    if (!comment.ContainsKey(name))
                    {
                        comment[name] = new Dictionary<string, List<string>>();
                    }
                    var commentLeft = inputLine;
                    for (int i = 3; i < commentLeft.Length; i++)
                    {
                        if (!comment[name].ContainsKey(nameCommentator))
                        {
                            comment[name][nameCommentator] = new List<string>();
                        }
                        comment[name][nameCommentator].Add(commentLeft[i]);
                    }


                    //comment[name][nameCommentator] = commentLeft;



                }
                inputLine = Console.ReadLine().Split();
            }
            foreach (var pair in post)
            {
                var name = pair.Key;
                var values = pair.Value;
                Console.WriteLine($"Post: {name} | Likes: {pair.Value[0]} | Dislikes: {pair.Value[1]}");
                if (comment.ContainsKey(name))
                {
                    Console.WriteLine("Comments:");
                    var nameAndComment = comment[name];
                    foreach (var secondPair in nameAndComment.Keys)
                    {
                        Console.WriteLine($"*  {secondPair}: {string.Join(" ", nameAndComment[secondPair])}");
                    }

                }
                else
                {
                    Console.WriteLine("Comments:");
                    Console.WriteLine($"None");
                }
            }
        }
    }
}
