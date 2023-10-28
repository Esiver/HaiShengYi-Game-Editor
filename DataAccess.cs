using HaiShengYi_Game_Editor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using HaiShengYi_Game_Editor.Helpers;

namespace HaiShengYi_Game_Editor
{
    internal class DataAccess
    {
        string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=HTMLRPG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string creatureEntityTable = "dbo.CreatureEntityTable";
        string DialogueTable = "dbo.DialogueTable";



        public void DeleteDialogue(int dialogueId)
        {
            string query = $"DELETE FROM {DialogueTable} Where Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = dialogueId;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateDialogueChildren(int dialogueId, List<int> childrenRef)
        {
            string childrenRefString = Helpers.HelperFunctions.IntListToString(childrenRef);
            string query = $"UPDATE {DialogueTable} SET children = '{childrenRefString}' WHERE Id = {dialogueId}";
            Debug.WriteLine(query);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                SqlCommand cmd = new SqlCommand(query, conn);
                
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
        public void InsertDialogieIntoTable(Dialogue dialogue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"INSERT INTO {DialogueTable} (entry, response, children) VALUES (@entry, @response, @children) ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@entry", dialogue.Entry);
                command.Parameters.AddWithValue("@response", dialogue.Response);
                command.Parameters.AddWithValue("@children", HelperFunctions.IntListToString(dialogue.ChildrenRefs));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public List<Dialogue> GetDialogues()
        {
            List<Dialogue> dialogueList = new List<Dialogue>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM {DialogueTable}";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int dialogueId = reader.GetInt32(0);
                        string dialogueEntry = reader.GetString(1);
                        string dialogueResponse = reader.GetString(2);
                        string dialogueChildrenString = reader.GetString(3);

                        List<int> dialogueRefs = HelperFunctions.SplitStringToList(dialogueChildrenString);
                        

                        Dialogue dialogue = new Dialogue( dialogueEntry, dialogueResponse, dialogueRefs);
                        dialogue.Id = dialogueId;
                        dialogueList.Add(dialogue);
                    }
                }
                connection.Close();
            }
            return dialogueList;
        }
        public List<Dialogue> GetDialoguesFromId(List<int> idList)
        {
            List<Dialogue> dialogueList = new List<Dialogue>();
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string idPlaceholders = string.Join(",", idList.Select((id)=> id));
                string query = $"SELECT * FROM {DialogueTable} WHERE Id IN ({idPlaceholders})";

                SqlCommand cmd = new SqlCommand(query, connection);
         
                for (int i = 0; i < idList.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@Id"+ i, idList[i]);
                    Debug.WriteLine(idList[i]);

                }
                Debug.WriteLine(query);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable); 
                foreach(DataRow row in dataTable.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    string entry = Convert.ToString(row["entry"]);
                    string response = Convert.ToString(row["response"]);
                    string childListString = Convert.ToString(row["children"]);
                    List<int> childIntList = HelperFunctions.SplitStringToList(childListString);
                    
                    Dialogue dialogue = new Dialogue(entry, response, childIntList);
                    dialogue.Id = id;

                    dialogueList.Add(dialogue);
                }
                
            }
            return dialogueList;
        }
        public List<CreatureEntity> GetCreatureEntityList()
        {
            List<CreatureEntity> creatureEntityList = new List<CreatureEntity>();
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM {creatureEntityTable}";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string creatureName = reader.GetString(1);
                        string creatureClass = reader.GetString(2);
                        string creaturePortraitImagePath = reader.GetString(3);
                        string creatureThumbnailPath = reader.GetString(4);
                        string creatureDialogueChildren = reader.GetString(5);
                        List<int> creatureDialogueRefs = HelperFunctions.SplitStringToList(creatureDialogueChildren);
                        List<int> creatureHomeTile = HelperFunctions.SplitStringToList(reader.GetString(6));
                        string creatureItemList = reader.GetString(7);
                        string creatureQuestList = reader.GetString(8);
                        CreatureEntity entity = new CreatureEntity(
                            creatureName,
                            creatureClass,
                            creatureThumbnailPath,
                            creaturePortraitImagePath, 
                            creatureHomeTile,
                            creatureDialogueRefs, 
                            creatureItemList, 
                            creatureQuestList
                            );
                        entity.Id = id;

                        creatureEntityList.Add(entity);
                    }
                }

                connection.Close();
                //var queryOutput = connection.Query<CreatureEntity>(query);

            }
            return creatureEntityList;
        }

        public void InsertCreatureEntityIntoTable(CreatureEntity creatureEntity)
        {
            //int id = 0;//creatureEntity.Id;
            string creatureName = creatureEntity.Name;
            string creaturePortraitImagePath = creatureEntity.PortraitImagePath;
            string creatureThumbnailImagePath = creaturePortraitImagePath;
            string creatureClass = creatureEntity.Class;
            string creatureDialogueRefs = HelperFunctions.IntListToString(creatureEntity.DialogueRefs);
            string creatureHometile = HelperFunctions.IntListToString(creatureEntity.HomeTile);
            string creatureItemlist = creatureEntity.ItemList;
            string creatureQuestlist = creatureEntity.QuestList;
            
            string query = $"INSERT INTO {creatureEntityTable} (Name, Class, PortraitImage, ThumbnailImage, Dialogue, HomeTile, ItemList, QuestList) VALUES (@Name, @Class, @PortraitImage, @ThumbnailImage, @Dialogue, @HomeTile, @ItemList, @QuestList)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                //cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", creatureName);
                cmd.Parameters.AddWithValue("@Class", creatureClass);
                cmd.Parameters.AddWithValue("@PortraitImage", creaturePortraitImagePath);
                cmd.Parameters.AddWithValue("@ThumbnailImage", creatureThumbnailImagePath);
                cmd.Parameters.AddWithValue("@Dialogue", creatureDialogueRefs);
                cmd.Parameters.AddWithValue("@HomeTile", creatureHometile);
                cmd.Parameters.AddWithValue("@ItemList", creatureItemlist);
                cmd.Parameters.AddWithValue("@QuestList", creatureQuestlist);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                connection.Close();
                
            }
        }
        public void DeleteCreatureEntityFromTable(CreatureEntity creatureEntity)
        {
            int creatureId = creatureEntity.Id;
            string query = $"DELETE FROM {creatureEntityTable} WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = creatureId;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
