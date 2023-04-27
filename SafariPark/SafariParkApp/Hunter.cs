using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{

    public class Hunter : Person
    {
        private string _camera;
        public Hunter(string fName, string lName, string camera = "") : base(fName, lName) 
        {
            this._camera = camera;
        }
        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";
        }

    }
}
