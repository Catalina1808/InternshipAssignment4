
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class OptionalAssignment
    {
        public int AppTagInterpreter(string text){

            int wrongOpenedTags = 0;
            int wrongClosedTags = 0;

            while (text.Length > 0)
            {
                if (text.StartsWith("<app>"))
                {
                    wrongOpenedTags++;
                    text = text.Substring(5);
                } 
                else if (text.StartsWith("</app>"))
                {
                    if(wrongOpenedTags == 0)
                    {
                        wrongClosedTags++;
                    }
                    else
                    {
                        wrongOpenedTags--;
                    }
                    text = text.Substring(6);
                }
            }

            return wrongOpenedTags + wrongClosedTags;

        }
    }
}
