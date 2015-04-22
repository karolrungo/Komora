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
            return this.dataContext.HardwareConfigurations.AsQueryable();
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

        public void deleteChamber(string name, string serialPort, int number)
        {
            HardwareConfiguration chamberData = new HardwareConfiguration();
            chamberData.chamberName = name;
            chamberData.serialPort = serialPort;
            chamberData.chamberNumber = number;

            //do refaktoru
            //wybierz komore do usuniecia
            var chamber = (from c in dataContext.HardwareConfigurations
                           where c.chamberName == chamberData.chamberName &&
                                 c.chamberNumber == chamberData.chamberNumber &&
                                 c.serialPort == chamberData.serialPort
                           select c).First();

            //wybierz ID komory do usuniecia
            var chamberID = (from c in dataContext.HardwareConfigurations
                             where c.chamberName == chamberData.chamberName &&
                                 c.chamberNumber == chamberData.chamberNumber &&
                                 c.serialPort == chamberData.serialPort
                             select c.ID).First();

            //wybierz rekord ze wspolczynnimami do usuniecia
            var CoefficientPt100 = from c in dataContext.Pt100_Polies
                              where c.chamberID == chamberID
                              select c;

            //wybierz rekord ze wspolczynnimami do usuniecia
            var CoefficientLed = from c in dataContext.Led_Polies
                                 where c.chamberID == chamberID
                                 select c;

            //najpierw usuwany rekord ze wspolczynnikami
            foreach (Pt100_Poly pt100_poly in CoefficientPt100)
            {
                dataContext.Pt100_Polies.DeleteOnSubmit(pt100_poly);
            }

            //najpierw usuwany rekord ze wspolczynnikami
            foreach (Led_Poly ledPoly in CoefficientLed)
            {
                dataContext.Led_Polies.DeleteOnSubmit(ledPoly);
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
            if (chamberAlreadyHasPt100Coefficients(chamberID))
            {
                throw new ChamberAlreadyHasCoefficientsException("Selected chamber already has saved coefficients for Pt100");
            }

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

        public void addChamber(string chamberName, string serialPort, int chamberNumber)
        {
            HardwareConfiguration hwConf = new HardwareConfiguration();
            hwConf.chamberName = chamberName;
            hwConf.serialPort = serialPort;
            hwConf.chamberNumber = chamberNumber;

            if (!chamberAlreadyInDatabase(hwConf))
            {
                dataContext.HardwareConfigurations.InsertOnSubmit(hwConf);
                dataContext.SubmitChanges();
            }
            else
            {
                throw new Exception("Chamber already defined in database.");
            }
            
        }

        private bool chamberAlreadyInDatabase(HardwareConfiguration chamberData)
        {
            var query = from c in dataContext.HardwareConfigurations
                        where c.chamberName == chamberData.chamberName ||
                              c.serialPort == chamberData.serialPort ||
                              c.chamberNumber == chamberData.chamberNumber
                        select c;

            return query.Any();
        }

        public IQueryable<HardwareConfiguration> selectCalibratedChambers()
        {
            var allChambers = selectAllChambers();
            return allChambers.Where(chamber => chamber.Pt100_Polies.Any() && chamber.Led_Polies.Any());
        }

        public void saveMeasurementInfo(DataTypes.MeasurementInfo measInfo)
        {
            DataBase.MeasurementTable info = new MeasurementTable();
            info.Name = measInfo.measurementName;
            info.Filename = measInfo.filename;
            info.Weight = measInfo.weight;
            info.Material = measInfo.material;
            info.Synthesis_Laboratory = measInfo.laboratory;
            info.Synthesis_Date = measInfo.synthesisDate;
            info.Synthesis_Operator = measInfo._operator;
            info.Rejuvenation_After = measInfo.afterRejuvenation;
            info.Rejuvenation_Date = measInfo.rejuvenationDate;
            info.Rejuvenation_AddInfo = measInfo.rejuvenationAdditionalInfo;
            info.Rejuvenation_DarkAged = measInfo.darkAged;
            info.RejuvenationSpecialAged = measInfo.specialAged;

            if (!measurementAlreadyExists(info.Name))
            {
                dataContext.MeasurementTables.InsertOnSubmit(info);
                dataContext.SubmitChanges();
            }
        }

        public IQueryable<MeasurementTable> getAllMeasurementInfo()
        {
            return this.dataContext.MeasurementTables.Select(info => info);
        }

        public DataTypes.MeasurementInfo getMeasurementInfo(int measurementInfoID)
        {
            MeasurementTable info = dataContext.MeasurementTables.First(x => x.ID == measurementInfoID);

            DataTypes.MeasurementInfo measInfo = new DataTypes.MeasurementInfo();
            measInfo.measurementName = info.Name;
            measInfo.filename = info.Filename;
            measInfo.weight = info.Weight;
            measInfo.material = info.Material;
            measInfo.laboratory = info.Synthesis_Laboratory;
            measInfo.synthesisDate = info.Synthesis_Date;
            measInfo._operator = info.Synthesis_Operator;
            measInfo.afterRejuvenation = info.Rejuvenation_After;
            measInfo.rejuvenationDate = info.Rejuvenation_Date;
            info.Rejuvenation_AddInfo = measInfo.rejuvenationAdditionalInfo;
            measInfo.darkAged = info.Rejuvenation_DarkAged;
            measInfo.specialAged = info.RejuvenationSpecialAged;

            return measInfo;
        }

        private bool measurementAlreadyExists(string measurementName)
        {
            var query = from c in dataContext.MeasurementTables
                        where c.Name == measurementName
                        select c;

            return query.Any();
        }

        private bool chamberAlreadyHasPt100Coefficients(int chamberID)
        {
            var query = from c in dataContext.Pt100_Polies
                        where c.chamberID == chamberID
                        select c;

            return query.Any();
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
