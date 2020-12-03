using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyClassLibrary1;

namespace MyXamarin1
{
    public partial class MainPage : ContentPage
    {
        GetName getName;
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(entryTxt.Text))
            {
                getName = new GetName();
            }
            else 
            {
                getName = new GetName(entryTxt.Text);
            } 
            DisplayAlert("Приветствие", $"{getName.GetNameMethod()}", "ОК");
        }
    }
}
