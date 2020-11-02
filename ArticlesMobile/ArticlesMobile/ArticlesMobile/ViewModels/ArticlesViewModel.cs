using ArticlesMobile.Helpers;
using ArticlesMobile.Models;
using ArticlesMobile.Services;
using ArticlesMobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ArticlesMobile.ViewModels
{
    public class ArticlesViewModel : BaseViewModel
    {

        public  List<Article>  _Article;
        public ApiService apiService { get; set; }

        public Generals generals { get; set; }


        public List<Article> Article 
        {
            get => _Article;
            set => SetProperty(ref _Article, value);
        }

        public ArticlesViewModel()
        {
            apiService = new ApiService();
            generals = new Generals();
            Title = "Articles";
            GetArticles();
        }

        public void GetArticles()
        {
            string[] urlparams = { "UrlBase", "Preffix", "Articles", "All" };
            Article =  Task.Run( () => apiService.Get<Article>(  generals.Url(urlparams) , generals.Key("ObjectName") )  ).Result;
        }

        public ICommand CommandGoToArticles()
        {
          return   new Command(GotoArticles);
        }

        private async void GotoArticles(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(ArticlesPage)}");
        }

    }
}
