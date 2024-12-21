using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitSphere.Forms
{
    public partial class Home : Form
    {
        public Home(String username)
        {
            InitializeComponent();
            lblUser.Text = username;    
        }
    }
}
