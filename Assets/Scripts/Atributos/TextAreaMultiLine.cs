using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.Atributos
{
    public class TextAreaMultiLine : MonoBehaviour
    {
        [TextArea(1,2)]
        public string Text;
        
        [Multiline(6)]
        public string Note;
    }
}
