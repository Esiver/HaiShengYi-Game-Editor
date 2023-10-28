namespace HaiShengYi_Game_Editor.User_Interface
{
    partial class AddNewDialogue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.acceptButton = new System.Windows.Forms.Button();
            this.dialogueListbox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectDialogueListBox = new System.Windows.Forms.ListBox();
            this.AddToListButton = new System.Windows.Forms.Button();
            this.RemoveFromListButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(267, 268);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(103, 33);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // dialogueListbox
            // 
            this.dialogueListbox.FormattingEnabled = true;
            this.dialogueListbox.ItemHeight = 17;
            this.dialogueListbox.Location = new System.Drawing.Point(12, 42);
            this.dialogueListbox.Name = "dialogueListbox";
            this.dialogueListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.dialogueListbox.Size = new System.Drawing.Size(156, 208);
            this.dialogueListbox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(156, 268);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 33);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // selectDialogueListBox
            // 
            this.selectDialogueListBox.FormattingEnabled = true;
            this.selectDialogueListBox.ItemHeight = 17;
            this.selectDialogueListBox.Location = new System.Drawing.Point(214, 42);
            this.selectDialogueListBox.Name = "selectDialogueListBox";
            this.selectDialogueListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.selectDialogueListBox.Size = new System.Drawing.Size(156, 208);
            this.selectDialogueListBox.TabIndex = 3;
            // 
            // AddToListButton
            // 
            this.AddToListButton.Location = new System.Drawing.Point(174, 120);
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.Size = new System.Drawing.Size(34, 34);
            this.AddToListButton.TabIndex = 4;
            this.AddToListButton.Text = ">>";
            this.AddToListButton.UseVisualStyleBackColor = true;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // RemoveFromListButton
            // 
            this.RemoveFromListButton.Location = new System.Drawing.Point(174, 160);
            this.RemoveFromListButton.Name = "RemoveFromListButton";
            this.RemoveFromListButton.Size = new System.Drawing.Size(34, 34);
            this.RemoveFromListButton.TabIndex = 5;
            this.RemoveFromListButton.Text = "<<";
            this.RemoveFromListButton.UseVisualStyleBackColor = true;
            this.RemoveFromListButton.Click += new System.EventHandler(this.RemoveFromListButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(174, 200);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(34, 34);
            this.ClearListButton.TabIndex = 6;
            this.ClearListButton.Text = "X";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // AddNewDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 313);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.RemoveFromListButton);
            this.Controls.Add(this.AddToListButton);
            this.Controls.Add(this.selectDialogueListBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dialogueListbox);
            this.Controls.Add(this.acceptButton);
            this.Name = "AddNewDialogue";
            this.Text = "AddNewDialogue";
            this.Load += new System.EventHandler(this.AddNewDialogue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button acceptButton;
        private ListBox dialogueListbox;
        private Button cancelButton;
        private ListBox selectDialogueListBox;
        private Button AddToListButton;
        private Button RemoveFromListButton;
        private Button ClearListButton;
    }
}