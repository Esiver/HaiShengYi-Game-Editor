using HaiShengYi_Game_Editor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShengYi_Game_Editor.Helpers
{
    internal class CreatureEntityUICapture
    {
        public static void CaptureNewCreatureEntity(string creatureName, string creatureClass, string thumbnailImagePath, string portraitImagePath, string creatureHometile, List<int> creatureDialogueRefs, string creatureItemList, string creatureQuestList)
        {
            CreatureEntity newCreatureEnity = new CreatureEntity(
                creatureName,
                creatureClass,
                thumbnailImagePath,
                portraitImagePath,
                HelperFunctions.SplitStringToList(creatureHometile), 
                creatureDialogueRefs, 
                creatureItemList, 
                creatureQuestList);
            DataAccess db = new DataAccess();
            db.InsertCreatureEntityIntoTable(newCreatureEnity);
        }
        public static void DeleteCreatureEntity(CreatureEntity creatureEntity)
        {
            DataAccess db = new DataAccess();
            db.DeleteCreatureEntityFromTable(creatureEntity);
        }

        public static void ClipboardCopyText(string textString)
        {
            Clipboard.SetText(textString);
        }
    }
}
