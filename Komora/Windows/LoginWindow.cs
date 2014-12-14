using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komora.Classes;

namespace Komora.Windows
{
    public partial class LoginWindow : Form
    {
        #region Private Variables
        Classes.DataBase.IDataBaseConnector dataBaseConnector;
        Classes.DataBase.IDataBaseConncection dataBaseConnection;
        Classes.Loger.Loger loger;
        Windows.MainMenuForm mainMenuWindow;
        #endregion

        #region Constructor
        public LoginWindow()
        {
            dataBaseConnector = new Classes.DataBase.LinqDataBaseConnector();
            dataBaseConnection = new Classes.DataBase.DataBaseConnectionProxy(dataBaseConnector);
            //loger = new Classes.Loger.LogerDataBase(dataBaseConnection);
            loger = new Classes.Loger.LogerFake();
            loger.loginSucces += ShowMainMenuWindow;
            loger.loginFailed += DisplayLoginFailedMessage;

            Komora.DataTypes.LedPolynomial ledPoly = new DataTypes.LedPolynomial();
            ledPoly = new Komora.DataTypes.LedPolynomial();
            Komora.DataTypes.MeasurementSamples<double> samples = new Komora.DataTypes.MeasurementSamples<double>(new List<Tuple<double, double>> 
                                                               {
                                                                   new Tuple<double,double>(0.0, 0.0),
                                                                   new Tuple<double,double>(2.0, 4.0),
                                                                   new Tuple<double,double>(3.0, 9.0),
                                                                   new Tuple<double,double>(5.0, 125.0),
                                                                   new Tuple<double,double>(6.0, 216.0),
                                                                   new Tuple<double,double>(7.0, 343.0),
                                                                   new Tuple<double,double>(10.0, 1000.0)
                                                               });
            var resultLowerCurrent = new Komora.DataTypes.PolynomialCoefficients<double>(new List<double>() { 0.0, 0.0, 1.0 });
            var resultHigherCurrent = new Komora.DataTypes.PolynomialCoefficients<double>(new List<double>() { 0.0, 0.0, 0.0, 1.0 });
            int lowerOrder = 2;
            int higherOrder = 3;
            int bound = 4;

            ledPoly.calculateCoefficients(samples, bound, lowerOrder, higherOrder);


            InitializeComponent();
        }
        #endregion

        #region Private Methods
        private void ShowMainMenuWindow (object sender, EventArgs e)
        {
            mainMenuWindow = new MainMenuForm();
            mainMenuWindow.showWindow += ShowLoginWindow;
            mainMenuWindow.Show();
            this.Hide();
        }
        private void DisplayLoginFailedMessage(object sender, EventArgs e)
        {
            MessageBox.Show("Login failed!");
        }
        private void ShowLoginWindow(object sender, EventArgs e)
        {
            this.Show();
        }
        #endregion

        #region Button Events
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userLogin = tbLogin.Text;
            string userPassword = tbPassword.Text;
            loger.validateUser(userLogin, userPassword);
        }
        #endregion
    }
}
