namespace gifview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow() { InitializeComponent(); }
        public string[] Files{ get; set; }

        private void button1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.ShowDialog(); //show dialog
            string polku = System.IO.Path.GetDirectoryName(ofd.FileName);
            Files = System.IO.Directory.GetFiles(polku);
            this.DataContext = this;
        }

        private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (App.Args.Length > 0)
            {
                string polku = System.IO.Path.GetDirectoryName(App.Args[0]);
                Files = System.IO.Directory.GetFiles(polku);
                this.DataContext = this;
            }
            else
            {
            }  
            
        }
    }
}
