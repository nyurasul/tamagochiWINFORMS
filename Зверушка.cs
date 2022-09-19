using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
   public class Зверушка
    {
        int Здоровье = 100;
        int Сытость = 100;
        int Радость = 100;
        int Бодрость = 100;
        Random random = new Random();

        //повышаем значения
        public int Feed()
        {
            return Сытость = Сытость + 10;
        }
        public int Play()
        {
            return Радость = Радость + 10;
        }
        public int Cure()
        {
            return Здоровье = Здоровье + 10;
        }
        public int Sleep()
        {
            return Бодрость = Бодрость + 10;
        }
        //godmode
        public void GodMode()
        {
            Здоровье = 100;
            Сытость = 100;
            Радость = 100;
            Бодрость = 100;
        }

        public string checkstate()
        {
            switch (random.Next(0, 6))
            {
                case (1):
                    Здоровье = Здоровье - 10;
                    break;
                case (2):
                    Сытость = Сытость - 10;
                    break;
                case (3):
                    Радость = Радость - 10;
                    break;
                case (4):
                    Бодрость = Бодрость - 10;
                    break;
            }
            if (Сытость == 0 || Радость == 0 || Здоровье == 0)
            {
                return "Мертв";
            }
            if (Сытость < 20)
            {
                return "Голоден";
            }
            if (Здоровье < 20)
            {
                return "Приболел";
            }
            if (Радость < 20)
            {
                return "Грустный";
            }
           
            if (Бодрость < 20)
            {
                return "Сонный";
            }
            return "Здоров";
        }
        //получить значение
        public int Getздоровье()
        {
            return Здоровье;
        }
        public int GetСытость()
        {
            return Сытость;
        }
        public int GetРадость()
        {
            return Радость;
        }
    }
}
