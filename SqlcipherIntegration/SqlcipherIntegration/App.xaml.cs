using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SqlcipherIntegration
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Initiate Batteries
            SQLitePCL.Batteries_V2.Init();
            // Encrypt Key for first time
            DAL.SqliteConnectionFactory.InitiateOnce();
            // Test if encryption working
            new DAL.SqliteConnectionTest().TestCreateTable();
            new DAL.SqliteConnectionTest().TestInsertProductThrowsExceptionWOKey();
            MainPage = new SqlcipherIntegration.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
