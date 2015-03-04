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

        HardwareConfiguration selectChamber(int id);
        IQueryable<HardwareConfiguration> selectAllChambers();
        IQueryable<Pt100_Poly> selectAllPt100Polynomials();


        void deleteChamber(Chamber.ChamberData chamberData);

        
    }
}
