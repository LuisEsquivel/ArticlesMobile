using System.ComponentModel;
using Xamarin.Forms;
using ArticlesMobile.ViewModels;

namespace ArticlesMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}