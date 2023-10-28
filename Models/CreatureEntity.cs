using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShengYi_Game_Editor.Models
{
    internal class CreatureEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("portraitImage")]
        public string PortraitImagePath { get; set; }

        [JsonProperty("thumbnailImage")]
        public string ThumbnaiImagePath { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("homeTile")]
        public List<int> HomeTile { get; set; }

        [JsonProperty("dialogue")]
        public List<int> DialogueRefs {get; set; }

        [JsonProperty("itemList")]
        public string ItemList { get; set; }

        [JsonProperty("questList")]
        public string QuestList { get; set; }

        [JsonIgnore]
        public string displaySelf
        {
            get { return $"{Name}"; } 
        }

        public CreatureEntity (string name, string creatureClass, string thumbnailImagePath, string portraitImagePath, List<int> homeTile, List<int> dialogueRefs, string itemList, string questList)
        {
            Name = name;
            Type = "creature";
            PortraitImagePath = portraitImagePath;
            ThumbnaiImagePath = thumbnailImagePath;
            Class = creatureClass;
            HomeTile = homeTile;
            DialogueRefs = dialogueRefs;
            QuestList = questList;
            ItemList = itemList;
        }
    }
}
