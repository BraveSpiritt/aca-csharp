namespace Task_18
{


    class Program
    {
        static void Main(string[] args)
        {
            UIElements enabledElements = UIElements.None;

            enabledElements |= UIElements.Button;
            Console.WriteLine("Enabled elements: " + enabledElements);

            bool isButtonEnabled = (enabledElements & UIElements.Button) == UIElements.Button;
            Console.WriteLine("Is Button enabled? " + isButtonEnabled);
        }
        enum UIElements
        {
            None = 0,
            Button = 1 << 0,  
            TextBox = 1 << 1,  
            Checkbox = 1 << 2,
            Label = 1 << 3,    
            Slider = 1 << 4 
        }
    }

}
