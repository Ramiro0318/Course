using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace UnityEngine.Tools
{
    public static class UnityTools
    {
        public static RectTransform GetRectTransform(this Transform t) {
            return t as RectTransform;
        }
        
    }
}
