namespace G10_Exam_Yarmukhamedova
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
        }
          // task 1
        public static string GetLastFour(string text)
        {
            var responseText = text.Substring( text.Length - 4);
            return responseText;
        }

         // task 2
        public static int CountOfOddElement(List<int> numbers)
        {
            var counterOfOddElement = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    counterOfOddElement++;
                }
            }
            return counterOfOddElement;

        }
         // task 3
        public static bool EndWithG10(string text)
        {
            if (text.EndsWith("g_10") is true)
            {
                return true;
            }
            return false;
        }

          // task 4
         public static bool CheckLengthOfElementMoreThanTree(List<string> words)
        {
            var response = false;
            foreach (var word in words)
            {
                if(word.Length <3 )
                {
                 response = false;  
                 break;
                }
                response = true;
            }
           
            return response;
        }
    }
}
