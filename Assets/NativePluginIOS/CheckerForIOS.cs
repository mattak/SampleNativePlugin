using System.Runtime.InteropServices;
using NativePlugin.Base;
using UnityEngine;

namespace NativePlugin.IOS
{
    public class CheckerForIOS : IChecker
    {
        [DllImport("__Internal", EntryPoint = "check")]
        private static extern void CheckInternal();

        public void Check()
        {
            Debug.Log("CheckerForIOS.Check");
            CheckInternal();
        }
    }
}