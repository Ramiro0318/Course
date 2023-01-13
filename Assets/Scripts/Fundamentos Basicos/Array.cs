using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class Array : MonoBehaviour
    {
        public int[] enemyId = {100, 200, 300, 400};

        private void Start()
        {
            int myId = enemyId[0]; 
        }
    }
}
