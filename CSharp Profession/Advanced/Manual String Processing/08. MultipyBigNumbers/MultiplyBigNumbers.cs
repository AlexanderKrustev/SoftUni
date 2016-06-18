namespace _08.MultipyBigNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {

            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            int naum = 0;
            if (number1.Length > number2.Length)
            {

               // number2 = new string('1', number1.Length - number2.Length) + number2;
            }
            else
            {

             //   number1 = new string('1', number2.Length - number1.Length) + number1;
            }
            Stack<int> newNumber = new Stack<int>();
            for (int i = number1.Length - 1; i >= 0; i--)
            {
                int num1 = int.Parse(number1[i].ToString());
                
                int resultTemp = (num1 * int.Parse(number2)) + naum;
                naum = 0;
                if (resultTemp >= 10)
                {

                    newNumber.Push(resultTemp%10);
                    resultTemp = resultTemp/10;
                    naum = resultTemp;

                }
                else
                {

                    newNumber.Push(resultTemp);
                }
            }
            if (naum > 1)
            {
                newNumber.Push(naum);
            }
            bool ledingZerosOnly = true;
            StringBuilder sb = new StringBuilder();
            while (newNumber.Count > 0)
            {
                if (newNumber.Peek() == 1 || newNumber.Peek() == 2
                    || newNumber.Peek() == 3
                    || newNumber.Peek() == 4
                    || newNumber.Peek() == 5
                    || newNumber.Peek() == 6
                    || newNumber.Peek() == 7
                    || newNumber.Peek() == 8
                    || newNumber.Peek() == 9)
                {
                    ledingZerosOnly = false;
                }
                if (!ledingZerosOnly)
                {
                    sb.Append(newNumber.Pop());
                }
                else
                {
                    newNumber.Pop();
                }

            }
            if (sb.Length == 0)
            {
                sb.Append(0);
            }
            Console.WriteLine(sb);
        }

        public static bool ContainsOnlyZero(Stack<int> st)
        {
            if (st.Count == 0)
            {
                return true;
            }
            if (!st.Contains(1) && !st.Contains(2) && !st.Contains(3) && !st.Contains(4) && !st.Contains(5) &&
                !st.Contains(6) && !st.Contains(7) && !st.Contains(8) && !st.Contains(9))
            {
                return true;
            }
            return false;
        }
    }
}