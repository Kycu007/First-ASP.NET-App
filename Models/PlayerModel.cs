using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MargonemByKycU.Models
{
    //Tworzony tylko raz (jak na razie) a następnie modyfikowany podczas zdobywania lvla (tylko hp) i za złoto (kupowanie bonusów)
    public class PlayerModel
    {
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
    }
}
