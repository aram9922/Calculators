using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipWars
{
    public partial class BattleField : Form
    {
        public ShipDoc Doc;
        public BattleField(ShipDoc aDoc)
        {
            Doc = aDoc;
            InitializeComponent();
            CreateButtons();
            ClientSize = new Size(500, 500);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Black;
            string s = b.Name;
            int x = int.Parse(s.Substring(1, 1));
            int y = int.Parse(s.Substring(3, 1));
            if (Doc.Ship[x, y]) b.BackColor = Color.Red;
            else b.BackColor = Color.Gray;
        }
        private void CreateButtons()
        {
            Button[,] Buttons = new Button[10, 10];
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Button aButton;
                    aButton = new Button();
                    aButton.Name = "B" + i.ToString() + "_" + j.ToString();
                    aButton.Size = new Size(50, 50);
                    aButton.Location = new Point(i * 50, j * 50);
                    aButton.Click += new EventHandler(this.Button_Click);
                   
                    Controls.Add(aButton);
                    Buttons[i, j] = aButton;
                }
            }
        }
    }
}
