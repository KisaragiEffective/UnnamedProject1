using KisaragiLockExpression.Runtime;
using UnityEditor;
using UnityEngine;

namespace KisaragiLockExpression.Editor
{
    [CustomEditor(typeof(FxExpressionFixComponent))]
    public class FxExpressionFixEditor: UnityEditor.Editor
    {
        SerializedProperty vrcAvatarDescriptor;
        void OnEnable()
        {
            vrcAvatarDescriptor = serializedObject.FindProperty(nameof(FxExpressionFixComponent._vrcAvatarDescriptor));
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(vrcAvatarDescriptor, new GUIContent("VRC Avatar Descriptor"));
            if (vrcAvatarDescriptor == null)
            {
                // Debug.Log(vrcAvatarDescriptor);
                EditorGUILayout.HelpBox("This component requires VRC Avatar Descriptor", MessageType.Error);
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}