namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruits = "apple,banana,orange";
            string programmingLangs = "C#,Java,JavaScript,Pyton,Go,PhP";
            string[] fruitsArr = fruits.Split(','), programmingArr = programmingLangs.Split(",");

            foreach (string fruit in fruitsArr)
            {
                Console.WriteLine(fruit + " ");
            };
            Console.WriteLine("--------------------------------");

            foreach (string lang in programmingArr)
            {
                Console.WriteLine(lang + " ");
            }
        }
    }
}