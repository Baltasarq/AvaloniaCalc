// AvaloniaCalc (c) 2021 Baltasar MIT License <jbgarcia@uvigo.es>


namespace AvaloniaCalc.UI {
    using Avalonia;
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    
    public partial class MessageBox : Window {
        public MessageBox(string msg)
            :this()
        {
            var btText = this.FindControl<TextBlock>( "TbText" );

            btText.Text = msg;
        }
      
        public MessageBox()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var btOk = this.FindControl<Button>( "BtOk" );

            btOk.Click += (_, _) => this.Close();
        }

        void InitializeComponent()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            AvaloniaXamlLoader.Load(this);
        }
    }
}
