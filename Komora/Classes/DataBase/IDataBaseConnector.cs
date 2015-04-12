using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.DataBase

{
    public interface IDataBaseConnector
    {
        bool connect();
        bool disconnect();

        User getUser(string login, string password);
        User getUser(int id);

        HardwareConfiguration getChamber(int id);

        IQueryable<User> getAllUsers();
        IQueryable<HardwareConfiguration> selectAllChambers();
        IQueryable<Pt100_Poly> selectAllPt100Polynomials();
        IQueryable<Led_Poly> selectAllLedPolynomials();
        IQueryable<HardwareConfiguration> selectCalibratedChambers();


        void deleteChamber(string name, string serialPort, int number);
        void deleteChamber(int chamberID);
        void deletePt100Coefficients(int coefficientsID);
        void deletePt100Coefficients();
        void deleteLedCoefficients(int coefficientsID); 
        void deleteLedCoefficients();
        void savePt100Coefficients(int chamberID, string coefficients);
        void saveLEDCoefficients(int chamberID, string coefficientsLower, string coefficientsHigher);
        void addChamber(string chamberName, string serialPort, int chamberNumber);
    }
}
