using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuickImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click(object sender, RoutedEventArgs e)
        {
            var rng = new Random();
            string[] quotes = {"Tiếp tục đi. Tất cả mọi thứ bạn cần sẽ đến với bạn vào thời điểm hoàn hảo.",
                "You have to be at your strongest when you’re feeling at your weakest.",
                "Nhìn vào gương. Đó là sự cạnh tranh của bạn.",
                "Tập trung vào mục tiêu của bạn. Đừng nhìn theo bất kỳ hướng nào ngoài phía trước.",
                "Đau là tạm thời. Thoát. - Lance Armstrong",
                "Chúng ta phải nắm lấy nỗi đau và đốt nó làm nhiên liệu cho cuộc hành trình của chúng ta. - Kenji Miyji",
                "Một vấn đề là một cơ hội để bạn cố gắng hết sức. - Công tước Ellington",
                "Hãy nhớ rằng đó chỉ là một ngày tồi tệ, không phải là một cuộc sống tồi tệ.",
                "Nó không hoàn hảo. Đó là về nỗ lực. - Jillian Michaels",
                "Hãy tin rằng bạn có thể và bạn đang ở giữa chừng. - Theodore Roosevelt"
    };
            int i = rng.Next(quotes.Length);
            string quote = quotes[i];

            MessageBox.Show(quote); ;
        }

        private void image_Click(object sender, RoutedEventArgs e)
        {
            string[] quotes = {"Tiếp tục đi. Tất cả mọi thứ bạn cần sẽ đến với bạn vào thời điểm hoàn hảo.",
                "You have to be at your strongest when you’re feeling at your weakest.",
                "Nhìn vào gương. Đó là sự cạnh tranh của bạn.",
                "Tập trung vào mục tiêu của bạn. Đừng nhìn theo bất kỳ hướng nào ngoài phía trước.",
                "Đau là tạm thời. Thoát. - Lance Armstrong",
                "Chúng ta phải nắm lấy nỗi đau và đốt nó làm nhiên liệu cho cuộc hành trình của chúng ta. - Kenji Miyji",
                "Một vấn đề là một cơ hội để bạn cố gắng hết sức. - Công tước Ellington",
                "Hãy nhớ rằng đó chỉ là một ngày tồi tệ, không phải là một cuộc sống tồi tệ.",
                "Nó không hoàn hảo. Đó là về nỗ lực. - Jillian Michaels",
                "Hãy tin rằng bạn có thể và bạn đang ở giữa chừng. - Theodore Roosevelt";
            Random img = new Random();
            int ran = img.Next(0, 10);
            var uri = new Uri("/Image", UriKind.Relative);
            bao.Source = new BitmapImage(uri);
        }
    }
}
