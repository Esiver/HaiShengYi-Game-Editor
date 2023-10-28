using HaiShengYi_Game_Editor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShengYi_Game_Editor.Helpers
{
    internal class HelperFunctions
    {
        public static List<int> SplitStringToList(string input)
        {
            List<int> result = new List<int>();

            string[] values = input.Split(',');

            foreach (string value in values)
            {
                if (int.TryParse(value, out int intValue))
                {
                    result.Add(intValue);
                }
                else
                {
                    // Handle invalid value if needed
                    Console.WriteLine($"Invalid value: {value}");
                }
            }

            return result;
        }

        public static string IntListToString(List<int> list)
        {
            // Convert the list of integers to a list of strings
            List<string> stringList = list.Select(x => x.ToString()).ToList();
            // Join the strings using a separator
            string result = string.Join(",", stringList);

            return result;
        }

        public static List<int> DialogueListToIntList(List<Dialogue> dialogues)
        {
            List<int> ints = new List<int>();
            if(dialogues != null)
            {
                foreach (Dialogue dialogue in dialogues)
                {
                    ints.Add(dialogue.Id);
                }
            }
            

            return ints;

        }

        public static string CreatureDialogueToDbDialogue(List<Dialogue> dialogues)
        {
            List<int> ints = DialogueListToIntList(dialogues);
            string dbString = IntListToString(ints);
            return dbString;
        }

        public static void CopyStringToClipboard(string text)
        {
           Clipboard.SetText(text);
        }

    }
}
