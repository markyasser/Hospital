using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public class Validation
    {
        //validate if the input is empty
        public bool IsEmpty(string text)
        {
            if (text == "")
                return true;
            else
                return false;
        }

        //validate if the input is an integer number
        public bool IsInteger(string text)
        {
            int Parse;
            if (Int32.TryParse(text, out Parse))
                return true;
            else
                return false;
        }

        //validate if the input is a float number
        public bool IsFloat(string text)
        {
            float Parse;
            if (float.TryParse(text, out Parse))
                return true;
            else
                return false;
        }

        //validate if the input is a positive integer number
        public bool IsPosInteger(string text)
        {
            int Parse;
            if (Int32.TryParse(text, out Parse))
            {
                if (Parse > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        //validate if the input is a positive float number
        public bool IsPosFloat(string text)
        {
            float Parse;
            if (float.TryParse(text, out Parse))
            {
                if (Parse > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        //validate if the input is alphabet only with white spaces
        public bool IsAlpha(string text)
        {
            foreach (char c in text)
            {
                if (!Char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }

        //validate if the input is alphabet or numbers with _ or @ or . (useful when entering an email) 
        public bool IsAlpha_OR_Numbers_With_Underscores_OR_at_OR_dot(string text)
        {
            foreach (char c in text)
            {
                if (!Char.IsLetterOrDigit(c) && c != '_' && c != '@' && c != '.')
                    return false;
            }
            return true;
        }

        //validate if the input is alphabet or letters only with white spaces
        public bool IsAlpha_OR_Numbers(string text)
        {
            foreach (char c in text)
            {
                if (!Char.IsLetterOrDigit(c) && c != '.')
                    return false;
            }
            return true;
        }

        //validate if the date is in the past 
        public bool IsPast(DateTime DT)
        {
            if (DT.Year < DateTime.Now.Year)
                return true;
            else if (DT.Year > DateTime.Now.Year)
                return false;
            else if (DT.Month < DateTime.Now.Month)
                return true;
            else if (DT.Month > DateTime.Now.Month)
                return false;
            else if (DT.Day < DateTime.Now.Day)
                return true;
            else
                return false;
        }
    }
}