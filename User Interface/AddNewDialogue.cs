using HaiShengYi_Game_Editor.Helpers;
using HaiShengYi_Game_Editor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaiShengYi_Game_Editor.User_Interface
{
    public partial class AddNewDialogue : Form
    {
        public List<Dialogue> _ReturnDialogue { get; set; }
        public List<Dialogue> fullDialogueList { get; set; }

        public AddNewDialogue(List<Dialogue> dialogueList)
        {
            InitializeComponent();

            DataAccess db = new DataAccess();
            fullDialogueList = db.GetDialogues();
            
            dialogueListbox.DataSource = fullDialogueList;
            dialogueListbox.DisplayMember = "displaySelf";

            
            selectDialogueListBox.DisplayMember = "displaySelf";
            foreach (Dialogue dialogue in dialogueList)
            {
                selectDialogueListBox.Items.Add(dialogue);
            }
        }


        private void AddNewDialogue_FormClose(object sender, EventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var selectDialogueListBoxItems = selectDialogueListBox.Items;
            List<Dialogue> placeholderList = new List<Dialogue>();
            if (selectDialogueListBoxItems != null && selectDialogueListBoxItems.Count > 0)
            {
                foreach (var dialogue in selectDialogueListBoxItems)
                {
                    placeholderList.Add((Dialogue)dialogue);
                }
            }
            DialogueList = placeholderList;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //this.ReturnDialogue = new List<Dialogue>();
            //this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void AddNewDialogue_Load(object sender, EventArgs e)
        {

        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            
            var userSelectDialogueList = dialogueListbox.SelectedItems;
            //DialogueUI.AddListBoxSelectedItemsToListBox(userSelectDialogueList, selectDialogueListBox);
            foreach (var dialogue in userSelectDialogueList)
            {
                selectDialogueListBox.Items.Add(dialogue);
            }
            //selectDialogueListBox.DataSource = userSelectDialogueList;
            dialogueListbox.SelectedItems.Clear();
        }

        private void RemoveFromListButton_Click(object sender, EventArgs e)
        {
            var userSelectDialogueList = selectDialogueListBox.SelectedItems;
            
            if (selectDialogueListBox.SelectedIndex != -1)
            {
                for (int i = userSelectDialogueList.Count - 1; i >= 0; i--)
                    selectDialogueListBox.Items.Remove(userSelectDialogueList[i]);
            }


            selectDialogueListBox.SelectedItems.Clear();

        }
        private void ClearListButton_Click(object sender, EventArgs e)
        {
            selectDialogueListBox.Items.Clear();
        }
        public List<Dialogue> DialogueList 
        { 
            get 
            {
                return _ReturnDialogue;
            }
            set 
            { 
                _ReturnDialogue = value; 
            }
        }
    }
}
