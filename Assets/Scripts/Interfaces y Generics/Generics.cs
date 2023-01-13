using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.InterfacesYGenerics
{
    public class Generics : MonoBehaviour
    {
        public List<int> numbers;
        public List<string> words;

        private void Start()
        {
            numbers = ReverseList(numbers);
            words = ReverseList(words);
        }

        private List<T> ReverseList<T>(List<T> ListToReverse) { 
        
        List<T> reversedlist = new List<T>();
            for (int i = ListToReverse.Count-1; i >= 0; i--)
            {
                reversedlist.Add(ListToReverse[i]);
            }
            return reversedlist;
        }
    }
}
