namespace ControlesTipoVista.Views;

public partial class Image_Vista : ContentPage
{
	public Image_Vista()
	{
		InitializeComponent();
		Dise�ador.Add(new Image { Source = ImageSource.FromResource("ControlesTipoVista.ImagenesGif.formatgif.gif"), WidthRequest = 100, HeightRequest = 100 });
	}
}