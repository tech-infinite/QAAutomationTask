using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAutomationTask.Page_Objects
{
    public class NamesData
    {
        //const string _characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        const string _characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";             //  Generate() would be the same, except _characters.Count would now be _characters.Length, although that could even be cut down a bit.
        public string Generate(int lenght)
        {
            Random random = new Random();
            StringBuilder buffer = new StringBuilder(lenght);
            for (int i = 0; i < lenght; i++)
            {
                int randomNumber = random.Next(0, _characters.Length);
                buffer.Append(_characters, randomNumber, 1);
            }
            return buffer.ToString();
        }
    }
}
