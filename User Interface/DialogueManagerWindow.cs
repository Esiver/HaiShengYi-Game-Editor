using HaiShengYi_Game_Editor.Helpers;
using HaiShengYi_Game_Editor.Models;
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

namespace HaiShengYi_Game_Editor.User_Interface
{
    public partial class DialogueManagerWindow : Form
    {
        List<Dialogue> dialogueList = new List<Dialogue>();
        public DialogueManagerWindow()
        {
            InitializeComponent();
            RefreshDialogueList();
        }

        public void RefreshDialogueList()
        {
            DataAccess db = new DataAccess();
            dialogueList = db.GetDialogues();

            DialogueListBox.DataSource = dialogueList;
            DialogueListBox.DisplayMember = "displaySelf";

        }
        public void RefreshDialogueListButton_Click(object sender, EventArgs e)
        {
            RefreshDialogueList();
        }
        public void AddDialogueListButton_Click(object sender, EventArgs e)
        {

            string entry = SelectDialogueEntry.Text;
            string response = SelectDialogueResponse.Text;
            var selectedChildrenList = SelectDialogueChildrenListBox.Items;
            List<int> childrenRefs = new List<int>();

            foreach (Dialogue child in selectedChildrenList)
            {
                childrenRefs.Add(child.Id);
            }

            Helpers.DialogueUI.CaptureNewDialogue(entry, response, childrenRefs);
        }
        public void DialogueList_Click(object sender, EventArgs e)
        {
            var selectedItem = DialogueListBox.SelectedItem;
            Dialogue selectedItemDialogue = (Dialogue)selectedItem;

            UpdateShownDialogue(selectedItemDialogue);
        }
        public void DialogueChildrenList_Click(object sender, EventArgs e)
        {
            List<Dialogue> listBoxDialogueChildren = SelectDialogueChildrenListBox.Items.Cast<Dialogue>().ToList();
            AddNewDialogue addDialogueWindow = new AddNewDialogue(listBoxDialogueChildren);
            addDialogueWindow.Owner = this;

            if (addDialogueWindow.ShowDialog() == DialogResult.OK)
            {
                List<Dialogue> dialogues = addDialogueWindow.DialogueList;
                List<int> childrenRefs = HelperFunctions.DialogueListToIntList(dialogues);

                if (childrenRefs.Count > 0)
                {
                    RefreshDialogueChildrenList(childrenRefs);

                    if (DialogueListBox != null && DialogueListBox.SelectedItem != null)
                    {
                        Dialogue selectedDialogue = DialogueListBox.SelectedItem as Dialogue;
                        DialogueUI.UpdateDialogueChildren(selectedDialogue.Id, childrenRefs);

                    }
                }
            }
            else
            {
                Debug.WriteLine("dialogue manger NOT OK");

            }


        }
        public void UpdateShownDialogue(Dialogue dialogue)
        {
            //RefreshDialogueList();

            SelectDialogueId.Text = dialogue.Id.ToString();
            SelectDialogueEntry.Text = dialogue.Entry.ToString();
            SelectDialogueResponse.Text = dialogue.Response.ToString();

            RefreshDialogueChildrenList(dialogue.ChildrenRefs);

        }
        public void RefreshDialogueChildrenList(List<int> childrenRefs)
        {
            List<Dialogue> dialogueChildrenList = new List<Dialogue>();


            if (childrenRefs != null && childrenRefs.Count > 0)
            {
                DataAccess db = new DataAccess();
                dialogueChildrenList = db.GetDialoguesFromId(childrenRefs);
            }


            SelectDialogueChildrenListBox.DataSource = dialogueChildrenList;
            SelectDialogueChildrenListBox.DisplayMember = "displaySelf";
        }
        public void DeleteDialogueButton_Click(object sender, EventArgs e) 
        {
            var chosenDialogue = DialogueListBox.SelectedItem as Dialogue;
            if (chosenDialogue != null)
            {
                int dialogueId = chosenDialogue.Id;
                DataAccess db = new DataAccess();
                db.DeleteDialogue(dialogueId);
            }
            RefreshDialogueList();
            
        }
        public void DialogueListGetJSONButton_Click(object sender, EventArgs e)
        {
            RefreshDialogueList();
            List<Dialogue> allDialogue = new List<Dialogue>();
            foreach(var item in DialogueListBox.Items)
            {
                allDialogue.Add((Dialogue)item);
            }
            string dialogueListJson = JsonHelper.DialogueObjectListToJson(allDialogue);
            HelperFunctions.CopyStringToClipboard(dialogueListJson);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DialogueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
