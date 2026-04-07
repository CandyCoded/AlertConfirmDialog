// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

package com.candycoded.alertconfirmdialog;

import android.app.Activity;
import android.content.Context;
import android.app.AlertDialog;
import android.os.Bundle;

import com.unity3d.player.UnityPlayer;

public class AndroidPlugin {

    private Activity activity;

    public AndroidPlugin(Context context) {
        this.activity = (Activity) context;
    }

    public void Alert(String title, String message, String okButtonLabel) {

        activity.runOnUiThread(() -> {

            AlertDialog.Builder alertDialog = new AlertDialog.Builder(activity);

            alertDialog.setTitle(title);
            alertDialog.setMessage(message);
            alertDialog.setPositiveButton(okButtonLabel, (dialog, which) -> {

                dialog.dismiss();

                UnityPlayer.UnitySendMessage("AlertConfirmDialog", "Callback", "OK");

            });
            alertDialog.create();
            alertDialog.show();

        });

    }

    public void Confirm(String title, String message, String okButtonLabel, String cancelButtonLabel) {

        activity.runOnUiThread(() -> {

            AlertDialog.Builder alertDialog = new AlertDialog.Builder(activity);

            alertDialog.setTitle(title);
            alertDialog.setMessage(message);
            alertDialog.setPositiveButton(okButtonLabel, (dialog, which) -> {

                dialog.dismiss();

                UnityPlayer.UnitySendMessage("AlertConfirmDialog", "Callback", "OK");

            });
            alertDialog.setNegativeButton(cancelButtonLabel, (dialog, which) -> {

                dialog.dismiss();

                UnityPlayer.UnitySendMessage("AlertConfirmDialog", "Callback", "CANCEL");

            });
            alertDialog.create();
            alertDialog.show();

        });

    }

}
