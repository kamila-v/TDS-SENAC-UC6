namespace EstoqueMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAdicionarClicked(
        object sender, EventArgs e)
    {
        string nome = NomeEntry.Text?.Trim() ?? "";
        if (string.IsNullOrWhiteSpace(nome))
        {
            ResultadoLabel.Text =
                "Informe o nome do produto.";
            return;
        }
        if (!int.TryParse(
            QuantidadeEntry.Text,
            out int quantidade) || quantidade <= 0)
        {
            ResultadoLabel.Text =
                "Informe uma quantidade válida.";
            return;
        }

        ResultadoLabel.Text =
            $"Produto cadastrado: {nome} | " +
            $"Quantidade: {quantidade}";

        NomeEntry.Text = "";
        QuantidadeEntry.Text = "";
    }
}