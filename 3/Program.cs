using System;

namespace PR5
{

    class Program
    {

        static void Main(string[] args)
        {
            string text = "Текст, який потрібно перевірити";
            int brackets = 0;

            foreach (char c in text)
            {
                if (c == '(')
                {
                    brackets++;
                }

                else if (c == ')')
                {
                    brackets--;
                }
                
                if (brackets < 0)
                {
                    Console.WriteLine("Дужки розставленi неправильно!");
                  
                    return;
                }

            }

            if (brackets == 0)
            {
                Console.WriteLine("Дужки розставленi правильно!");
            }

            else
            {
                Console.WriteLine("Дужки розставленi неправильно!");
            }
        }
    }
}