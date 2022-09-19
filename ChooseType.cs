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
    public partial class ChooseType : Form
    {
       
        public static int type = 0; //вспомогательная переменная для определения типа питомца
        public ChooseType()
        {
            InitializeComponent();
        }

        private void pictureCat_Click(object sender, EventArgs e) //кот
        {
            type = 1;
        }

        private void pictureFrog_Click(object sender, EventArgs e)//лягушка
        {
            type = 2;
        }

        private void pictureDog_Click(object sender, EventArgs e) //собака
        {
            type = 3;
        }

        private void ChooseType_Load(object sender, EventArgs e)
        {
            Timer t = new Timer(); //таймер для автоматического закрытия формы 
            t.Interval = 2 * 1000; //2 сек
            t.Tick += delegate { this.Close(); };
            t.Start();
        }
    }
}
