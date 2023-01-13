using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.ProgramacionUnity
{
    public class VisibleInvisible : MonoBehaviour
    {

        private void OnBecameVisible()
        {
            Debug.Log("Visible");
        }

        private void OnBecameInvisible()
        {
            Debug.Log("Invisble");
        }
    }
}
