namespace Nine
{
    internal class ClocktowerRepair
    {
        public void Start()
        {
            var item = Helper.GetValidNumberInRange(1, int.MaxValue, "Enter an input");
            
            Console.WriteLine($"{item} is an {EvenOrOdd(item)} number");
        }


        private string EvenOrOdd(int input)
        {
            var result = input % 2;
            return result switch
            {
                0 => "EVEN",
                1 => "ODD",
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
