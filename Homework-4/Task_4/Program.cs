namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string longString = "In the midst of the digital age, blogging has emerged as a dynamic platform for individuals and organizations to share their thoughts, experiences, and expertise. The art of blogging involves not only writing compelling content but also engaging with an audience that spans the globe. With a plethora of topics ranging from technology to lifestyle, blogs provide readers with valuable insights and entertainment.Some popular blogging platforms include WordPress, Blogger, and Medium. These platforms offer various tools and features that make it easy for anyone to start a blog. Additionally, social media integration allows bloggers to reach a wider audience and foster a sense of community among readers.Whether you are a seasoned writer or a novice, blogging can be a rewarding endeavor. It offers an outlet for creativity, a means to establish an online presence, and the opportunity to connect with like-minded individuals. As the blogging landscape continues to evolve, it remains an integral part of the digital ecosystem, driving conversations and influencing opinions worldwide.";
            bool isContainWordAnd = longString.Contains("individual");
            bool isContaingWordMidst = longString.Contains("home");
            string searchWord = "the";
            int index = longString.IndexOf(searchWord);
            Console.WriteLine($"Text contains word 'individual' - {isContainWordAnd},\nText contains word 'home' - {isContaingWordMidst}\nIndex of word 'the' - {index}");
        }
    }
}