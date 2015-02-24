﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komora.Classes.DataBase;

namespace Komora.Windows
{
    public partial class CalibrationWindow : Form
    {
        private IDataBaseConnector linqDatabaseConnector;

        public CalibrationWindow()
        {
            linqDatabaseConnector = new LinqDataBaseConnector();
            linqDatabaseConnector.connect();

            InitializeComponent();
            
        }
    }
}
