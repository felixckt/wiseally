using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using ModelClass.Model;


namespace TelerikXamarinApp3.Portable
{
    public partial class MainPage : ContentPage
    {
        //ModelClass.Model.SalesOrder[] salesordersui { get; set; }
        public MainPage()
        {
            InitializeComponent();
            
        }
        
        async Task Handle_ClickedAsync(object sender, System.EventArgs e)
        {

            //List<ModelClass.Model.SalesOrder> saleorderui = GetOrders();

            await GetOrders();


        }

        async Task GetOrders2()
        {
            await GetOrders();
        }





        public async static Task GetOrders()
        
        {
            List<ModelClass.Model.SalesOrder> salesorders = new List<ModelClass.Model.SalesOrder>();

            using (HttpClient client = new HttpClient())
            {

                var response = await client.GetAsync("https://wacrmwebservice.azurewebsites.net/api/SalesOrderHeaders");
                var json = response.Content.ReadAsStringAsync();
            }
        }
    }
       
}
