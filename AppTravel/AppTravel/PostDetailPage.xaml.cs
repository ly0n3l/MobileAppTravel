using AppTravel.Model;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;


namespace AppTravel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostDetailPage : ContentPage
    {
        Post selectedPost;
        public PostDetailPage(Post selectedPost)
        {
            InitializeComponent();

            this.selectedPost = selectedPost;
            
            experienceEntry.Text = selectedPost.Experience;
        }

        void UpdateButton_Clicked(object sender, System.EventArgs e)
        {
            selectedPost.Experience = experienceEntry.Text;

            using (SQLiteConnection con = new SQLiteConnection(App.DatabaseLocation))
            {
                con.CreateTable<Post>();
                int rows = con.Update(selectedPost);
                con.Close();

                if (rows > 0)
                    DisplayAlert("Success", "Experience Modifier avec Succes", "OK");
                else
                    DisplayAlert("Failure", "Experience failed to be inserted", "OK");
            }

        }

        void DeleteButton_Clicked(object sender, System.EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(App.DatabaseLocation))
            {
                con.CreateTable<Post>();
                int rows = con.Delete(selectedPost);
                con.Close();

                if (rows > 0)
                    DisplayAlert("Success", "Experience Supprimer avec Succes", "OK");
                else
                    DisplayAlert("Failure", "Experience failed to be inserted", "OK");
            }
        }
    }
}