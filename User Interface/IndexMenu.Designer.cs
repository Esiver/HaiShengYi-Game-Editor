namespace HaiShengYi_Game_Editor
{
    partial class IndexMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormTitle = new System.Windows.Forms.Label();
            this.CreatureEntityMenuButton = new System.Windows.Forms.Button();
            this.DialogueMenuButton = new System.Windows.Forms.Button();
            this.PlayGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormTitle.Location = new System.Drawing.Point(24, 20);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(293, 31);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "HaiShengYi Game Editor";
            this.FormTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreatureEntityMenuButton
            // 
            this.CreatureEntityMenuButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CreatureEntityMenuButton.Location = new System.Drawing.Point(36, 122);
            this.CreatureEntityMenuButton.Name = "CreatureEntityMenuButton";
            this.CreatureEntityMenuButton.Size = new System.Drawing.Size(189, 35);
            this.CreatureEntityMenuButton.TabIndex = 1;
            this.CreatureEntityMenuButton.Text = "Creature Entity Menu";
            this.CreatureEntityMenuButton.UseVisualStyleBackColor = false;
            this.CreatureEntityMenuButton.Click += new System.EventHandler(this.OpenCreatureEntityMenuWindow);
            // 
            // DialogueMenuButton
            // 
            this.DialogueMenuButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DialogueMenuButton.Location = new System.Drawing.Point(36, 163);
            this.DialogueMenuButton.Name = "DialogueMenuButton";
            this.DialogueMenuButton.Size = new System.Drawing.Size(189, 36);
            this.DialogueMenuButton.TabIndex = 2;
            this.DialogueMenuButton.Text = "Dialogue Menu";
            this.DialogueMenuButton.UseVisualStyleBackColor = false;
            this.DialogueMenuButton.Click += new System.EventHandler(this.OpenDialogueMenuWindow);
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.BackColor = System.Drawing.Color.Green;
            this.PlayGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlayGameButton.Location = new System.Drawing.Point(267, 122);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.Size = new System.Drawing.Size(93, 74);
            this.PlayGameButton.TabIndex = 3;
            this.PlayGameButton.Text = "Play";
            this.PlayGameButton.UseVisualStyleBackColor = false;
            // 
            // IndexMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.PlayGameButton);
            this.Controls.Add(this.DialogueMenuButton);
            this.Controls.Add(this.CreatureEntityMenuButton);
            this.Controls.Add(this.FormTitle);
            this.Name = "IndexMenu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndexMenu_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FormTitle;
        private Button CreatureEntityMenuButton;
        private Button DialogueMenuButton;
        private Button PlayGameButton;
    }
}