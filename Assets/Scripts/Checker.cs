using NativePlugin.Base;
using UnityEngine;

#if !UNITY_EDITOR && UNITY_IOS
using NativePlugin.IOS;
#endif

namespace Sample
{
    public static class Checker
    {
#if !UNITY_EDITOR && UNITY_IOS
        private static IChecker checker = new CheckerForIOS();
#else
        private static IChecker checker = null;
#endif

        public static void Check()
        {
            Debug.Log("Checker is null? => " + (checker == null));
            checker?.Check();
        }
    }
}