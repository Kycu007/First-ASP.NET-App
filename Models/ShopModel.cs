using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MargonemByKycU.Models
{
    public class ShopModel
    {
        [DisplayName("Szybkość: ")]
        public float atackSpeedUpg { get; set; }
        [DisplayName("Cena: ")]
        public float atackSpeedCena { get; set; }


        [DisplayName("Obrażenia: ")]
        public float atackDamageUpg { get; set; }
        [DisplayName("Cena: ")]
        public float atackDamageCena { get; set; }


        [DisplayName("Pancerz: ")]
        public float armorUpg { get; set; }
        [DisplayName("Cena: ")]
        public float armorCena { get; set; }


        [DisplayName("Życie: ")]
        public float hitPointsUpg { get; set; }
        [DisplayName("Cena: ")]
        public float hitPointsCena { get; set; }

        //Id kupowanego produktu
        public int id { get; set; }
    }
}
