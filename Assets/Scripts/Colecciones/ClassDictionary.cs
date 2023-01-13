using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.Coleciones
{
    public class ClassDictionary : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Dictionary")]
        public Dictionary< string, GameObject> CharacterDictionary;

        private void Start()
        {
            //Init
            CharacterDictionary = new Dictionary< string, GameObject>();

            //add
            for (int i = 0; i < myContent.Length; i++)
            {
                CharacterDictionary.Add(myContent[i].name, myContent[i]); // Orc
            }

            //remove
            CharacterDictionary.Remove("Orc");

            //Contains
            bool containt = CharacterDictionary.ContainsKey("Orc");

            //read
            GameObject myValue = CharacterDictionary["Orc"];

            //amount
            int amount = CharacterDictionary.Count;

            //clear
            CharacterDictionary.Clear();

        }
    }
}
