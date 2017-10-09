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
    public partial class Main : Form
    {
        private ShipDoc doc;
        public Main()
        {
            doc = new ShipDoc(4);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMap m = new MainMap(this.doc);
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BattleField m = new BattleField(this.doc);
            m.Show();
            
        }
    }
}
