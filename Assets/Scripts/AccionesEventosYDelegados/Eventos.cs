using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Course.AccionesEventosDelegados
{
    public class Eventos : MonoBehaviour
    {

        //Event
        public delegate void MyDelegateEvent();
        //public MyDelegateEvent myDelegateEventVar;    //Delegate
        public event MyDelegateEvent myEventVar;        //eveneto


        //Unity event
        public UnityEvent myUnityEventVar;
        public UnityEvent<bool> myUnityEventOneParamVar;
        public UnityEvent<bool, int, string> myUnityEventThreeParamVar;

        private void Start() {
            //Events
            myEventVar += PrintMessage;

            //myEventVar();
            //myEventVar.Invoke();

            //Unity Events
            myUnityEventVar.AddListener(PrintMessage);  //+=
            myUnityEventVar.RemoveListener(PrintMessage); //-=
            
            
            myUnityEventVar.Invoke();
            myUnityEventOneParamVar.Invoke(true);
            myUnityEventThreeParamVar.Invoke(true, 3, "asada");
        }

        private void PrintMessage() {
            Debug.Log("Hello World");
        }

    }
}
