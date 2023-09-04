using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repos.PostRepo;

namespace PRA_Infoeduka
{
    public partial class NewsPost : UserControl
    {

        public NewsPost()
        {
            InitializeComponent();
        }

        public string PostTitle
        {
            get { return tbTitle.Text; }
            set { tbTitle.Text = value; }
        }

        public string PostYear
        {
            get { return tbYear.Text; }
            set { tbYear.Text = value; }
        }

        public string PostMessage
        {
            get { return rtbMessage.Text; }
            set { rtbMessage.Text = value; }
        }
    }
}
