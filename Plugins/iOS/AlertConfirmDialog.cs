// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Runtime.InteropServices;

namespace CandyCoded.AlertConfirmDialog.iOS
{

    public static class AlertConfirmDialog
    {

        [DllImport("__Internal")]
        public static extern void Alert(string title, string message, string okButtonLabel);

        [DllImport("__Internal")]
        public static extern void Confirm(string title, string message, string okButtonLabel,
            string cancelButtonLabel);

    }

}
