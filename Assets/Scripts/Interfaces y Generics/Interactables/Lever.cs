using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.InterfacesYGenerics
{
    public class Lever : MonoBehaviour, IInteractable
    {
        public void Interact() {
            Debug.Log("Interaction Lever");
        }

        /* public void UseLever()
        {
            Debug.Log("Interaction: Lever");
        }*/
    }
}
