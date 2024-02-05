using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Card_Game_Overloaded_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card CardToCheck = new Card((int)Card.Suits.Clubs, (int)Card.Values.Three);
            bool doesItMatch = Card.DoesCardMatch(CardToCheck, Card.Values.Three);
            Console.WriteLine(doesItMatch);
        }
    }
}
