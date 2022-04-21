using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise7.Helper
{
    class InputValidator
    {
        public static bool validNameInputs(string input)
        {
            string validChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (var ch in input)
            {
                if (!validChar.Contains(ch)) return false;
            }
            return true;
        }
        public static bool validIntInputs(string input)
        {
            string validCase = "12345";
            foreach (var ch in input)
            {
                if (!validCase.Contains(ch)) return true;
            }
            return false;
        }
    }
}
