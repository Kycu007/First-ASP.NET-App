using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MargonemByKycU.Models
{
    public class PlayerAndEnemy
    {
        //Tworzony na potrzebę walki, ponieważ do widoku można używać tylko jednego modelu
        //Enemy ==========================================================================================
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


        //Player ============================================================================================

        [Required]
        [DisplayName("Klasa Postaci")]
        public string klasa { get; set; }
        [Required]
        [DisplayName("Nazwa Postaci")]
        public string name { get; set; }
        [DisplayName("Poziom Postaci")]
        public float lvl { get; set; }

        [DisplayName("Szybkość Ataku")]
        public float atackSpeed { get; set; }
        [DisplayName("Obrażenia")]
        public float atackDamage { get; set; }
        [DisplayName("Pancerz")]
        public float armor { get; set; }
        [DisplayName("Życie")]
        public float hitPoints { get; set; }
        [DisplayName("Złoto")]
        public float zloto { get; set; }
        [DisplayName("Punkty XP")]
        public float xp { get; set; }
        public IList<string> listaAtakow { get; set; }
    }
}
