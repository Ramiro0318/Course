using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace Course.InterfacesYGenerics
{
    public class Door : MonoBehaviour,IInteractable
    {
        public void Interact() {

            Debug.Log("Interaction Door");
        }

        /*public void OpenDoor() 
        {
            Debug.Log("Interaction: Door");
        
        }*/
    }
}
