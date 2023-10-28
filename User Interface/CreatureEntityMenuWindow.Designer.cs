namespace HaiShengYi_Game_Editor
{
    partial class CreatureEntityMenuWindow
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
            CreatureEntityListBox = new ListBox();
            CreatureEntityMenuTitle = new Label();
            AddNewCreatureEntityButton = new Button();
            NewCreatureNameInput = new TextBox();
            NewCreatureNameLabel = new Label();
            NewCreatureImageLabel = new Label();
            NewCreaturePictureBox = new PictureBox();
            DeleteCreatureEntityButton = new Button();
            EditCreatureEntityButton = new Button();
            NewCreatureImageInput = new TextBox();
            CopyFullCreatureJson = new Button();
            NewCreatureHomeTileLabel = new Label();
            NewCreatureClassLabel = new Label();
            NewCreatureDialogueLabel = new Label();
            NewCreatureQuestLabel = new Label();
            NewCreatureInventoryLabel = new Label();
            label5 = new Label();
            NewCreatureHomeTileInput = new TextBox();
            CreatureClassComboBox = new ComboBox();
            NewCreatureDialogueInput = new TextBox();
            NewCreatureQuestInput = new TextBox();
            NewCreatureInventoryInput = new TextBox();
            creatureJsonPreviewBox = new TextBox();
            NewCreatureImageFolderBrowser = new OpenFileDialog();
            RefreshCreatureListButton = new Button();
            ((System.ComponentModel.ISupportInitialize)NewCreaturePictureBox).BeginInit();
            SuspendLayout();
            // 
            // CreatureEntityListBox
            // 
            CreatureEntityListBox.BackColor = Color.Black;
            CreatureEntityListBox.ForeColor = SystemColors.Info;
            CreatureEntityListBox.FormattingEnabled = true;
            CreatureEntityListBox.ItemHeight = 17;
            CreatureEntityListBox.Location = new Point(19, 65);
            CreatureEntityListBox.Margin = new Padding(10);
            CreatureEntityListBox.Name = "CreatureEntityListBox";
            CreatureEntityListBox.Size = new Size(517, 259);
            CreatureEntityListBox.TabIndex = 0;
            CreatureEntityListBox.Click += CreatureEntityListBox_Click;
            CreatureEntityListBox.SelectedIndexChanged += CreatureEntityListBox_SelectedIndexChanged;
            // 
            // CreatureEntityMenuTitle
            // 
            CreatureEntityMenuTitle.AutoSize = true;
            CreatureEntityMenuTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CreatureEntityMenuTitle.Location = new Point(19, 24);
            CreatureEntityMenuTitle.Name = "CreatureEntityMenuTitle";
            CreatureEntityMenuTitle.Size = new Size(274, 31);
            CreatureEntityMenuTitle.TabIndex = 1;
            CreatureEntityMenuTitle.Text = "Creature Entity Menu";
            // 
            // AddNewCreatureEntityButton
            // 
            AddNewCreatureEntityButton.Location = new Point(614, 354);
            AddNewCreatureEntityButton.Name = "AddNewCreatureEntityButton";
            AddNewCreatureEntityButton.Size = new Size(212, 37);
            AddNewCreatureEntityButton.TabIndex = 2;
            AddNewCreatureEntityButton.Text = "Create Creature Entity";
            AddNewCreatureEntityButton.UseVisualStyleBackColor = true;
            AddNewCreatureEntityButton.Click += AddNewCreatureEntityButton_Click;
            // 
            // NewCreatureNameInput
            // 
            NewCreatureNameInput.Location = new Point(705, 94);
            NewCreatureNameInput.Name = "NewCreatureNameInput";
            NewCreatureNameInput.Size = new Size(121, 23);
            NewCreatureNameInput.TabIndex = 3;
            NewCreatureNameInput.TextChanged += NewCreatureNameInput_TextChanged;
            // 
            // NewCreatureNameLabel
            // 
            NewCreatureNameLabel.AutoSize = true;
            NewCreatureNameLabel.Location = new Point(614, 100);
            NewCreatureNameLabel.Name = "NewCreatureNameLabel";
            NewCreatureNameLabel.Size = new Size(43, 17);
            NewCreatureNameLabel.TabIndex = 4;
            NewCreatureNameLabel.Text = "Name";
            // 
            // NewCreatureImageLabel
            // 
            NewCreatureImageLabel.AutoSize = true;
            NewCreatureImageLabel.Location = new Point(614, 139);
            NewCreatureImageLabel.Name = "NewCreatureImageLabel";
            NewCreatureImageLabel.Size = new Size(74, 17);
            NewCreatureImageLabel.TabIndex = 5;
            NewCreatureImageLabel.Text = "Image Path";
            // 
            // NewCreaturePictureBox
            // 
            NewCreaturePictureBox.BackColor = SystemColors.ControlDarkDark;
            NewCreaturePictureBox.Location = new Point(309, 337);
            NewCreaturePictureBox.Name = "NewCreaturePictureBox";
            NewCreaturePictureBox.Size = new Size(75, 61);
            NewCreaturePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            NewCreaturePictureBox.TabIndex = 6;
            NewCreaturePictureBox.TabStop = false;
            // 
            // DeleteCreatureEntityButton
            // 
            DeleteCreatureEntityButton.Location = new Point(155, 366);
            DeleteCreatureEntityButton.Name = "DeleteCreatureEntityButton";
            DeleteCreatureEntityButton.Size = new Size(114, 23);
            DeleteCreatureEntityButton.TabIndex = 7;
            DeleteCreatureEntityButton.Text = "Delete Creature";
            DeleteCreatureEntityButton.UseVisualStyleBackColor = true;
            DeleteCreatureEntityButton.Click += DeleteCreatureButton_Click;
            // 
            // EditCreatureEntityButton
            // 
            EditCreatureEntityButton.Location = new Point(155, 337);
            EditCreatureEntityButton.Name = "EditCreatureEntityButton";
            EditCreatureEntityButton.Size = new Size(114, 23);
            EditCreatureEntityButton.TabIndex = 8;
            EditCreatureEntityButton.Text = "Edit Creature";
            EditCreatureEntityButton.UseVisualStyleBackColor = true;
            // 
            // NewCreatureImageInput
            // 
            NewCreatureImageInput.Location = new Point(705, 133);
            NewCreatureImageInput.Name = "NewCreatureImageInput";
            NewCreatureImageInput.Size = new Size(121, 23);
            NewCreatureImageInput.TabIndex = 9;
            NewCreatureImageInput.Click += NewCreatureImageInputClick;
            NewCreatureImageInput.TextChanged += NewCreatureImageInput_TextChanged;
            // 
            // CopyFullCreatureJson
            // 
            CopyFullCreatureJson.Location = new Point(19, 337);
            CopyFullCreatureJson.Name = "CopyFullCreatureJson";
            CopyFullCreatureJson.Size = new Size(130, 54);
            CopyFullCreatureJson.TabIndex = 12;
            CopyFullCreatureJson.Text = "Copy List JSON";
            CopyFullCreatureJson.UseVisualStyleBackColor = true;
            CopyFullCreatureJson.Click += CopyListBoxButton_Click;
            // 
            // NewCreatureHomeTileLabel
            // 
            NewCreatureHomeTileLabel.AutoSize = true;
            NewCreatureHomeTileLabel.Location = new Point(614, 175);
            NewCreatureHomeTileLabel.Name = "NewCreatureHomeTileLabel";
            NewCreatureHomeTileLabel.Size = new Size(67, 17);
            NewCreatureHomeTileLabel.TabIndex = 13;
            NewCreatureHomeTileLabel.Text = "Home Tile";
            // 
            // NewCreatureClassLabel
            // 
            NewCreatureClassLabel.AutoSize = true;
            NewCreatureClassLabel.Location = new Point(614, 213);
            NewCreatureClassLabel.Name = "NewCreatureClassLabel";
            NewCreatureClassLabel.Size = new Size(38, 17);
            NewCreatureClassLabel.TabIndex = 14;
            NewCreatureClassLabel.Text = "Class";
            // 
            // NewCreatureDialogueLabel
            // 
            NewCreatureDialogueLabel.AutoSize = true;
            NewCreatureDialogueLabel.Location = new Point(614, 250);
            NewCreatureDialogueLabel.Name = "NewCreatureDialogueLabel";
            NewCreatureDialogueLabel.Size = new Size(60, 17);
            NewCreatureDialogueLabel.TabIndex = 15;
            NewCreatureDialogueLabel.Text = "Dialogue";
            // 
            // NewCreatureQuestLabel
            // 
            NewCreatureQuestLabel.AutoSize = true;
            NewCreatureQuestLabel.Location = new Point(614, 282);
            NewCreatureQuestLabel.Name = "NewCreatureQuestLabel";
            NewCreatureQuestLabel.Size = new Size(65, 17);
            NewCreatureQuestLabel.TabIndex = 16;
            NewCreatureQuestLabel.Text = "Quest List";
            // 
            // NewCreatureInventoryLabel
            // 
            NewCreatureInventoryLabel.AutoSize = true;
            NewCreatureInventoryLabel.Location = new Point(614, 318);
            NewCreatureInventoryLabel.Name = "NewCreatureInventoryLabel";
            NewCreatureInventoryLabel.Size = new Size(62, 17);
            NewCreatureInventoryLabel.TabIndex = 17;
            NewCreatureInventoryLabel.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(614, 49);
            label5.Name = "label5";
            label5.Size = new Size(156, 30);
            label5.TabIndex = 18;
            label5.Text = "New Creature";
            // 
            // NewCreatureHomeTileInput
            // 
            NewCreatureHomeTileInput.Location = new Point(705, 172);
            NewCreatureHomeTileInput.Name = "NewCreatureHomeTileInput";
            NewCreatureHomeTileInput.Size = new Size(121, 23);
            NewCreatureHomeTileInput.TabIndex = 19;
            // 
            // CreatureClassComboBox
            // 
            CreatureClassComboBox.FormattingEnabled = true;
            CreatureClassComboBox.Items.AddRange(new object[] { "Peasant", "Warrior", "Sage" });
            CreatureClassComboBox.Location = new Point(705, 210);
            CreatureClassComboBox.Name = "CreatureClassComboBox";
            CreatureClassComboBox.Size = new Size(121, 25);
            CreatureClassComboBox.TabIndex = 20;
            // 
            // NewCreatureDialogueInput
            // 
            NewCreatureDialogueInput.Location = new Point(705, 247);
            NewCreatureDialogueInput.Name = "NewCreatureDialogueInput";
            NewCreatureDialogueInput.Size = new Size(121, 23);
            NewCreatureDialogueInput.TabIndex = 21;
            NewCreatureDialogueInput.Click += NewCreatureDialogueInput_Click;
            // 
            // NewCreatureQuestInput
            // 
            NewCreatureQuestInput.BackColor = Color.White;
            NewCreatureQuestInput.Location = new Point(705, 276);
            NewCreatureQuestInput.Name = "NewCreatureQuestInput";
            NewCreatureQuestInput.Size = new Size(121, 23);
            NewCreatureQuestInput.TabIndex = 22;
            // 
            // NewCreatureInventoryInput
            // 
            NewCreatureInventoryInput.BackColor = Color.White;
            NewCreatureInventoryInput.Location = new Point(705, 315);
            NewCreatureInventoryInput.Name = "NewCreatureInventoryInput";
            NewCreatureInventoryInput.Size = new Size(121, 23);
            NewCreatureInventoryInput.TabIndex = 23;
            // 
            // creatureJsonPreviewBox
            // 
            creatureJsonPreviewBox.Location = new Point(390, 337);
            creatureJsonPreviewBox.Multiline = true;
            creatureJsonPreviewBox.Name = "creatureJsonPreviewBox";
            creatureJsonPreviewBox.Size = new Size(146, 61);
            creatureJsonPreviewBox.TabIndex = 24;
            creatureJsonPreviewBox.Text = "JSON will appear here";
            creatureJsonPreviewBox.Click += creatureJsonPreviewBox_Click;
            // 
            // NewCreatureImageFolderBrowser
            // 
            NewCreatureImageFolderBrowser.FileName = "openFileDialog1";
            NewCreatureImageFolderBrowser.FileOk += New;
            // 
            // RefreshCreatureListButton
            // 
            RefreshCreatureListButton.Location = new Point(461, 29);
            RefreshCreatureListButton.Name = "RefreshCreatureListButton";
            RefreshCreatureListButton.Size = new Size(75, 23);
            RefreshCreatureListButton.TabIndex = 25;
            RefreshCreatureListButton.Text = "Refresh";
            RefreshCreatureListButton.UseVisualStyleBackColor = true;
            RefreshCreatureListButton.Click += RefreshCreatureEntityListBoxButton_Click;
            // 
            // CreatureEntityMenuWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 425);
            Controls.Add(RefreshCreatureListButton);
            Controls.Add(creatureJsonPreviewBox);
            Controls.Add(NewCreatureInventoryInput);
            Controls.Add(NewCreatureQuestInput);
            Controls.Add(NewCreatureDialogueInput);
            Controls.Add(CreatureClassComboBox);
            Controls.Add(NewCreatureHomeTileInput);
            Controls.Add(label5);
            Controls.Add(NewCreatureInventoryLabel);
            Controls.Add(NewCreatureQuestLabel);
            Controls.Add(NewCreatureDialogueLabel);
            Controls.Add(NewCreatureClassLabel);
            Controls.Add(NewCreatureHomeTileLabel);
            Controls.Add(CopyFullCreatureJson);
            Controls.Add(NewCreatureImageInput);
            Controls.Add(EditCreatureEntityButton);
            Controls.Add(DeleteCreatureEntityButton);
            Controls.Add(NewCreaturePictureBox);
            Controls.Add(NewCreatureImageLabel);
            Controls.Add(NewCreatureNameLabel);
            Controls.Add(NewCreatureNameInput);
            Controls.Add(AddNewCreatureEntityButton);
            Controls.Add(CreatureEntityMenuTitle);
            Controls.Add(CreatureEntityListBox);
            Name = "CreatureEntityMenuWindow";
            Text = "CreatureEntityMenuWindow";
            ((System.ComponentModel.ISupportInitialize)NewCreaturePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CreatureEntityListBox;
        private Label CreatureEntityMenuTitle;
        private Button AddNewCreatureEntityButton;
        private TextBox NewCreatureNameInput;
        private Label NewCreatureNameLabel;
        private Label NewCreatureImageLabel;
        private PictureBox NewCreaturePictureBox;
        private Button DeleteCreatureEntityButton;
        private Button EditCreatureEntityButton;
        private TextBox NewCreatureImageInput;
        private Button CopyFullCreatureJson;
        private Label NewCreatureHomeTileLabel;
        private Label NewCreatureClassLabel;
        private Label NewCreatureDialogueLabel;
        private Label NewCreatureQuestLabel;
        private Label NewCreatureInventoryLabel;
        private Label label5;
        private TextBox NewCreatureHomeTileInput;
        private ComboBox CreatureClassComboBox;
        private TextBox NewCreatureDialogueInput;
        private TextBox NewCreatureQuestInput;
        private TextBox NewCreatureInventoryInput;
        private TextBox textBox1;
        private OpenFileDialog NewCreatureImageFolderBrowser;
        private TextBox creatureJsonPreviewBox;
        private Button RefreshCreatureListButton;
    }
}