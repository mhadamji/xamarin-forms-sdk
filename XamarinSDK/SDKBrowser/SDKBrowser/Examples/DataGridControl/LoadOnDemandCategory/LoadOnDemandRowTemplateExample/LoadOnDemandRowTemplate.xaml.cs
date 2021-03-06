﻿using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.DataGridControl.LoadOnDemandCategory.LoadOnDemandRowTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadOnDemandRowTemplate : ContentView
    {
        public LoadOnDemandRowTemplate()
        {
            this.InitializeComponent();

            this.BindingContext = new LoadOnDemandRowTemplateViewModel();
        }

        private async void dataGrid_LoadOnDemand(object sender, Telerik.XamarinForms.DataGrid.LoadOnDemandEventArgs e)
        {
            await Task.Delay(3000);
            for (int i = 0; i < 15; i++)
            {
                ((sender as RadDataGrid).ItemsSource as ObservableCollection<Person>).Add(new Person() { Name = "Person " + i, Age = i + 18, Gender = i % 2 == 0 ? Gender.Male : Gender.Female });
            }
            e.IsDataLoaded = true;
        }
    }
}