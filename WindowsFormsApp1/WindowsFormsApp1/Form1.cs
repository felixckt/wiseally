using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuelSDK;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ETClient myClient = new ETClient();

            //Create an instance of the Salesforce Marketing Cloud we want to work with:

            ETList list = new ETList();

            //Associate the ETClient to the object using the client property:

            list.AuthStub = myClient;

            //Utilize one of the ETList methods:

            GetReturn allLists = list.Get();

            //Print out the results for viewing
            

            Console.WriteLine("Get Status: " + allLists.Status.ToString());
            Console.WriteLine("Message: " + allLists.Message.ToString());
            Console.WriteLine("Code: " + allLists.Code.ToString());
            Console.WriteLine("Results Length: " + allLists.Results.Length);
            foreach (ETList ResultList in allLists.Results)
            {
                Console.WriteLine("--ID: " + ResultList.ID + ", Name: " + ResultList.ListName + ", Description: " + ResultList.Description);
            }
        }
    }
}
