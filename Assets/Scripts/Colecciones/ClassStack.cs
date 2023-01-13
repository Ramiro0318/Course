using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.Coleciones
{
    public class ClassStack : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Stack")]
        public Stack<GameObject> CardsStack;

        private void Start()
        {
            //Init
            CardsStack = new Stack<GameObject>();

            //add
            for (int i = 0; i < myContent.Length; i++)
            {
                CardsStack.Push(myContent[i]);
            }
                //return first and remove
                GameObject myGameObjectPop = CardsStack.Pop();

                //return first
                GameObject myGameObjectPeek = CardsStack.Peek();

                //contains
                bool contains = CardsStack.Contains(myGameObjectPeek);

                //amount
                int amount = CardsStack.Count;

                //clear
                CardsStack.Clear();
            
        }
    }
}
