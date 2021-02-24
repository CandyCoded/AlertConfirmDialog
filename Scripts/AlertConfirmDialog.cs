// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using UnityEngine;

namespace CandyCoded.AlertConfirmDialog
{

    public static class AlertConfirmDialog
    {

        private static UnitySendMessageEventHandler _unitySendMessageEventHandler;

        public static void Alert(string title, string message, Action okButtonCallback = null,
            string okButtonLabel = "OK")
        {

            if (_unitySendMessageEventHandler == null)
            {

                var gameObject = new GameObject("AlertConfirmDialog", typeof(UnitySendMessageEventHandler));

                gameObject.TryGetComponent(out _unitySendMessageEventHandler);

            }

            _unitySendMessageEventHandler.ok = okButtonCallback;

#if UNITY_IOS && !UNITY_EDITOR
            iOS.AlertConfirmDialog.Alert(title, message, okButtonLabel);
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.AlertConfirmDialog.Alert(title, message, okButtonLabel);
#endif

        }

        public static void Confirm(string title, string message, Action okButtonCallback = null,
            Action cancelButtonCallback = null,
            string okButtonLabel = "OK", string cancelButtonLabel = "Cancel")
        {

            if (_unitySendMessageEventHandler == null)
            {

                var gameObject = new GameObject("AlertConfirmDialog", typeof(UnitySendMessageEventHandler));

                gameObject.TryGetComponent(out _unitySendMessageEventHandler);

            }

            _unitySendMessageEventHandler.ok = okButtonCallback;

            _unitySendMessageEventHandler.cancel = cancelButtonCallback;

#if UNITY_IOS && !UNITY_EDITOR
            iOS.AlertConfirmDialog.Confirm(title, message, okButtonLabel, cancelButtonLabel);
#elif UNITY_ANDROID && !UNITY_EDITOR
            Android.AlertConfirmDialog.Confirm(title, message, okButtonLabel, cancelButtonLabel);
#endif

        }

    }

}
