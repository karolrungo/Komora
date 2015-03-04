using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public HardwareConfiguration selectChamber(int id)
        {
            return this.dataContext.HardwareConfigurations.First(x => x.ID == id);
        }

        public IQueryable<User> selectAllUsers()
        {
            return this.dataContext.Users.Select(user => user);
        }
        public IQueryable<HardwareConfiguration> selectAllChambers()
        {
            return this.dataContext.HardwareConfigurations.Select(chamber => chamber);
        }
        public IQueryable<Pt100_Poly> selectAllPt100Polynomials()
        {
            return this.dataContext.Pt100_Polies.Select(pt100Poly => pt100Poly);
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

        
    }
}
