using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.Foundation;

namespace HelloCollectionView
{
    public partial class HelloCollectionViewViewController : UIViewController
    {
        private UICollectionViewFlowLayout gridLayout;
        private static NSString cellId = new NSString("CollectionViewCell");

        private UICollectionView collectionView;

        public HelloCollectionViewViewController() : base("HelloCollectionViewViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            gridLayout = new UICollectionViewFlowLayout {
                SectionInset = new UIEdgeInsets(20, 20, 20, 20),
                ScrollDirection = UICollectionViewScrollDirection.Horizontal,
                ItemSize = new SizeF(125, 60),
                MinimumLineSpacing = 20.0f,
                MinimumInteritemSpacing = 20.0f // top and bottom padding
            };

            collectionView = new UICollectionView(View.Frame, gridLayout);

            collectionView.RegisterClassForCell(typeof(CollectionViewCell), cellId);

            collectionView.DataSource = new CollectionViewDataSource();

            collectionView.ScrollEnabled = false;

            collectionView.ContentInset = new UIEdgeInsets(100, 0, 140, 0);

            View.AddSubview(collectionView);
        }
    }
}