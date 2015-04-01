using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komora.Classes.DataBase

{
    public class LinqDataBaseConnector : IDataBaseConnector
    {
        private LinqDatabaseDataContext dataContext;

        public bool connect()
        {
            dataContext = new LinqDatabaseDataContext();
            if (dataContext.DatabaseExists())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool disconnect()
        {
            try
            {
                dataContext.Dispose();
                return true;
            }
            catch (NullReferenceException)
            { 
                return false;
            }
        }

        public User getUser(string login, string password)
        {
            return this.dataContext.Users.First(x => x.username == login && x.password == password);
        }

        public User getUser(int id)
        {
            return this.dataContext.Users.First(x => x.ID == id);
        }

        public IQueryable<User> getAllUsers()
        {
            return this.dataContext.Users.Select(user => user);
        }

        public HardwareConfiguration getChamber(int id)
        {
            return this.dataContext.HardwareConfigurations.First(x => x.ID == id);
        }

        public IQueryable<HardwareConfiguration> selectAllChambers()
        {
            return this.dataContext.HardwareConfigurations.Select(chamber => chamber);
        }

        public IQueryable<Pt100_Poly> selectAllPt100Polynomials()
        {
            return this.dataContext.Pt100_Polies.Select(pt100Poly => pt100Poly);
        }

        public Pt100_Poly selectPt100Polynomial(int chamberId)
        {
            return (from c in dataContext.Pt100_Polies
                    where c.chamberID == chamberId
                    select c).First();
        }

        public IQueryable<Led_Poly> selectAllLedPolynomials()
        {
            return this.dataContext.Led_Polies.Select(ledPoly => ledPoly);
        }

        public void deleteChamber(Chamber.ChamberData chamberData)
        {
            //do refaktoru
            //wybierz komore do usuniecia
            var chamber = (from c in dataContext.HardwareConfigurations
                           where c.chamberName == chamberData.Name &&
                                 c.chamberNumber == chamberData.Number &&
                                 c.serialPort == chamberData.SerialPort
                           select c).First();

            //wybierz ID komory do usuniecia
            var chamberID = (from c in dataContext.HardwareConfigurations
                             where c.chamberName == chamberData.Name &&
                                 c.chamberNumber == chamberData.Number &&
                                 c.serialPort == chamberData.SerialPort
                             select c.ID).First();

            //wybierz rekord ze wspolczynnimami do usuniecia
            var Coefficient = from c in dataContext.Pt100_Polies
                              where c.chamberID == chamberID
                              select c;

            //najpierw usuwany rekord ze wspolczynnikami
            foreach (Pt100_Poly pt100_poly in Coefficient)
            {
                dataContext.Pt100_Polies.DeleteOnSubmit(pt100_poly);
            }

            //teraz usun komore
            dataContext.HardwareConfigurations.DeleteOnSubmit(chamber);

            //potwierdz zmiany
            dataContext.SubmitChanges();
        }

        public void deleteChamber(int chamberID)
        {
            var chamber = (from c in dataContext.HardwareConfigurations
                           where c.ID == chamberID
                           select c).First();

            //wybierz rekord ze wspolczynnimami do usuniecia PT100
            var pt100Coefficients = from c in dataContext.Pt100_Polies
                              where c.chamberID == chamberID
                              select c;
            foreach (Pt100_Poly pt100_poly in pt100Coefficients)
            {
                dataContext.Pt100_Polies.DeleteOnSubmit(pt100_poly);
            }

            //wybierz rekord ze wspolczynnimami do usuniecia LED
            var ledCoefficients = from c in dataContext.Led_Polies
                                  where c.chamberID == chamberID
                                  select c;
            foreach (Led_Poly led_poly in ledCoefficients)
            {
                dataContext.Led_Polies.DeleteOnSubmit(led_poly);
            }

            //teraz usun komore
            dataContext.HardwareConfigurations.DeleteOnSubmit(chamber);

            //potwierdz zmiany
            dataContext.SubmitChanges();
        }

        public void deletePt100Coefficients(int coefficientsID)
        {
            var query = (from c in dataContext.Pt100_Polies
                        where c.ID == coefficientsID
                        select c).First();

            dataContext.Pt100_Polies.DeleteOnSubmit(query);
            dataContext.SubmitChanges();
        }

        public void deletePt100Coefficients()
        {
            var query = from c in dataContext.Pt100_Polies select c;

            foreach (var item in query)
            {
                dataContext.Pt100_Polies.DeleteOnSubmit(item);
            }  
            dataContext.SubmitChanges(); 
        }

        public void deleteLedCoefficients(int coefficientsID) 
        {
            var query = (from c in dataContext.Led_Polies
                         where c.ID == coefficientsID
                         select c).First();

            dataContext.Led_Polies.DeleteOnSubmit(query);
            dataContext.SubmitChanges();
        }

        public void deleteLedCoefficients()
        {
            var query = from c in dataContext.Led_Polies select c;

            foreach (var item in query)
            {
                dataContext.Led_Polies.DeleteOnSubmit(item);
            }
            dataContext.SubmitChanges(); 
        }

        public void savePt100Coefficients(int chamberID, string coefficients)
        {
            chamberHasPt100Coefficients(chamberID);

            Pt100_Poly pt100Poly = new Pt100_Poly();
            pt100Poly.chamberID = chamberID;
            pt100Poly.Coefficients = coefficients;
            
            try
            {
                dataContext.Pt100_Polies.InsertOnSubmit(pt100Poly);
                dataContext.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in savePt100Coefficient!");
            }
        }

        public void saveLEDCoefficients(int chamberID, string coefficientsLower, string coefficientsHigher)
        {
            chamberHasLedCoefficients(chamberID);

            Led_Poly ledPoly = new Led_Poly();
            ledPoly.chamberID = chamberID;
            ledPoly.LowerCurrentCoefficients = coefficientsLower;
            ledPoly.HigherCurrentCoefficients = coefficientsHigher;
            
            try
            {
                dataContext.Led_Polies.InsertOnSubmit(ledPoly);
                dataContext.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in saveLEDCoefficients!");
            }
        }

        private void chamberHasPt100Coefficients(int chamberID)
        {
            var query = from c in dataContext.Pt100_Polies
                        where c.chamberID == chamberID
                        select c;

            if (query.Any())
            {
                throw new ChamberAlreadyHasCoefficientsException("Selected chamber already has saved coefficients for Pt100");
            }
        }

        private void chamberHasLedCoefficients(int chamberID)
        {
            var query = from c in dataContext.Led_Polies
                        where c.chamberID == chamberID
                        select c;

            if (query.Any())
            {
                throw new ChamberAlreadyHasCoefficientsException("Selected hamber already has saved coefficients for LED");
            }
        }
    }
}
