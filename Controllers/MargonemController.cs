using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MargonemByKycU.Models;

namespace MargonemByKycU.Controllers
{
    public class MargonemController : Controller
    {
        private static PlayerAndEnemy playerAndEnemy = new PlayerAndEnemy();
        private static PlayerModel player = new PlayerModel();
        private static IList<EnemyModel> enemyList = new List<EnemyModel>();
        public static bool czyStworzonoModel = false;
        public static IList<string> listaAtakow = new List<string>();

        //Deklaruje informacje o ulepszeniach dostępnych w sklepie. Z czasem ulega modyfikacji (koszty ulepszeń się zwiększają)
        public static ShopModel shopModel = new ShopModel()
        {
            atackSpeedUpg = 0.25f,
            atackSpeedCena = 100,
            atackDamageUpg = 25,
            atackDamageCena = 100,
            armorUpg = 50,
            armorCena = 100,
            hitPointsUpg = 50,
            hitPointsCena = 100
        };

        //Deklaruje informacje o statystykach dla pierwszego poziomu gracza/wroga
        FirstLevelData firstLevelData = new FirstLevelData()
        {
            atackSpeed = 2,
            atackDamage = 150,
            armor = 100,
            hitPoints = 500
        };

        //Po zakonczeniu walki wyswietla strone z podsumowaniem walki 
        public ActionResult WygranaWalka()
        {
            return View(playerAndEnemy);
        }
        public ActionResult PrzegranaWalka()
        {
            return View(playerAndEnemy);
        }

        //Wyświetla widok walki z przeciwnikiem, orczytuje informacje o przeciwniku dzięki jego id
        [HttpGet]
        public ActionResult AtakujPrzeciwnika(int id)
        {

            //Wykona się tylko raz
            if (!czyStworzonoModel)
            {
                playerAndEnemy = PolaczObaModele(enemyList.FirstOrDefault(x => x.enemyID == id), player);
                czyStworzonoModel = true;
            }
            
            //TempData for enemy
            TempData["enemyName"] = playerAndEnemy.enemyName;
            TempData["enemyAtackSpeed"] = playerAndEnemy.enemyAtackSpeed;
            TempData["enemyAtackDamage"] = playerAndEnemy.enemyAtackDamage;
            TempData["enemyArmor"] = playerAndEnemy.enemyArmor;
            TempData["enemyHitPoints"] = playerAndEnemy.enemyHitPoints;

            //TempData for player
            TempData["playerName"] = playerAndEnemy.name;
            TempData["atackSpeed"] = playerAndEnemy.atackSpeed;
            TempData["atackDamage"] = playerAndEnemy.atackDamage;
            TempData["armor"] = playerAndEnemy.armor;
            TempData["hitPoints"] = playerAndEnemy.hitPoints;

            TempData["button"] = "Atakuj!";

            playerAndEnemy.listaAtakow = listaAtakow;

            return View(playerAndEnemy);
        }

        //Po kliknięciu atakuj, wywołują się poszczególne funkcje a następnie przekierowuje nas do nieco zmodyfikowanego okna walki
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtakujPrzeciwnika()
        {
            wykonajAtak(playerAndEnemy.enemyID);

            if (playerAndEnemy.enemyHitPoints <= 0)
            {
                playerAndEnemy.enemyHitPoints = 0;
                playerAndEnemy.zloto += playerAndEnemy.zlotoZaWalke;
                playerAndEnemy.xp += playerAndEnemy.xpZaWalke;

                player.zloto += playerAndEnemy.zlotoZaWalke;
                player.xp += playerAndEnemy.xpZaWalke;

                sprawdzCzyNextLvl();

                listaAtakow.Clear();
                return RedirectToAction(nameof(WygranaWalka));
            }
            else if (playerAndEnemy.hitPoints <= 0)
            {
                playerAndEnemy.hitPoints = 0;
                listaAtakow.Clear();
                return RedirectToAction(nameof(PrzegranaWalka));
            }
            else
            {
                return RedirectToAction(nameof(AtakujPrzeciwnika));

            }
        }

