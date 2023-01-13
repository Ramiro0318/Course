using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.EstructurasDeControl
{
    public class ForEachWhile : MonoBehaviour
    {
        public int[] weaponArray;

        private void CheckWeaponAmmo() {
            for (int i = 0; i < weaponArray.Length; i++) {
                Debug.Log($"index {i} - Ammo: {weaponArray[i]}");
            }

            foreach (int weaponAmmo in weaponArray ){
                Debug.Log($"Index ? - Ammo: {weaponAmmo}");
            }


        }
        

        private IEnumerator Fade() {

            float alpha = 1;
            
            while (alpha > 0) {

                alpha -= Time.deltaTime * 1;

                    yield return null;
            }
            
        }
    }
}
