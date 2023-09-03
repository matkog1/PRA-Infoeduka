﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;
using DAL.Repos.SubjectRepo;
namespace PRA_Infoeduka
{
    public partial class formNewSubject : Form
    {
        IRepoSubject repoSubject;
        List<Subject> subjects = new List<Subject>();
        public formNewSubject()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Subject subject = repoSubject.CreateSubject(tbTitle.Text, tbLectureType.Text, tbCode.Text, tbYear.Text, tbEcts.Text);
            subjects.Add(subject);
        }
    }
}
