// AvaloniaCalc (c) 2021 Baltasar MIT License <jbgarcia@uvigo.es>


namespace AvaloniaCalc.UI {
    using System;
    using Avalonia;
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;
    
    using Core;

    
    public partial class MainWindow : Window {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            
            var btCalc = this.FindControl<Button>("BtCalc");
            var edOp1 = this.FindControl<TextBox>("EdOp1");
            var edOp2 = this.FindControl<TextBox>("EdOp2");
            var cbOps = this.FindControl<ComboBox>( "CbOps" );
            var opExit = this.FindControl<MenuItem>( "OpExit" );
            var opAbout = this.FindControl<MenuItem>( "OpAbout" );
            
            btCalc.Click += (_, _) => this.OnCalc();
            edOp1.KeyUp += (_, _) => this.OnCalc();
            edOp2.KeyUp += (_, _) => this.OnCalc();
            cbOps.SelectionChanged += (_, _) => this.OnCalc();
            opExit.Click += (_, _) => this.Close();
            opAbout.Click += (_, _) => new MessageBox( AppInfo.Name + " v" + AppInfo.Version )
                                        .ShowDialog( this );
        }

        void InitializeComponent()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AvaloniaXamlLoader.Load(this);
        }

        void OnCalc()
        {
            var edOp1 = this.FindControl<TextBox>("EdOp1");
            var edOp2 = this.FindControl<TextBox>("EdOp2");
            var cbOps = this.FindControl<ComboBox>( "CbOps" );
            var edRes = this.FindControl<TextBox>("EdRes");
            double op1;
            double op2;
            double res = 0;

            if ( !double.TryParse( edOp1.Text.Trim(), out op1 ) ) {
                op1 = 0;
            }
                
            if ( !double.TryParse( edOp2.Text.Trim(), out op2 ) ) {
                op2 = 0;
            }
            
            switch ( cbOps.SelectedIndex ) {
                case 0: res = Calculadora.Suma( op1, op2 );
                    break;
                case 1: res = Calculadora.Resta( op1, op2 );
                    break;
                case 2: res = Calculadora.Multiplica( op1, op2 );
                    break;
                case 3: res = Calculadora.Divide( op1, op2 );
                    break;
                default:
                    new MessageBox( "Operador desconocido" )
                                    .ShowDialog( this );
                    break;
            }

            edRes.Text = Convert.ToString( res );
        }
    }
}
