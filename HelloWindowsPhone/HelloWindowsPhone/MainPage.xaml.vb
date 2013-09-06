Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
        TextBox1.Text = "Hello World"
        TextBlock1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button1.Click
        TextBlock1.Text = TextBox1.Text
    End Sub

    Private Sub HyperlinkButton1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles HyperlinkButton1.Click
        NavigationService.Navigate(New Uri("/SecondPage.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
