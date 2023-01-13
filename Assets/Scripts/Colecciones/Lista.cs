using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.Coleciones
{
    public class Lista : MonoBehaviour
    {
        [Header("Content")]

        public int[] myContent;

        [Header("Lista")]

        public List<int> weaponsList;


        private void Start()
        {
            //iniciallizar
            weaponsList = new List<int>();

            //add
            for (int i = 0; i <  myContent.Length; i++)
            {
                weaponsList.Add(myContent[i]);
            }
            weaponsList.AddRange(myContent);
            //remove
            weaponsList.Remove(myContent[2]);
            //read
            int tempValue = weaponsList[2];
            //amount
            int amount = weaponsList.Count;
            //clear
            weaponsList.Clear();
        }
    }
}
