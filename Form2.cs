﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;
using SportMusic.pages;
using SportMusic.selenium;

namespace SportMusic
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Указатель на главную форму.
        /// </summary>
        private Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Констркутор взаимодействия с формами.
        /// </summary>
        /// <param name="form">Принимает указатель на главную форму.</param>
        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        /// <summary>
        /// Метод для доступа.
        /// </summary>
        public Panel PanelSelectedTracks
        {
            get
            {
                return panelSelectedTracks;
            }
        }

        

        

       
        

        

        



        

        
    }
}
