using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace Course.SOLID.After
{
    public class InputMouse : InputHandler
    {
        public float sensitivity = 1;
        public override float GetAxisHorizontal()
        {
            return Input.GetAxis("Mouse X") * sensitivity;
        }
    }
}
