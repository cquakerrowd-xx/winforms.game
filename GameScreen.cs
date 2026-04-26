using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class GameScreen : Form
    {
        List<string> words = new List<string>();
        string newText;
        int i = 0;
        int guessed = 0;

        public GameScreen()
        {
            InitializeComponent();
            SetUp();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SetUp()
        {
            words = File.ReadLines("Words.txt").ToList();
            newText = Scrambled(words[i]);
            lblWord.Text = newText;
            lblCount.Text = "Word Count: " + (i + 1) + words.Count;
        }

        private string Scrambled(string text)
        {
            return new string(text.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
