namespace HomeWork
{
    public class Sample
    {
        [Documentation("Nazar Kylnytskyi", Version = 1, Description = "This method writes the most iconic line")]
        public void SampleM()

        {
            Console.WriteLine("Hello World");
        }
        [Documentation("Patrick McHale", Version = 2, Description = "Another sample method")]
        public void AnotherMethod()
        {
            Console.WriteLine("Sample method");
        }
        public void BlankMethod()
        {
            Console.WriteLine("");
        }

    }
}