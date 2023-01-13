using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.AccionesEventosDelegados
{
    public class Delegante : MonoBehaviour
    {
        //Void
        public delegate void MyDelegate();
        public MyDelegate myDelegateVar;

        //Return
        public delegate int MyDelegateInt(); 
        public MyDelegateInt myDelegateIntVar;

        //Params
        public delegate void MyDelegateOneParam(string myString);
        public MyDelegateOneParam myDelegateOneParamVar;

        //Multicast
        public delegate void MyDelegateMulticast();
        public MyDelegateMulticast myDelegateMulticastVar;

        //Callback
        public delegate void MyDelegateCallback(bool Succes);
        public MyDelegateCallback MyDelegateCallbackVar;

        private void Start()
        {   //Void
            myDelegateVar = PrintMessage;
            myDelegateVar.Invoke();      //myDelegateVar();

            //Return
            myDelegateIntVar = GetWeaponID;
            int myWeapon;
            //myWeapon = myDelegateIntVar();

            //Params
            myDelegateOneParamVar = PrintMessageWhitValue;
            //myDelegateOneParamVar("World");

            //Multicast
            myDelegateMulticastVar += PrintMessage;
            myDelegateMulticastVar += ChangeWeapon;
            myDelegateMulticastVar += Health;
            // Para desuscribirse     //myDelegateMulticastVar -= Health;
            myDelegateMulticastVar();

            //Callback
            MyDelegateCallbackVar = RequestCompleted;
            RequestConection(MyDelegateCallbackVar);
        }

        private void PrintMessage() {

            Debug.Log("Hello World!");
        }

        private int GetWeaponID() {
            return 5;
        }

        private void PrintMessageWhitValue(string message)
        {
            Debug.Log($"Hello {message}!");

        }

        private void ChangeWeapon() { 
            Debug.Log("change Weapon!");
        }
        private void Health()
        {
            Debug.Log("Heal!");
        }

        bool conecctionReady = true;

        private void RequestConection(MyDelegateCallback callback) {
            if (conecctionReady)
            {
                callback(true);
            }
            else { callback(false); }
        }

        private void RequestCompleted(bool succes)
        {
            Debug.Log($"Conecction ready {succes}");


        }
    }
}
