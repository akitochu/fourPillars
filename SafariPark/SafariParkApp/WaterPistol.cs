using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand)
        {
            _brand = brand;
        }

        public override string Shoot()
        {
            return $"Splash!! {base.Shoot()} Shooting a {this.ToString()} - {_brand}";
        }
    }
}
