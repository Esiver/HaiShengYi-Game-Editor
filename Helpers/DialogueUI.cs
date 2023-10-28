using HaiShengYi_Game_Editor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShengYi_Game_Editor.Helpers
{
    internal class DialogueUI
    {
        public static void CaptureNewDialogue(string stringEntry, string stringResponse, List<int> childrenRefs)
        {
            Dialogue newDialogue = new Dialogue(stringEntry, stringResponse, childrenRefs);
            DataAccess db = new DataAccess();
            db.InsertDialogieIntoTable(newDialogue);
        }
        public static void UpdateDialogueChildren(int dialogueId, List<int> childrenRefs)
        {
            DataAccess db = new DataAccess();
            db.UpdateDialogueChildren(dialogueId, childrenRefs);

        }
        public static void AddDialogueToListBox(List<Dialogue> dialogueList, object listBox)
        {
            foreach (Dialogue dialogue in dialogueList)
            {
                dialogueList.Add(dialogue);
            }
        }

        public static void AddListBoxSelectedItemsToListBox(ListBox.ObjectCollection selectedItems, ListBox listBox)
        {
            foreach(var selectedItem in selectedItems)
            {
                listBox.Items.Add(selectedItem);
            }
        }
    }
}
