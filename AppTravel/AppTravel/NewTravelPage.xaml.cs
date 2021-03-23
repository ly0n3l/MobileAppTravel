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
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };

            using (SQLiteConnection con = new SQLiteConnection(App.DatabaseLocation))
            {
                con.CreateTable<Post>();
                int rows = con.Insert(post);
                con.Close();

                if (rows > 0)
                    DisplayAlert("Success", "Experience Ajouter avec Succes", "OK");
                else
                    DisplayAlert("Failure", "Experience failed to be inserted", "OK");
            }
              
        }
    }
}