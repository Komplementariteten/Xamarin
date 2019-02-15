// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace App1
{
    [Register ("FirstViewController")]
    partial class FirstViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Number { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField RandomNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider Slider { get; set; }

        [Action ("On_DoStuffButtonPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void On_DoStuffButtonPressed (UIKit.UIButton sender);

        [Action ("Slider_OnSlidingEnd:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Slider_OnSlidingEnd (UIKit.UISlider sender);

        void ReleaseDesignerOutlets ()
        {
            if (Number != null) {
                Number.Dispose ();
                Number = null;
            }

            if (RandomNumber != null) {
                RandomNumber.Dispose ();
                RandomNumber = null;
            }

            if (Slider != null) {
                Slider.Dispose ();
                Slider = null;
            }
        }
    }
}