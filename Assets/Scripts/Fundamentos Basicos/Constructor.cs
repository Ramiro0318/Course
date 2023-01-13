using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class Constructor : MonoBehaviour
    {
        private void Start()
        {
            Weapon myWeapon = new Weapon(100);

            myWeapon.Shoot();
        }

        public class Weapon {

            public int ammo;

            public Weapon(int ammo)
            {
                this.ammo = ammo;
            }
            public void Shoot() {
            
            }
        }
    }
}
