using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;

namespace Course.CustomEditor
{
    [UnityEditor.CustomEditor(typeof(Item))]
    public class ItemEditor : Editor
    {
        private Item currentTarget;


        public override void OnInspectorGUI()
        {

            base.OnInspectorGUI();
            currentTarget = (Item)target;
            GUILayout.Space(10);

            if (IsTargetReady()) {

                if (EditorApplication.isPlaying) {
                    GUILayout.Box($" Data: Curret{currentTarget.data.title} ({currentTarget.data.price})");
                }
                EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);

                string button = EditorApplication.isPlaying ? "Consume (Only in editor mode)" : "Consume";

                if (GUILayout.Button(button, GUILayout.Height(30)))
                {
                    currentTarget.Consume();
                }
                EditorGUI.EndDisabledGroup();
            } 
            else {
                EditorGUILayout.HelpBox($"Error : {GetErrorMessage()}", MessageType.Error);
            }

             bool IsTargetReady() {
                return currentTarget.data &&
                       currentTarget.itemImg &&
                       currentTarget.itemTitleText &&
                       currentTarget.itemPriceText;
             }

           string GetErrorMessage() {
                if (!currentTarget.data) return "Data Empty!";
                if (!currentTarget.itemImg) return "Image reference Empty!";   
                if (!currentTarget.itemTitleText) return "Title reference Empty!";   
                if (!currentTarget.itemPriceText) return "Price reference Empty!";

                return "Unknown";
           }

        } 
    }
}
