using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.FundamentosBasicos
{
    public class EnumMov : MonoBehaviour
    {
        public enum AttackType
        {
            None, Fire, Ice, Sword, Punch
        }

        public AttackType attackTypeEnum  = AttackType.Ice;

    }
}
