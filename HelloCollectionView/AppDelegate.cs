using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloCollectionView
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;

        UICollectionViewFlowLayout gridLayout;

        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            window = new UIWindow (UIScreen.MainScreen.Bounds);

            window.RootViewController = new HelloCollectionViewViewController();

            window.MakeKeyAndVisible ();

            return true;
        }
    }

    public class CollectionViewDataSource : UICollectionViewDataSource
    {
        static NSString cellId = new NSString("CollectionViewCell");

        public override int GetItemsCount(UICollectionView collectionView, int section)
        {
            return 8;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (CollectionViewCell)collectionView.DequeueReusableCell(cellId, indexPath);

            return cell;
        }
    }

    public class GridLayout : UICollectionViewFlowLayout
    {
        public override bool ShouldInvalidateLayoutForBoundsChange (RectangleF newBounds)
        {
            return true;
        }
    }
}