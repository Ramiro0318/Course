using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

namespace Course.AccionesEventosDelegados
{
    public class Action : MonoBehaviour
    {

        public System.Action myActionVar;  //Sin System en el namespace
        public UnityAction myUnityActionVar;


        public Action<int> myActionOneParamVar;
        public UnityAction<int> myUnityActionOneParamVar;


        public Action<int, bool, string> myActionThreeParamVar;
        public UnityAction<int, bool, string> myUnityActionThreeParamVar;
      

        private void Start()
        {
            //Action
            myActionVar = PrintMessage;
            myActionVar += PrintMessage;
            myActionVar.Invoke();

            //UnityAction
            myUnityActionVar = PrintMessage;
            myUnityActionVar += PrintMessage;
            myUnityActionVar.Invoke();
        }

        private void PrintMessage() { 
        

        }
    }
}
