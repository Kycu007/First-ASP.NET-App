using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MargonemByKycU.Models
{
    public class EnemyModel
    {
        //Tworzony losowo przed walką na podstawie FirstLevelData z odpowiednimi statystykami dla lvla
        public int enemyID { get; set; }
        [DisplayName("Przeciwnik")]
        public string enemyName { get; set; }
        [DisplayName("Poziom")]
        public float enemyLvl { get; set; }
        [DisplayName("Szybkość Ataku")]
        public float enemyAtackSpeed { get; set; }
        [DisplayName("Obrażenia")]
        public float enemyAtackDamage { get; set; }
        [DisplayName("Pancerz")]
        public float enemyArmor { get; set; }
        [DisplayName("Życie")]
        public float enemyHitPoints { get; set; }
        [DisplayName("Złoto Za Walkę")]
        public float zlotoZaWalke { get; set; }
        [DisplayName("Doświadczenie Za Walkę")]
        public float xpZaWalke { get; set; }
    }
}
