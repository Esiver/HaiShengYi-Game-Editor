using HaiShengYi_Game_Editor.Helpers;
using HaiShengYi_Game_Editor.Models;
using HaiShengYi_Game_Editor.User_Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaiShengYi_Game_Editor
{
    public partial class CreatureEntityMenuWindow : Form
    {
        List<CreatureEntity> creatureEntityList = new List<CreatureEntity>();

        public CreatureEntityMenuWindow()
        {
            InitializeComponent();

            CreatureEntityListBox.DataSource = creatureEntityList;
            CreatureEntityListBox.DisplayMember = "displaySelf";


            RefreshCreatureEntityListBox();

        }
        public void RefreshCreatureEntityListBoxButton_Click(object sender, EventArgs e)
        {
            RefreshCreatureEntityListBox();
        }
        public void RefreshCreatureEntityListBox()
        {
            DataAccess db = new DataAccess();
            creatureEntityList = db.GetCreatureEntityList();

            CreatureEntityListBox.DataSource = creatureEntityList;
            CreatureEntityListBox.DisplayMember = "displaySelf";
        }
        public void CreatureEntityListBox_Click(object sender, EventArgs e)
        {

            var selectedItem = CreatureEntityListBox.SelectedItem;
            var castSelectedItem = (CreatureEntity)selectedItem;
            var selectedItemJsonString = JsonHelper.CreatureObjectToJson(castSelectedItem);

            Debug.WriteLine(selectedItemJsonString);
            updateCreatureJsonPreviewBox(selectedItemJsonString);

            if (File.Exists(castSelectedItem.PortraitImagePath))
            {
                var selectedItemImageBitmap = new Bitmap(castSelectedItem.PortraitImagePath);
                updateCreatureImagePreviewBox(selectedItemImageBitmap);
            }
            else
            {
                // default image?
            }


        }
        public void CopyListBoxButton_Click(object sender, EventArgs e)
        {
            var listBoxItems = CreatureEntityListBox.Items;
            List<CreatureEntity> listBoxCreatures = new List<CreatureEntity>();
            foreach (CreatureEntity item in listBoxItems)
            {
                listBoxCreatures.Add(item);
            }
            string jsonList = Helpers.JsonHelper.CreatureObjectListToJson(listBoxCreatures);
            updateCreatureJsonPreviewBox(jsonList);
        }
        public void DeleteCreatureButton_Click(object sender, EventArgs e)
        {
            var selectedCreatureItem = CreatureEntityListBox.SelectedItem;
            if (selectedCreatureItem != null)
            {
                Helpers.CreatureEntityUICapture.DeleteCreatureEntity((CreatureEntity)selectedCreatureItem);
            }
            RefreshCreatureEntityListBox();
        }
        private void creatureJsonPreviewBox_Click(object sender, EventArgs e)
        {
            Helpers.CreatureEntityUICapture.ClipboardCopyText(creatureJsonPreviewBox.Text);
        }

        private void updateCreatureJsonPreviewBox(string jsonString)
        {
            creatureJsonPreviewBox.Text = jsonString;
        }
        private void updateCreatureImagePreviewBox(Bitmap imageBitmap)
        {
            NewCreaturePictureBox.Image = imageBitmap;
        }
        private void NewCreatureImageInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewCreatureImageInputClick(object sender, EventArgs e)
        {
            if (NewCreatureImageFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                NewCreatureImageInput.Text = NewCreatureImageFolderBrowser.SafeFileName;
            }
        }
        private void NewCreatureDialogueInput_Click(object sender, EventArgs e)
        {
            string refList = "0"; //NewCreatureDialogueInput.Text
            List<int> creatureDialigueRefList = HelperFunctions.SplitStringToList(refList);
            DataAccess db = new DataAccess();
            List<Dialogue> creatureDialogueList = db.GetDialoguesFromId(creatureDialigueRefList);

            AddNewDialogue addDialogueWindow = new AddNewDialogue(creatureDialogueList);
            addDialogueWindow.Owner = this;

            if (addDialogueWindow.ShowDialog() == DialogResult.OK)
            {
                List<Dialogue> dialogues = addDialogueWindow.DialogueList;
                List<int> childrenRefs = HelperFunctions.DialogueListToIntList(dialogues);

                if (childrenRefs.Count > 0)
                {
                    NewCreatureDialogueInput.Text = HelperFunctions.IntListToString(childrenRefs);
                    //RefreshDialogueChildrenList(childrenRefs);

                    //if (DialogueListBox != null && DialogueListBox.SelectedItem != null)
                    //{
                    //    Dialogue selectedDialogue = DialogueListBox.SelectedItem as Dialogue;
                    //    DialogueUI.UpdateDialogueChildren(selectedDialogue.Id, childrenRefs);

                    //}
                }
            }
            else
            {
                Debug.WriteLine("dialogue manger NOT OK");

            }
        }
        private void AddNewCreatureEntityButton_Click(object sender, EventArgs e)
        {

            string creatureName = NewCreatureNameInput.Text;
            string creatureClass = CreatureClassComboBox.Text.ToLower();
            string creatureThumbnailImagePath = NewCreatureImageInput.Text;
            string creaturePortraitImagePath = NewCreatureImageInput.Text;
            string creatureHometile = NewCreatureHomeTileInput.Text;
            List<int> creatureDialogueRefs = HelperFunctions.SplitStringToList(NewCreatureDialogueInput.Text);
            string creatureItemlist = NewCreatureQuestInput.Text;
            string creatureQuestList = NewCreatureInventoryInput.Text;

            CreatureEntityUICapture.CaptureNewCreatureEntity(
                creatureName, 
                creatureClass, 
                creatureThumbnailImagePath, 
                creaturePortraitImagePath, 
                creatureHometile, 
                creatureDialogueRefs, 
                creatureItemlist, 
                creatureQuestList
                );

            ClearNewCreatureFields();
            RefreshCreatureEntityListBox();
        }
        private void ClearNewCreatureFields()
        {
            NewCreatureNameInput.Clear();
            NewCreatureNameInput.Clear();
            NewCreatureImageInput.Clear();
            CreatureClassComboBox.SelectedIndex = -1;
            NewCreatureHomeTileInput.Clear();
            NewCreatureDialogueInput.Clear();
            NewCreatureQuestInput.Clear();
            NewCreatureInventoryInput.Clear();
        }

        private void NewCreatureNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void New(object sender, CancelEventArgs e)
        {

        }

        private void CreatureEntityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
