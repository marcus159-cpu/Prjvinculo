namespace Prjvinculo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = "Coca Cola";
            produto.Preco = 10;
            produto.Categoria = "Refrigerante";

            Navigation.PushAsync(new ProdutoPage() {BindingContext = produto});
        }

        private void btnProduto2_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao2 = "Maça";
            produto.Preco2 = 1;
            produto.Categoria2 = "Frutas";
            Navigation.PushAsync(new ProdutoPage2() {BindingContext = produto});
        }
    }

}
