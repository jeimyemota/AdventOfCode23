
namespace Day1
{
    class Day1
    {
        public static void Main()
        {
            //Read information within Day 1 txt file
            String[] lines = File.ReadAllLines(@"InputFile\Day1.txt");

            int total = 0;

            foreach (var line in lines)
            {
                //combine first number and last number, filtering out any letters and numbers in between
                string numbers = string.Concat(line.Where(Char.IsDigit));
                //Get first number 
                string first = numbers.Substring(0, 1);
                //Get Last Number
                string last = numbers.Substring(numbers.Length -1);
                //Concatenate numbers 
                string newNumbers = first + last;
                //turning into int and adding to total var
                total += Int32.Parse(newNumbers);
            }
            //Output
            Console.WriteLine(total);
        }
            
    }
}