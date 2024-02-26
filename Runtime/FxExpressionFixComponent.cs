using System;
using UnityEngine;
using VRC.SDK3.Avatars.Components;

namespace KisaragiLockExpression.Runtime
{
    [DisallowMultipleComponent]
    public class FxExpressionFixComponent: MonoBehaviour
    {
        public VRCAvatarDescriptor _vrcAvatarDescriptor;
        internal bool attached = false;
        
        private void OnGUI()
        {
            attached = this.gameObject.TryGetComponent<VRCAvatarDescriptor>(out _vrcAvatarDescriptor);
        }
    }
}