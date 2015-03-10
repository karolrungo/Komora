﻿using System;
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


        void deleteChamber(Chamber.ChamberData chamberData);



        void deletePt100Coefficients(int coefficientsID);
        void deletePt100Coefficients();
        void deleteLedCoefficients(int coefficientsID); 
        void deleteLedCoefficients();
    }
}
