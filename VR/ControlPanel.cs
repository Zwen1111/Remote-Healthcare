﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR
{
    public partial class ControlPanel : Form
    {
        Connector connector;

        public ControlPanel(Connector connector)
        {
            InitializeComponent();
            this.connector = connector;
        }

        private void Add_Tree_Click(object sender, EventArgs e)
        {
            AddModel model = new AddModel(connector);
            model.Show();
        }
    }
}
