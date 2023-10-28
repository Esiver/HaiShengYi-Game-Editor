using HaiShengYi_Game_Editor.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShengYi_Game_Editor.Helpers
{
    internal class JsonHelper
    {
        
        public static string CreatureObjectToJson(CreatureEntity creatureEntity)
        {
            string json = JsonConvert.SerializeObject(creatureEntity);
            return json;
        }

        public static string CreatureObjectListToJson(List<CreatureEntity> creatureEntityList)
        {
            
            string json = JsonConvert.SerializeObject(creatureEntityList);
            return json;
        }

        public static string DialogueObjectToJson(Dialogue dialogue)
        {
            //var serializerSettings = new JsonSerializerSettings();
            //serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver()
            string json = JsonConvert.SerializeObject(dialogue);
            return json;
        }
        public static string DialogueObjectListToJson(List<Dialogue> dialogueList) 
        {
            string json = JsonConvert.SerializeObject(dialogueList);
            return json;
        }
    }
}