        //Menue gry, z niego wybieramy czy chcemy iść do sklepu, czy chcemy walczyć
        public ActionResult Index()
        {
            return View();
        }

        //Tworzy postać
        [HttpGet]
        public ActionResult Create()
        {
            return View(new PlayerModel());
        }

        //Menue sklepu i statystyk
        [HttpGet]
        public ActionResult Details()
        {
            TempData["cenaAtackSpeed"] = shopModel.atackSpeedCena;
            TempData["cenaAtackDamage"] = shopModel.atackDamageCena;
            TempData["cenaArmor"] = shopModel.armorCena;
            TempData["cenaHitPoints"] = shopModel.hitPointsCena;

            TempData["nazwaPostaci"] = player.name;
            TempData["klasaPostaci"] = player.klasa;
            TempData["poziom"] = player.lvl;
            TempData["atackSpeed"] = player.atackSpeed;
            TempData["atackDamage"] = player.atackDamage;
            TempData["armor"] = player.armor;
            TempData["hitPoints"] = player.hitPoints;
            TempData["zloto"] = player.zloto;
            TempData["xp"] = player.xp;

            return View(shopModel);
        }

        //Pyta użytkownika czy kupić daną statystykę w sklepie, dodaje ją użytkownikowi, zabiera złoto oraz zwiększa cenę, gdy nie ma wystarczająco złota wyświetla komunikat
        [HttpGet]
        public ActionResult CzyKupic(int id)
        {
            shopModel.id = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CzyKupic()
        {
            switch (shopModel.id)
            {
                case 1:
                    {
                        if (player.zloto >= shopModel.atackSpeedCena)
                        {
                            player.atackSpeed += shopModel.atackSpeedUpg;
                            player.zloto -= shopModel.atackSpeedCena;
                            shopModel.atackSpeedCena += 50;
                        }
                        else
                        {
                            TempData["czyStac"] = "Nie stać cię na to!";
                            return RedirectToAction("CzyKupic");
                        }
                    }
                    break;
                case 2:
                    {
                        if (player.zloto >= shopModel.atackDamageCena)
                        {
                            player.atackDamage += shopModel.atackDamageUpg;
                            player.zloto -= shopModel.atackDamageCena;
                            shopModel.atackDamageCena += 50;
                        }
                        else
                        {
                            TempData["czyStac"] = "Nie stać cię na to!";
                            return RedirectToAction("CzyKupic");
                        }
                    }
                    break;
                case 3:
                    {
                        if (player.zloto >= shopModel.armorCena)
                        {
                            player.armor += shopModel.armorUpg;
                            player.zloto -= shopModel.armorCena;
                            shopModel.armorCena += 50;
                        }
                        else
                        {
                            TempData["czyStac"] = "Nie stać cię na to!";
                            return RedirectToAction("CzyKupic");
                        }
                    }
                    break;
                case 4:
                    {
                        if (player.zloto >= shopModel.hitPointsCena)
                        {
                            player.hitPoints += shopModel.hitPointsUpg;
                            player.zloto -= shopModel.hitPointsCena;
                            shopModel.hitPointsCena += 50;
                        }
                        else
                        {
                            TempData["czyStac"] = "Nie stać cię na to!";
                            return RedirectToAction("CzyKupic");
                        }
                    }
                    break;
                default:
                    {
                        TempData["czyStac"] = "Coś zawiodło!";
                        return RedirectToAction("CzyKupic");
                    }
            }
            MathF.Round(player.atackSpeed);
            MathF.Round(player.atackDamage);
            MathF.Round(player.armor);
            MathF.Round(player.hitPoints);
            MathF.Round(player.zloto);

            return RedirectToAction("Details");
        }

        //Zwraca widok wyboru przeciwnika
        public ActionResult Walka()
        {
            czyStworzonoModel = false;
            enemyList = EnemyModels();
            return View(enemyList);
        }

        //Zapisuje dane gracza w playerModel, robi to na podstawie podanych przez gracza informacji oraz FirstLevelData (które przechowuje informacje o statystykach dla pierwszego poziomu gracza/przeciwnika)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlayerModel playerModel)
        {
            playerModel.lvl = 1;
            playerModel.atackSpeed = firstLevelData.atackSpeed;
            playerModel.atackDamage = firstLevelData.atackDamage;
            playerModel.armor = firstLevelData.armor;
            playerModel.hitPoints = firstLevelData.hitPoints;
            playerModel.zloto = 0;

            player = playerModel;
            return RedirectToAction(nameof(Index));
        }

        //Tworzy listę w której zawierają się modele przeciwników
        public List<EnemyModel> EnemyModels()
        {
            List<EnemyModel> enemyList = new List<EnemyModel>();

            enemyList.Add(NormalEnemy());
            enemyList.Add(Elite());
            enemyList.Add(EliteSecond());
            enemyList.Add(Titan());

            return enemyList;
        }   

        //Tworzy modele przeciwników wyświetlane w Walka.cshtml
        public EnemyModel NormalEnemy()
        {
            EnemyModel normalEnemy = new EnemyModel();

            float mnoznikPrzeciwnika = 0.1f;

            normalEnemy.enemyName = "Goblin"; 
            normalEnemy.enemyLvl = player.lvl;
            normalEnemy.enemyAtackSpeed = MathF.Round(firstLevelData.atackSpeed * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyAtackDamage = MathF.Round(firstLevelData.atackDamage * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyArmor = MathF.Round(firstLevelData.armor * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyHitPoints = MathF.Round(firstLevelData.hitPoints * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.zlotoZaWalke = MathF.Round(200 * normalEnemy.enemyLvl / player.lvl);
            normalEnemy.xpZaWalke = MathF.Round(normalEnemy.zlotoZaWalke * 6);
            normalEnemy.enemyID = 1;

            return normalEnemy;
        }

        public EnemyModel Elite()
        {
            EnemyModel normalEnemy = new EnemyModel();

            float mnoznikPrzeciwnika = 0.2f;

            normalEnemy.enemyName = "Uzbrojony Goblin";
            normalEnemy.enemyLvl = player.lvl + 1;
            normalEnemy.enemyAtackSpeed = MathF.Round(firstLevelData.atackSpeed * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyAtackDamage = MathF.Round(firstLevelData.atackDamage * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyArmor = MathF.Round(firstLevelData.armor * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyHitPoints = MathF.Round(firstLevelData.hitPoints * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.zlotoZaWalke = MathF.Round(300 * normalEnemy.enemyLvl / player.lvl);
            normalEnemy.xpZaWalke = normalEnemy.zlotoZaWalke;
            normalEnemy.enemyID = 2;

            return normalEnemy;
        }

        public EnemyModel EliteSecond()
        {
            EnemyModel normalEnemy = new EnemyModel();

            float mnoznikPrzeciwnika = 0.3f;

            normalEnemy.enemyName = "Gobliński Szaman";
            normalEnemy.enemyLvl = player.lvl + 1;
            normalEnemy.enemyAtackSpeed = MathF.Round(firstLevelData.atackSpeed * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyAtackDamage = MathF.Round(firstLevelData.atackDamage * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyArmor = MathF.Round(firstLevelData.armor * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyHitPoints = MathF.Round(firstLevelData.hitPoints * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.zlotoZaWalke = MathF.Round(400 * normalEnemy.enemyLvl / player.lvl);
            normalEnemy.xpZaWalke = MathF.Round(normalEnemy.zlotoZaWalke * mnoznikPrzeciwnika);
            normalEnemy.enemyID = 3;

            return normalEnemy;
        }

        public EnemyModel Titan()
        {
            EnemyModel normalEnemy = new EnemyModel();

            float mnoznikPrzeciwnika = 0.4f;

            normalEnemy.enemyName = "Władca Goblinów";
            normalEnemy.enemyLvl = player.lvl + 3;
            normalEnemy.enemyAtackSpeed = MathF.Round(firstLevelData.atackSpeed * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyAtackDamage = MathF.Round(firstLevelData.atackDamage * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyArmor = MathF.Round(firstLevelData.armor * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.enemyHitPoints = MathF.Round(firstLevelData.hitPoints * mnoznikPrzeciwnika * player.lvl);
            normalEnemy.zlotoZaWalke = MathF.Round(800 * normalEnemy.enemyLvl / player.lvl);
            normalEnemy.xpZaWalke = MathF.Round(normalEnemy.zlotoZaWalke * 0.05f);
            normalEnemy.enemyID = 4;

            return normalEnemy;
        }

        //Łączy model wybranego przeciwnika z modelem gracza, dzięki czemu oba modele można używać w jednym widoku
        public PlayerAndEnemy PolaczObaModele(EnemyModel enemy, PlayerModel player)
        {
            PlayerAndEnemy playerAndEnemy = new PlayerAndEnemy();

            //Enemy
            playerAndEnemy.enemyID = enemy.enemyID;
            playerAndEnemy.enemyName = enemy.enemyName;
            playerAndEnemy.enemyLvl = enemy.enemyLvl;
            playerAndEnemy.enemyAtackSpeed = enemy.enemyAtackSpeed;
            playerAndEnemy.enemyAtackDamage = enemy.enemyAtackDamage;
            playerAndEnemy.enemyArmor = enemy.enemyArmor;
            playerAndEnemy.enemyHitPoints = enemy.enemyHitPoints;
            playerAndEnemy.zlotoZaWalke = enemy.zlotoZaWalke;
            playerAndEnemy.xpZaWalke = enemy.xpZaWalke;

            //player
            playerAndEnemy.klasa = player.klasa;
            playerAndEnemy.name = player.name;
            playerAndEnemy.lvl = player.lvl;
            playerAndEnemy.atackSpeed = player.atackSpeed;
            playerAndEnemy.atackDamage = player.atackDamage;
            playerAndEnemy.armor = player.armor;
            playerAndEnemy.hitPoints = player.hitPoints;
            playerAndEnemy.zloto = player.zloto;

            return playerAndEnemy;
        }

        //Sprawdza czyja tura i wywołuje wykonanie ataku
        public void wykonajAtak(int id)
        {
            if (playerAndEnemy.atackSpeed >= playerAndEnemy.enemyAtackSpeed)
            {
                atakGracza();
                playerAndEnemy.enemyAtackSpeed += enemyList.FirstOrDefault(x => x.enemyID == id).enemyAtackSpeed;
                MathF.Round(playerAndEnemy.enemyAtackSpeed);
            }
            else
            {
                atakPrzeciwnika();
                playerAndEnemy.atackSpeed += player.atackSpeed;
                MathF.Round(playerAndEnemy.enemyAtackSpeed);
            }
        }

        //Atak gracza
        public void atakGracza()
        {
            playerAndEnemy.enemyHitPoints -= playerAndEnemy.atackDamage - 0.2f * playerAndEnemy.enemyArmor;
            MathF.Round(playerAndEnemy.enemyHitPoints);

            listaAtakow.Add(playerAndEnemy.enemyName + " otrzymał: " + (playerAndEnemy.atackDamage - 0.2f * playerAndEnemy.enemyArmor) + " obrażeń!");
            listaAtakow.Add(playerAndEnemy.enemyName + ": " + playerAndEnemy.enemyHitPoints + "HP");
        }

        //Atak przeciwnika
        public void atakPrzeciwnika()
        {
            playerAndEnemy.hitPoints -= playerAndEnemy.enemyAtackDamage - 0.2f * playerAndEnemy.armor;
            MathF.Round(playerAndEnemy.hitPoints);

            listaAtakow.Add(playerAndEnemy.name + " otrzymał: " + (playerAndEnemy.enemyAtackDamage - 0.2f * playerAndEnemy.armor) + " obrażeń!");
            listaAtakow.Add(playerAndEnemy.name + ": " + playerAndEnemy.hitPoints + "HP");
        }

        //Sprawdza czy osiągnięto następny poziom, ustawia go i aktualizuje statystyki
        public void sprawdzCzyNextLvl()
        {
            if (player.xp >= player.lvl * 0.3 * 1000)
            {
                player.lvl++;
                playerAndEnemy.lvl++;
                player.hitPoints += 150;
                player.atackSpeed += 0.5f;
                player.atackDamage += 25;
            }
        }
    }
}
