using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.Atributos
{
    public class ContextMenuItem : MonoBehaviour
    {
        [ContextMenu("Execute")]
        private void printExecute() {

            Debug.Log("EXECUTE");
        }

        [ContextMenuItem("Get a Random Scale", "ExecuteRandomScale")]

        public float RandomScale;

        private void ExecuteRandomScale() {

            RandomScale = Random.Range(0, 10f);
        }
    }
}
