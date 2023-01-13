using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Course.FundamentosBasicos.EnumMov;

namespace Course
{
    public class Conversiones : MonoBehaviour
    {
        private void Start()
        {
            //Conversion(Cast)
            int myCastInt = (int)2.55f;
            Collider myCollider = GetComponent<Collider>();
            BoxCollider myBoxCollider;

            myBoxCollider = (BoxCollider)myCollider;
            myBoxCollider = myCollider as BoxCollider;

            //Conversion(Parse)
            string myStringint = "2";
            int myIntParsed;

            myIntParsed = int.Parse(myStringint);

            bool resultParsed = int.TryParse(myStringint, out myIntParsed);

            //Conversion(Enum)
            string myStringEnum = "Fire";

            AttackType myEnum;
            myEnum = (AttackType)System.Enum.Parse(typeof(AttackType), myStringEnum);
        }
    }
        
}
