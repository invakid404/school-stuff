using System;

namespace Inquiry
{
    public static class InputUtil
    {
        public static void ReadString(string name, out string res)
        { 
            Console.Write($@"{name}: ");
            res = Console.ReadLine();
        }

        public static void ReadInt(string name, out int res)
        {
            do
            {
                PromptField(name);
            } while (!int.TryParse(Console.ReadLine(), out res));
        }

        private static void PromptField(string name)
        {
            Console.Write($@"{name}: ");
        }
    }
}