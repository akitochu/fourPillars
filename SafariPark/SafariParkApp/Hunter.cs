using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{

    public class Hunter : Person, IShootable
    {
        private IShootable _shooter;
        //private string _camera;
        public IShootable Shooter { get { return _shooter; } set {_shooter = value; } }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName) 
        {
            Shooter = shooter;
        }
        public string Shoot()
        {
            return $"{GetFullName()}: {Shooter.Shoot()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {Shooter}";
        }

    }
}
