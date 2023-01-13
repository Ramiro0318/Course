using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tools;

namespace Course.OrganizacionProyecto
{
    public class Helper : MonoBehaviour
    {
        private void Start()
        {
            RectTransform test = UnityTools.GetRectTransform(transform);
        }
    }
}
