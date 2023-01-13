using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Course.CustomEditor
{
    public class Item : MonoBehaviour
    {
        public ItemSO data;
        [Space]
        public Image itemImg;
        public TextMeshPro itemTitleText;
        public TextMeshPro itemPriceText;

        private void Start()
        {
            Consume();
        }

        public void Consume() {
            itemImg.sprite = data.sprite;
            itemTitleText.text = data.title;
            itemPriceText.text = data.GetPrice();
        }
    }
}
