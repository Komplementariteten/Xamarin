using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UIKit;

namespace App1
{
    public partial class FirstViewController : UIViewController
    {
        Task<double> randomRunner;
        public FirstViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void Slider_OnSlidingEnd(UIKit.UISlider sender)
        {
            this.Number.Text = sender.Value.ToString();
        }

        public async void RunNumberUpdate()
        {
            var doubleValue = await randomRunner;
            this.RandomNumber.Text = doubleValue.ToString();
        } 

        partial void On_DoStuffButtonPressed(UIKit.UIButton sender)
        {
            this.randomRunner = Task.Factory.StartNew<double>((controlerObject) => {
                var controler = controlerObject as FirstViewController;
                double num = 0.0;
                if (controler != null)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        num = new Random().NextDouble();
                        Thread.Sleep(600);
                    }
                }
                return num;
            }, this, TaskCreationOptions.LongRunning);
            this.RunNumberUpdate();
        }


    }
}