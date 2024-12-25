using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tylda
{
    internal class GameView
    {
        public static void StartGame()
        {
            var player = PlayerCharacterCreator.CreatePlayerCharacter();
            var enemy = EnemiesCharacterCreator.ChooseEnemy();
            while (player.Hp > 0)
            {
                WhatToDo(player);
                Common.ShowCharacterParameters(player);
            }
            EndGame(player);
        }

        public static void GoToSleep(Character character)
        {
            int MaxHp = 100;
            Console.WriteLine("Kierujesz sie w s stronę lasu, gdzie znajduje się wygodne miejsce do spania");
            Console.WriteLine("Zapadasz w sen, po kilku godzinach budzisz się w pełni wypoczęty");
            Console.WriteLine("Zdrowie odnowione!");
            character.Hp = MaxHp;
            Common.WaitForUserAction();
        }

        public static void WhatToDo(Character player)
        {
            Console.Clear();
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1 - Idź spać");
            Console.WriteLine("2 - Kontynuuj przygodę");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    GoToSleep(player);
                    break;
                case "2":
                    CombatSystem.BattleStart(player, EnemiesCharacterCreator.ChooseEnemy());
                    break;
                default:
                    Console.WriteLine("Nie istnieje taka opcja");
                    Console.WriteLine("Wybierz interesujący Cię element menu");
                    Common.WaitForUserAction();
                    WhatToDo(player);
                    break;
            }
        }

        public static void EndGame(Character player)
        {
            Console.Clear();
            if (player.Hp > 0)
            {
                Console.WriteLine("Gratulacje! Ukończyłeś grę!");
            }
            else
            {   
                Console.WriteLine("Niestety, ta przygoda zakończyła się niepowodzeniem");
                Console.WriteLine("Twoja postać zginęła");
            }
            Console.WriteLine("Koniec gry");
            Common.WaitForUserAction();
        }
    }
}
