using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace postText
{
	class Program
	{
		static void Main(string[] args)
		{
			string postText = Console.ReadLine();

            		Post post = new Post();
            		post.Text = postText;
            		post.showPost();
		}

        	class Post
        	{
            		private string text;

            		public Post()
            		{
                		Console.WriteLine("New post");
            		}

            		public void showPost()
            		{
                		Console.WriteLine(text);
            		}

            		public string Text
            		{
                		get {return text; }
                		set {text = value; }
            		}
        	}
	}
}
