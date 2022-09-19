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
    public partial class ChooseFood : Form
    {
        public ChooseFood()
        {
            InitializeComponent();
        }
        public static int type = 0;//вспомогательная переменная определения типа продукта

        private void pictureBread_Click(object sender, EventArgs e) //хлеб
        {
            type = 1;
        }

        private void pictureBanana_Click(object sender, EventArgs e)//банан
        {
            type = 2;
        }

        private void pictureSweet_Click(object sender, EventArgs e)//конфеты
        {
            type = 3;
        }

        private void ChooseFood_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();//таймер для автоматического закрытия формы 
            t.Interval = 2 * 1000; //2 сек
            t.Tick += delegate { this.Close(); };
            t.Start();
        }
    }
}
