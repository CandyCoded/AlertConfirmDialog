// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

#import <Foundation/Foundation.h>
#import <AVFoundation/AVFoundation.h>
#import <UIKit/UIKit.h>

extern "C"
{

    void Alert(const char* title, const char* message, const char* okButtonLabel) {

        NSString* titleString = [NSString stringWithUTF8String: title];
        NSString* messageString = [NSString stringWithUTF8String: message];

        NSString* okButtonLabelString = [NSString stringWithUTF8String: okButtonLabel];

        UIAlertController* alert = [UIAlertController alertControllerWithTitle:titleString
                                                                       message:messageString
                                                                preferredStyle:UIAlertControllerStyleAlert];

        UIAlertAction* defaultAction = [UIAlertAction actionWithTitle:okButtonLabelString style:UIAlertActionStyleDefault
                                                              handler:^(UIAlertAction * action) {

                                                                  UnitySendMessage("AlertConfirmDialog", "Callback", "OK");

                                                              }];
        [alert addAction:defaultAction];

        UIViewController* view = [[[UIApplication sharedApplication] keyWindow] rootViewController];

        [view presentViewController:alert animated:YES completion:nil];

    }

    void Confirm(const char* title, const char* message, const char* okButtonLabel, const char* cancelButtonLabel) {

        NSString* titleString = [NSString stringWithUTF8String: title];
        NSString* messageString = [NSString stringWithUTF8String: message];

        NSString* okButtonLabelString = [NSString stringWithUTF8String: okButtonLabel];
        NSString* cancelButtonLabelString = [NSString stringWithUTF8String: cancelButtonLabel];

        UIAlertController* alert = [UIAlertController alertControllerWithTitle:titleString
                                                                       message:messageString
                                                                preferredStyle:UIAlertControllerStyleAlert];

        UIAlertAction* defaultAction = [UIAlertAction actionWithTitle:okButtonLabelString style:UIAlertActionStyleDefault
                                                              handler:^(UIAlertAction * action) {

                                                                  UnitySendMessage("AlertConfirmDialog", "Callback", "OK");

                                                              }];
        [alert addAction:defaultAction];

        UIAlertAction* cancelAction = [UIAlertAction actionWithTitle:cancelButtonLabelString style:UIAlertActionStyleCancel
                                                             handler:^(UIAlertAction * action) {

                                                                 UnitySendMessage("AlertConfirmDialog", "Callback", "CANCEL");

                                                             }];
        [alert addAction:cancelAction];
        [alert setPreferredAction:defaultAction];

        UIViewController* view = [[[UIApplication sharedApplication] keyWindow] rootViewController];

        [view presentViewController:alert animated:YES completion:nil];

    }

}