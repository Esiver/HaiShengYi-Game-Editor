using HaiShengYi_Game_Editor.User_Interface;
using System.Diagnostics;

namespace HaiShengYi_Game_Editor
{
    public partial class IndexMenu : Form
    {
        public IndexMenu()
        {
            InitializeComponent();
            Console.WriteLine("Inititalize");
        }
        public void IndexMenu_Close(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CreatureEntityMenuWindow creatureEntityMenuWindow = new CreatureEntityMenuWindow();
            creatureEntityMenuWindow.Show();

        }

        private void OpenCreatureEntityMenuWindow(object sender, EventArgs e)
        {
            CreatureEntityMenuWindow creatureEntityMenuWindow = new CreatureEntityMenuWindow();
            creatureEntityMenuWindow.Show();
        }
        private void OpenDialogueMenuWindow(object sender, EventArgs e)
        {
            DialogueManagerWindow dialogueManagerWindow = new DialogueManagerWindow();
            dialogueManagerWindow.Show();
        }

    }
}