using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tamagotchi
{
    public partial class Tama : Form
    {
        public Tama()
        {
            InitializeComponent();           
        }
        public string NameY; //переменная для имени пользователя
        public int oops = 0; //вспомогательная переменная для "кучек"

        public int Cure //cвойство для индикатора здоровья (progressCure)
        {
            get { return progressCure.Value; }
            set
            {
                if (value > 100)    //если больше максимумального значения элемента, возвращаем 100, чтобы не возникло ошибки 
                    progressCure.Value = 100;
                else if (value < 0) //если меньше минимального значения элемента, то возвращаем 0
                {
                    progressCure.Value = 0;
                    MessageBox.Show("Питомец мертв!"); //сообщение, что питомец мертв, т.к показатель на нуле
                    if (ChooseType.type == 1) //картинка, иллюстрирующая смерть питомца Кот
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catDEAD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                    if (ChooseType.type == 2)//картинка, иллюстрирующая смерть питомца Лягушка
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogBMOOD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                    if (ChooseType.type == 3)//картинка, иллюстрирующая смерть питомца Собака
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogDEAD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }

                    Cure = 0;
                    Feed = 0;
                    Play = 0;
                    Sleep = 0;

                    FEED.Enabled = false; //блокирование кнопок
                    PLAY.Enabled = false;
                    SLEEP.Enabled = false;
                    CLEAR.Enabled = false;
                    CURE.Enabled = false;

                    MessageBox.Show("Создайте нового питомца");//сообщение о создании нового питомца
                }
                else
                    progressCure.Value = value; //если значение показателя не выходит за область значений индикатора, то возвращается текущее значение показателя
            }
        }
        public int Feed //аналогичное cвойство для индикатора сытости (progressFeed)
        {
            get { return progressFeed.Value; }
            set
            {
                if (value > 100)
                    progressFeed.Value = 100;
                else if (value < 0)
                {
                    progressFeed.Value = 0;
                    MessageBox.Show("Питомец мертв!");
                    if (ChooseType.type == 1)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catDEAD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                    if (ChooseType.type == 2)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogBMOOD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                    if (ChooseType.type == 3)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogDEAD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }

                    Cure = 0;
                    Feed = 0;
                    Play = 0;
                    Sleep = 0;

                    FEED.Enabled = false;
                    CURE.Enabled = false;
                    PLAY.Enabled = false;
                    SLEEP.Enabled = false;
                    CLEAR.Enabled = false;
                    
                    MessageBox.Show("Создайте нового питомца");
                }
                else
                    progressFeed.Value = value;
            }
        }
        public int Play //аналогичное cвойство для индикатора веселья (progressPlay)
        {
            get { return progressPlay.Value; }
            set
            {
                if (value > 100)
                    progressPlay.Value = 100;
                else if (value < 0)
                {
                    progressPlay.Value = 0;
                    MessageBox.Show("Питомец мертв!");
                    if (ChooseType.type == 1)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catDEAD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                    if (ChooseType.type == 2)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogBMOOD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                    if (ChooseType.type == 3)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogDEAD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }

                    Cure = 0;
                    Feed = 0;
                    Play = 0;
                    Sleep = 0;

                    FEED.Enabled = false;
                    CURE.Enabled = false;
                    PLAY.Enabled = false;
                    SLEEP.Enabled = false;
                    CLEAR.Enabled = false;
                   
                    MessageBox.Show("Создайте нового питомца");
                }
                else
                    progressPlay.Value = value;
            }
        }
        public int Sleep //аналогичное cвойство для индикатора бодрости (progressSleep)
        {
            get { return progressSleep.Value; }
            set
            {
                if (value > 100)
                    progressSleep.Value = 100;
                else if (value < 0)
                {
                    progressSleep.Value = 0;

                    MessageBox.Show("Питомец мертв!");

                    if (ChooseType.type == 1)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catDEAD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                    if (ChooseType.type == 2)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogBMOOD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                    if (ChooseType.type == 3)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogDEAD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }

                    Cure = 0;
                    Feed = 0;
                    Play = 0;
                    Sleep = 0;

                    FEED.Enabled = false;
                    CURE.Enabled = false;
                    PLAY.Enabled = false;
                    SLEEP.Enabled = false;
                    CLEAR.Enabled = false;
                    
                    MessageBox.Show("Создайте нового питомца");
                }
                else
                    progressSleep.Value = value;
            }
        }
        private void Tama_Load(object sender, EventArgs e)
        {
            FEED.Enabled = false; //все кнопки при первом запуске заблокированы
            CURE.Enabled = false;
            PLAY.Enabled = false;
            SLEEP.Enabled = false;
            CLEAR.Enabled = false;
        }

        private void FEED_Click(object sender, EventArgs e) //кнопка "Кормить"
        {
            if (oops == 4) { Tama_waste.Visible = true; CLEAR.Enabled = true; } //условие, что если вспомогательная переменная для "кучек" равна 4, изображение "кучки" становится видимым, открывается доступ к кнопке "Убрать за питомцем"
            if (ChooseType.type == 1) //если питомец - кот
            {
                if (Feed < 100 & Feed>0) //условие для выполнения функции
                {
                    FEED.Enabled = true; //кнопка доступна, когда значение показателя не выходит за его границы 

                    if (Feed < 40) //если значение меньше 40, то мордочка питоцма становится недовольной
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catWS.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                        MessageBox.Show("Питомец голоден!");
                    }

                    ChooseFood dlg = new ChooseFood(); //открытие нового окна. на котором представлен выбор продуктов питания
                    dlg.ShowDialog();

                    if (ChooseFood.type == 1) //хлеб +30
                    {
                        Feed += 30; //прибавляет 30 единиц
                        oops++; //увеличение вспомогательной переменой на 1 при кормлении
                        System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catEB.png", System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureTama.Image = img;
                    }
                    if (ChooseFood.type == 2) //банан +20
                    {
                        Feed += 20;//прибавляет 20 единиц
                        oops++; //увеличение вспомогательной переменой на 1 при кормлении
                        System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catHAPPY.png", System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureTama.Image = img;
                    }
                    if (ChooseFood.type == 3) //конфетки +10
                    {
                        oops++; //увеличение вспомогательной переменой на 1 при кормлении
                        Feed += 10;//прибавляет 10 единиц
                        System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catES.png", System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureTama.Image = img;
                    }
                }
                if (Feed >= 100) //если показатель больше или равен максимуму
                {
                    FEED.Enabled = false;//кнопка блокируеся
                    MessageBox.Show("Питомец уже сытый!");//появляется сообщение, что питомец сыт
                }
            }
                
            if (ChooseType.type == 3) //если питомец - собака (аналогичные операции, что и с первым типом)
            {
                if (Feed<100 & Feed > 0)
                {
                    FEED.Enabled = true;

                    if (Feed < 40)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogNMOOD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                        MessageBox.Show("Питомец голоден!");
                    }

                    ChooseFood dlg = new ChooseFood();
                    dlg.ShowDialog();

                    if (ChooseFood.type == 1) //хлеб +30
                    {
                        Feed += 30;
                        oops++;
                        System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogEAT1.png", System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureTama.Image = img;
                    }

                    if (ChooseFood.type == 2) //банан +20
                    {
                        Feed += 20;
                        oops++;
                        System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogBEAT.png", System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureTama.Image = img;
                    }

                    if (ChooseFood.type == 3) //конфетки +10
                    {
                        Feed += 10;
                        oops++;
                        System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogEATS.png", System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureTama.Image = img;
                    }
                }
                if (Feed >= 100) //если показатель больше или равен максимуму
                {
                    FEED.Enabled = false;//кнопка блокируеся
                    MessageBox.Show("Питомец уже сытый!");//появляется сообщение, что питомец сыт
                }
            }

            if (ChooseType.type == 2) //если питомец - лягушка (далее все аналогично)
            {
                if (Feed < 100 & Feed > 0)
                {
                    FEED.Enabled = true;

                    if (Feed < 40)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogBMOOD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                        MessageBox.Show("Питомец голоден!");
                    }

                    ChooseFood dlg = new ChooseFood();
                    dlg.ShowDialog();

                    if (ChooseFood.type == 1) //хлеб +30
                    {
                        Feed += 30;
                        oops++;
                        System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogEAT.png", System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureTama.Image = img;
                    }
                    if (ChooseFood.type == 2) //банан +20
                    {
                        Feed += 20;
                        oops++;
                        System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogEAT.png", System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureTama.Image = img;
                    }
                    if (ChooseFood.type == 3) //конфетки +10
                    {
                        Feed += 10;
                        oops++;
                        System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogEAT.png", System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureTama.Image = img;
                    }
                }

                if (progressFeed.Value >= 100)
                {
                   FEED.Enabled = false;
                   MessageBox.Show("Питомец уже сытый!");
                }
                
            }
            
        }

        private void PLAY_Click(object sender, EventArgs e) //кнопка "Играть"
        {
            Play += 10; //показатель веселья растет на 10
            Feed -= 15;//показатели сытости, бодрости, здоровья уменьшаются на 15//
            FEED.Enabled = true;// открытие доступа кнопки, если она была заблокирована
            Sleep -= 15;
            SLEEP.Enabled = true;
            Cure -= 15;
            CURE.Enabled = true;
            if (Cure == 0 || Sleep == 0 || Feed == 0) CURE.Enabled = false;


            if (Play < 100 & Play > 0)//условие для выполнения функции
            {
                PLAY.Enabled = true; //кнопка доступна, когда значение показателя не выходит за его границы 

                if (ChooseType.type == 1) //если питомец Кот
                {
                    if (Play > 50) //если показатель больше 50, то мордочка кота сменяется на игривую
                    {
                        System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catPLAY.png", System.IO.FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        pictureTama.Image = img;
                    }

                    if (Play < 20)  //если показатель меньше 20, то мордочка кота сменяется на злую
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catAngry.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                }

                if (ChooseType.type == 2) //если питомец Лягушка
                {
                    if (Play < 20)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogBMOOD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }

                    if (Play > 50)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogHMOOD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                }

                if (ChooseType.type == 3) //если питомец Собака
                {
                    if (Play < 20)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogAMOOD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }

                    if (Play > 50)
                    {
                        System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogHMOOD.png", System.IO.FileMode.Open);
                        System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                        f.Close();
                        pictureTama.Image = im;
                    }
                }
                
            } else if (Play >= 100) // если показатель больше или равен 100 

            {
                    PLAY.Enabled = false; //блокируется кнопка 
                    MessageBox.Show("Питомец уже счастлив!"); //появляется сообщение, которое уведомляет пользователя о том, что питомец счастлива
            }
        }

        private void SLEEP_Click(object sender, EventArgs e) //кнопка "Спать"
        {
            Sleep+= 40; //показатель бодрости растет на 20
            Play -= 10;//показатель веселья  уменьшается на 10
            PLAY.Enabled = true;// открытие доступа кнопки, если она была заблокирована
            Feed -= 15;//показатель сытости  уменьшается на 15
            FEED.Enabled = true;// открытие доступа кнопки, если она была заблокирована

            if (Sleep < 100 & Sleep > 0)//условие для выполнения функции
            {
                SLEEP.Enabled = true;//кнопка доступна, когда значение показателя не выходит за его границы 

                if (ChooseType.type == 1) //если питомец Кот
                {
                    SLEEP dlg = new SLEEP(); // появление вспомогательного окна, демонстрирующего фазу сна
                    dlg.ShowDialog();
                

                    if (Sleep < 30) //еси показатель бодрости меньше 30, то мордочка зверька сменяется на недовольную
                    {
                    System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\catWS.png", System.IO.FileMode.Open);
                    System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                    f.Close();
                    pictureTama.Image = im;  
                    }
                }

                if (ChooseType.type == 2) //если питомец Лягушка
                {
                    SLEEP dlg = new SLEEP();
                    dlg.ShowDialog();

                    if (Sleep < 30)
                    {
                    System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frogBMOOD.png", System.IO.FileMode.Open);
                    System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                    f.Close();
                    pictureTama.Image = im;

                    }
                }

                if (ChooseType.type == 3)  //если питомец Собака
                {
                    SLEEP dlg = new SLEEP();
                    dlg.ShowDialog();

                    if (Sleep < 30)
                    {
                    System.IO.FileStream f = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dogAMOOD.png", System.IO.FileMode.Open);
                    System.Drawing.Image im = System.Drawing.Image.FromStream(f);
                    f.Close();
                    pictureTama.Image = im;

                    }
                }   
            }
            else if (Sleep >= 100) //иначе, если показатель равен 100
            {
                SLEEP.Enabled = false; //кнопка блокируется
                MessageBox.Show("Питомец уже бодрый!"); //всплывает сообщение, что питомец уже бодрый
            }     
            if (Sleep<= 0) SLEEP.Enabled = false;
        }

        private void CURE_Click(object sender, EventArgs e) //кнопка "Лечить"
        {
            Cure+=40; //показатель здоровья растет на 30

            if (Cure < 100 & Cure > 0)//условие для выполнения функции
            {
                CURE.Enabled = true; //кнопка доступна, когда значение показателя не выходит за его границы
            }
            else if (Cure >= 100) //иначе, если показатель равен 100
            {
                CURE.Enabled = false;//кнопка блокируется
                MessageBox.Show("Питомец уже здоровый!");//всплывает сообщение, что питомец уже бодрый
            }
            else if (Cure<=0) CURE.Enabled = false;

        }

        private void YES_Click(object sender, EventArgs e) //кнопка "?"
        {
            ChooseType dlg = new ChooseType(); //открытие окна выбора питомца
            dlg.ShowDialog();

            if (ChooseType.type == 1) //если был выбран питомец Кот
            {
                progressPlay.Value = 50; //все показатели на базовом значении
                progressFeed.Value = 50; 
                progressSleep.Value = 50;
                progressCure.Value = 50;

                System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\cat.png", System.IO.FileMode.Open); 
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                pictureTama.Image = img;//передача изображения питомца на главную форму
            }

           else if (ChooseType.type == 2) //если был выбран питомец Лягушка
            {
                progressPlay.Value = 50;//все показатели на базовом значении
                progressFeed.Value = 50;
                progressSleep.Value = 50;
                progressCure.Value = 50;

                System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\frog.png", System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                pictureTama.Image = img; //передача изображения питомца на главную форму
            }

           else if (ChooseType.type == 3) //если был выбран питомец Собака
            {
                progressPlay.Value = 50;//все показатели на базовом значении
                progressFeed.Value = 50;
                progressSleep.Value = 50;
                progressCure.Value = 50;

                System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Айнура\Desktop\just do it\wasted\уп\Tamagotchi\png\dog.png", System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                pictureTama.Image = img; //передача изображения питомца на главную форму
            }

            FEED.Enabled = true; //кнопки становятся доступны
            CURE.Enabled = true;
            PLAY.Enabled = true;
            SLEEP.Enabled = true;
            CLEAR.Enabled = false;
        }

        private void enterTname_TextChanged(object sender, EventArgs e) //обработка окошка ввода
        {
            NameY = (string)enterTname.Text; //введеное в окошке ввода имя запоминается в переменную имени
        }

        private void OK_Click(object sender, EventArgs e) //кнопка "ОК"
        {
            if (NameY!= null)
            {
                Your_name.Text = "Привет, " + NameY + "!"; //при нажатии кнопки в метку your_name передается введенное через окошко ввода имя
                Enter_name.Text = ("Введите имя зверька"); 
                enterTname.Clear();//окошко ввода очищается  
            }
            else MessageBox.Show("Вы ввели пустое имя! Попробуйте снова:)");     
        }

        private void help_Click(object sender, EventArgs e) //кнопка "help" 
        {
            //кратко описан принцип действия приложения
            MessageBox.Show("Дорогой пользователь! Для того чтобы выбрать питомца нажми на ?. Увеличивать показатели можно нажимая на кнопки: 'Кормить', 'Спать', 'Лечить', 'Играть'. При нажатии кнопки 'Спать' зверек засыпает.Зверек время от времени оставляет за собой кучки. Убирайте их с помощью кнопки 'Убрать' .Если сытость, или бодрость, или здоровье, или счастье упадут до нуля, зверек умирает.");

        }

        private void CLEAR_Click(object sender, EventArgs e) //кнопка "Убрать за питомцем"
        {
            Tama_waste.Visible = false; //изображение "кучки" становится невидимым 
            CLEAR.Enabled = false;// доступ к кнопке закрывается
        }

    }
}
