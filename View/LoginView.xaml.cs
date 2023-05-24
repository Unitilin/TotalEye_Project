using System.Windows;
using System.Windows.Input;

namespace TotalEye.View
{
	public partial class LoginView : Window
	{
		public LoginView()
		{
			InitializeComponent();
		}

		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
				this.DragMove();
		}

		private void btnMinimize_Click(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void txtUsers_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{

		}

		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
