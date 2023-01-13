using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.InterfacesYGenerics
{
    public class Chest : MonoBehaviour, IInteractable
    {
        public void Interact() {
            Debug.Log("Interaction: Chest");
        }

        /* public void OpenChest() 
        {
            Debug.Log("Interaction: Chest");
        }*/
    }
}
