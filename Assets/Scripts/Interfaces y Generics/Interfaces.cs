using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.InterfacesYGenerics
{
    public interface IInteractable {
        void Interact();
    }
    public class Interfaces : MonoBehaviour
    {
        public GameObject[] myInteractables;

        private void Start()
        {
            for (int i = 0; i < myInteractables.Length; i++)
            {
                IInteractable interactable = myInteractables[i].GetComponent<IInteractable>();
                interactable.Interact();
            }    
        }

        /* public Chest InteractableChest;
         public Door InteractableDoor;
         public Lever InteractableLever;

         private void Start()
         {
             InteractableChest.OpenChest();
             InteractableDoor.OpenDoor();
             InteractableLever.UseLever();
         }*/
    }
}
