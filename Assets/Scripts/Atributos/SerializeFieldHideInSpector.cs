using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.Atributos
{
    public class SerializeFieldHideInSpector : MonoBehaviour
    {
        [SerializeField]
        private bool canShot;

        //[HideInInspector]
        public bool canRun;
        
    }
}
