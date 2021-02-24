// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using UnityEngine;

namespace CandyCoded.AlertConfirmDialog
{

    public class UnitySendMessageEventHandler : MonoBehaviour
    {

        public Action cancel;

        public Action ok;

        public void Callback(string message)
        {

            switch (message)
            {
                case "OK":
                    ok?.Invoke();

                    break;
                case "CANCEL":
                    cancel?.Invoke();

                    break;
            }

            ok = null;

            cancel = null;

        }

    }

}
