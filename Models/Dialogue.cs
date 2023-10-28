using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShengYi_Game_Editor.Models
{
    public class Dialogue
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("entry")]
        public string Entry { get; set; }
        [JsonProperty("response")]
        public string Response { get; set; }
        [JsonProperty("childrenRefs")]
        public List<int> ChildrenRefs { get; set; }

        [JsonIgnore]
        public string displaySelf
        {
            get { return $"{Response} , {Entry} - ({ChildrenRefs.Count()})"; }
        }

        public Dialogue (string entry, string response, List<int> childrenRefs)
        {
            Entry = entry;
            Response = response;
            ChildrenRefs = childrenRefs;
        }
    }
}
