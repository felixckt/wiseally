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
            List<ModelClass.Model.SalesOrder> salesordersui = await GetOrders();
        }

        public async static Task<List<ModelClass.Model.SalesOrder>> GetOrders()
        {
            List<ModelClass.Model.SalesOrder> salesorders = new List<ModelClass.Model.SalesOrder>();

            return salesorders;


        }


        



    }
}
