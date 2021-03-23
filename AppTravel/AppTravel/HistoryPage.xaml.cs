using AppTravel.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTravel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {

        public HistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            using (SQLiteConnection con = new SQLiteConnection(App.DatabaseLocation))
            {
                con.CreateTable<Post>();
                var posts = con.Table<Post>().ToList();
                                
                postListView.ItemsSource = posts;

            }
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
                var selectedPost = postListView.SelectedItem as Post;

                if(selectedPost != null)
                {
                    Navigation.PushAsync(new PostDetailPage(selectedPost));
                }
        
        }
               
        
    }
}