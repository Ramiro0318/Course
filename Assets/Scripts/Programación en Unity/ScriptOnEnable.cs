using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.ProgramacionUnity
{
    public class ScriptOnEnable : MonoBehaviour
    {
        private void OnEnable()
        {
            Debug.Log("OnEnable");
        }

        private void OnDisable()
        {
            Debug.Log("OnDisable");
        }

        private void OnDestroy()
        {
            Debug.Log("OnDesrtoy");
        }
    }
}
