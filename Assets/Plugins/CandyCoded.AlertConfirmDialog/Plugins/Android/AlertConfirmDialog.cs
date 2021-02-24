// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace CandyCoded.AlertConfirmDialog.Android
{

    public static class AlertConfirmDialog
    {

        private static AndroidJavaObject _androidPlugin;

        private static AndroidJavaObject androidPlugin
        {
            get
            {
                if (_androidPlugin != null)
                {
                    return _androidPlugin;
                }

                var javaUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

                var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

                _androidPlugin =
                    new AndroidJavaObject("com.candycoded.alertconfirmdialog.AndroidPlugin", currentActivity);

                return _androidPlugin;
            }
        }

        public static void Alert(string title, string message, string okButtonLabel)
        {
            androidPlugin.Call("Alert", title, message, okButtonLabel);
        }

        public static void Confirm(string title, string message, string okButtonLabel,
            string cancelButtonLabel)
        {
            androidPlugin.Call("Confirm", title, message, okButtonLabel, cancelButtonLabel);
        }

    }

}
