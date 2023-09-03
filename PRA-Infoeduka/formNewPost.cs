using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;

namespace PRA_Infoeduka
{
    public partial class formNewPost : Form
    {

        List<Post> posts = new List<Post>();
        public formNewPost()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
