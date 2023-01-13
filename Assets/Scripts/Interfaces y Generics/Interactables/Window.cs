using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.InterfacesYGenerics
{
    public class Window : MonoBehaviour, IInteractable
    {
        public void Interact() {
            Debug.Log("Interaction: Window");
        }
    }
}
