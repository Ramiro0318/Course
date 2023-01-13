using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.Coleciones
{
    public class ClassQueue : MonoBehaviour
    {
        [Header("Content")]
        GameObject[] myContent;

        [Header("Queue")]
        public Queue<GameObject> playerQueue;

        private void Start()
        {
            //Init
            playerQueue = new Queue<GameObject>();

            //add
            for (int i = 0; i < myContent.Length; i++)
            {
                playerQueue.Enqueue(myContent[i]);
            }
            //remove
            GameObject myGameObject = playerQueue.Dequeue();

            //contains
            bool Contains = playerQueue.Contains(myGameObject);

            //amount
            int amount = playerQueue.Count;

            //clear
            playerQueue.Clear();
        }
    }
}
