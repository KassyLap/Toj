using Android.Content.Res;
using Google.Android.Material.BottomNavigation;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using Microsoft.Maui.Platform;


namespace Toj.Platforms.Android
{
    public class CustomeShell : ShellRenderer
    {
        public CustomeShell()
        {

        }

        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new CustomeShellBottomViewAppearance();
        }
    }

    public class CustomeShellBottomViewAppearance : IShellBottomNavViewAppearanceTracker
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ResetAppearance(BottomNavigationView bottomView)
        {
            throw new NotImplementedException();
        }

        public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            bottomView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;

            bottomView.ItemIconSize = 70;

            bottomView.SetBackgroundColor(Color.FromRgb(110, 182, 249).ToPlatform());

            bottomView.ItemIconTintList = ColorStateList.ValueOf(Colors.White.ToPlatform());

            bottomView.SetPadding(60, 60, 60, 60);

        }
    }
}


