using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Sprint0GUIProgramming
{
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
    }

    private void SubmitButton_Click(object sender, RoutedEventArgs e) {
      string name = Name.Text;
      string phone = Phone.Text;
      string email = Email.Text;
      string message = Message.Text;
      string communicationMethod = (PhonePreferred.IsChecked ?? false) ? "phone" : "email";
      string isNewsletterChecked = (WantsNewsletter.IsChecked ?? false) ? "yes" : "no";

      Form.Children.Clear();
       
      TextBlock submissionPageTitle = new TextBlock();
      submissionPageTitle.Text = "Thank you for contacting us!";
      submissionPageTitle.FontSize = 20;
      submissionPageTitle.TextAlignment = TextAlignment.Center;
      submissionPageTitle.SetValue(Grid.RowProperty, 1);
      submissionPageTitle.SetValue(Grid.ColumnProperty, 1);
      Form.Children.Add(submissionPageTitle);

      TextBlock submissionPageDetails = new TextBlock();
      submissionPageDetails.Text = $"Name: {name}\nPhone: {phone}\nEmail: {email}\nMessage: {message}\nPreferred communication method: {communicationMethod}\nNewsletter sign-up: {isNewsletterChecked}";
      submissionPageDetails.FontSize = 16;
      submissionPageDetails.SetValue(Grid.RowProperty, 2);
      submissionPageDetails.SetValue(Grid.RowSpanProperty, 7);
      submissionPageDetails.SetValue(Grid.ColumnProperty, 1);
      Form.Children.Add(submissionPageDetails);
    }
  }
}