namespace EstoqueMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //criar janela principal da aplicação
            var window = new Window(new AppShell());

            // definir largura inicial da janela
            window.Width = 1000;
            // definir altura inicial da janela
            window.Height = 650;

            //definir a largura minima permitida
            window.MinimumWidth = 1000;
            //definir a largura maxima permitida
            window.MaximumWidth = 1200;

            //definir altura minima permitida
            window.MinimumHeight = 650;
            //definir altura maxima permitida
            window.MaximumHeight = 750;

            return window;
        }
    }
}