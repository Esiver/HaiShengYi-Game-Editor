namespace HaiShengYi_Game_Editor.User_Interface
{
    partial class DialogueManagerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogueManagerWindow));
            DialogueWindowHeader = new Label();
            DialogueListBox = new ListBox();
            SelectDialogueChildrenListBox = new ListBox();
            DialogueIdLabel = new Label();
            DialogueEntryLabel = new Label();
            DialogueResponseLabel = new Label();
            SelectDialogueId = new Label();
            DialogueChildrenLabel = new Label();
            pictureBox1 = new PictureBox();
            RefreshDialogueListButton = new Button();
            NewDialogueButton = new Button();
            DeleteDialogueListButton = new Button();
            SelectDialogueEntry = new RichTextBox();
            SelectDialogueResponse = new TextBox();
            DialogueListGetJSONButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DialogueWindowHeader
            // 
            DialogueWindowHeader.AutoSize = true;
            DialogueWindowHeader.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DialogueWindowHeader.Location = new Point(12, 22);
            DialogueWindowHeader.Name = "DialogueWindowHeader";
            DialogueWindowHeader.Size = new Size(317, 31);
            DialogueWindowHeader.TabIndex = 0;
            DialogueWindowHeader.Text = "Dialogue Manager Menu";
            // 
            // DialogueListBox
            // 
            DialogueListBox.FormattingEnabled = true;
            DialogueListBox.ItemHeight = 17;
            DialogueListBox.Location = new Point(12, 70);
            DialogueListBox.Name = "DialogueListBox";
            DialogueListBox.Size = new Size(148, 276);
            DialogueListBox.TabIndex = 1;
            DialogueListBox.Click += DialogueList_Click;
            DialogueListBox.SelectedIndexChanged += DialogueListBox_SelectedIndexChanged;
            // 
            // SelectDialogueChildrenListBox
            // 
            SelectDialogueChildrenListBox.BackColor = Color.LightCoral;
            SelectDialogueChildrenListBox.ForeColor = Color.Maroon;
            SelectDialogueChildrenListBox.FormattingEnabled = true;
            SelectDialogueChildrenListBox.ItemHeight = 17;
            SelectDialogueChildrenListBox.Location = new Point(344, 252);
            SelectDialogueChildrenListBox.Name = "SelectDialogueChildrenListBox";
            SelectDialogueChildrenListBox.Size = new Size(263, 89);
            SelectDialogueChildrenListBox.TabIndex = 2;
            SelectDialogueChildrenListBox.Click += DialogueChildrenList_Click;
            // 
            // DialogueIdLabel
            // 
            DialogueIdLabel.AutoSize = true;
            DialogueIdLabel.Location = new Point(344, 69);
            DialogueIdLabel.Name = "DialogueIdLabel";
            DialogueIdLabel.Size = new Size(31, 17);
            DialogueIdLabel.TabIndex = 3;
            DialogueIdLabel.Text = "Id : ";
            DialogueIdLabel.Click += label1_Click;
            // 
            // DialogueEntryLabel
            // 
            DialogueEntryLabel.AutoSize = true;
            DialogueEntryLabel.Location = new Point(344, 86);
            DialogueEntryLabel.Name = "DialogueEntryLabel";
            DialogueEntryLabel.Size = new Size(48, 17);
            DialogueEntryLabel.TabIndex = 4;
            DialogueEntryLabel.Text = "Entry : ";
            DialogueEntryLabel.Click += label1_Click_1;
            // 
            // DialogueResponseLabel
            // 
            DialogueResponseLabel.AutoSize = true;
            DialogueResponseLabel.Location = new Point(344, 147);
            DialogueResponseLabel.Name = "DialogueResponseLabel";
            DialogueResponseLabel.Size = new Size(76, 17);
            DialogueResponseLabel.TabIndex = 5;
            DialogueResponseLabel.Text = "Response : ";
            // 
            // SelectDialogueId
            // 
            SelectDialogueId.BackColor = SystemColors.Control;
            SelectDialogueId.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectDialogueId.ForeColor = SystemColors.ActiveCaptionText;
            SelectDialogueId.Location = new Point(381, 69);
            SelectDialogueId.Name = "SelectDialogueId";
            SelectDialogueId.Size = new Size(82, 17);
            SelectDialogueId.TabIndex = 6;
            // 
            // DialogueChildrenLabel
            // 
            DialogueChildrenLabel.AutoSize = true;
            DialogueChildrenLabel.Location = new Point(344, 232);
            DialogueChildrenLabel.Name = "DialogueChildrenLabel";
            DialogueChildrenLabel.Size = new Size(67, 17);
            DialogueChildrenLabel.TabIndex = 9;
            DialogueChildrenLabel.Text = "Children : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(177, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // RefreshDialogueListButton
            // 
            RefreshDialogueListButton.Location = new Point(12, 352);
            RefreshDialogueListButton.Name = "RefreshDialogueListButton";
            RefreshDialogueListButton.Size = new Size(71, 23);
            RefreshDialogueListButton.TabIndex = 11;
            RefreshDialogueListButton.Text = "Refresh";
            RefreshDialogueListButton.UseVisualStyleBackColor = true;
            RefreshDialogueListButton.Click += RefreshDialogueListButton_Click;
            // 
            // NewDialogueButton
            // 
            NewDialogueButton.Location = new Point(506, 347);
            NewDialogueButton.Name = "NewDialogueButton";
            NewDialogueButton.Size = new Size(101, 23);
            NewDialogueButton.TabIndex = 12;
            NewDialogueButton.Text = "Add";
            NewDialogueButton.UseVisualStyleBackColor = true;
            NewDialogueButton.Click += AddDialogueListButton_Click;
            // 
            // DeleteDialogueListButton
            // 
            DeleteDialogueListButton.Location = new Point(85, 352);
            DeleteDialogueListButton.Name = "DeleteDialogueListButton";
            DeleteDialogueListButton.Size = new Size(75, 23);
            DeleteDialogueListButton.TabIndex = 13;
            DeleteDialogueListButton.Text = "Delete";
            DeleteDialogueListButton.UseVisualStyleBackColor = true;
            // 
            // SelectDialogueEntry
            // 
            SelectDialogueEntry.Location = new Point(344, 106);
            SelectDialogueEntry.Name = "SelectDialogueEntry";
            SelectDialogueEntry.Size = new Size(263, 38);
            SelectDialogueEntry.TabIndex = 14;
            SelectDialogueEntry.Text = "";
            // 
            // SelectDialogueResponse
            // 
            SelectDialogueResponse.Location = new Point(344, 167);
            SelectDialogueResponse.Multiline = true;
            SelectDialogueResponse.Name = "SelectDialogueResponse";
            SelectDialogueResponse.Size = new Size(263, 59);
            SelectDialogueResponse.TabIndex = 15;
            // 
            // DialogueListGetJSONButton
            // 
            DialogueListGetJSONButton.Location = new Point(12, 381);
            DialogueListGetJSONButton.Name = "DialogueListGetJSONButton";
            DialogueListGetJSONButton.Size = new Size(148, 23);
            DialogueListGetJSONButton.TabIndex = 16;
            DialogueListGetJSONButton.Text = "Get JSON";
            DialogueListGetJSONButton.UseVisualStyleBackColor = true;
            DialogueListGetJSONButton.Click += DialogueListGetJSONButton_Click;
            // 
            // DialogueManagerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 424);
            Controls.Add(DialogueListGetJSONButton);
            Controls.Add(SelectDialogueResponse);
            Controls.Add(SelectDialogueEntry);
            Controls.Add(DeleteDialogueListButton);
            Controls.Add(NewDialogueButton);
            Controls.Add(RefreshDialogueListButton);
            Controls.Add(pictureBox1);
            Controls.Add(DialogueChildrenLabel);
            Controls.Add(SelectDialogueId);
            Controls.Add(DialogueResponseLabel);
            Controls.Add(DialogueEntryLabel);
            Controls.Add(DialogueIdLabel);
            Controls.Add(SelectDialogueChildrenListBox);
            Controls.Add(DialogueListBox);
            Controls.Add(DialogueWindowHeader);
            Name = "DialogueManagerWindow";
            Text = "DialogueManagerWindow";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DialogueWindowHeader;
        private ListBox DialogueListBox;
        private Label DialogueIdLabel;
        private ListBox SelectDialogueChildrenListBox;
        private Label DialogueEntryLabel;
        private Label DialogueResponseLabel;
        private Label SelectDialogueId;
        private Label DialogueChildrenLabel;
        private PictureBox pictureBox1;
        private Button RefreshDialogueListButton;
        private Button NewDialogueButton;
        private Button DeleteDialogueListButton;
        private RichTextBox SelectDialogueEntry;
        private TextBox SelectDialogueResponse;
        private Button DialogueListGetJSONButton;
    }
}