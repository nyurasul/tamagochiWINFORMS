using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class SLEEP : Form
    {
        public SLEEP()
        {
            InitializeComponent();
        }

        private void SLEEP_Load(object sender, EventArgs e)
        {
            Timer t = new Timer(); //таймер для автоматического закрытия формы 
            t.Interval = 2 * 1000; //2 сек
            t.Tick += delegate { this.Close(); };
            t.Start(); 
        }
    }
}
