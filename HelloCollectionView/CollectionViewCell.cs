using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloCollectionView
{
    public class CollectionViewCell : UICollectionViewCell
    {
        [Export ("initWithFrame:")]
        public CollectionViewCell(RectangleF frame) : base (frame)
        {
            var f = new RectangleF(0, 0, 125, 60);

            BackgroundView = new UIView();

            SelectedBackgroundView = new UIView();

            var button = new UIButton(UIButtonType.System);

            button.SetTitle("Press Me!", UIControlState.Normal);

            button.Layer.BorderColor = UIColor.Orange.CGColor;
            button.Layer.BorderWidth = 2.0f;
            button.Layer.CornerRadius = 10.0f;

            button.BackgroundColor = UIColor.White;

            button.TouchDown += (sender, e) => Console.WriteLine("TouchDown fired!");
            button.TouchUpInside += (sender, e) => Console.WriteLine("TouchUp fired!");

            ContentView.AddSubview(button);

            button.Center = ContentView.Center;

            button.Bounds = ContentView.Bounds;
        }
    }
}