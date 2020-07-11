using System;
using System.Windows.Forms;
using System.Drawing;           //For using "Point" as location for the Note location
using System.Collections;       //For using ArrayList

namespace Storyboard
{
    //Search_Result_Form class  -   Windows Form class
    //Search_Result_Form class contains :
    //  -panel1 : to view the Notes
    public partial class Search_Result_Form : Form
    {
        public Search_Result_Form(ArrayList Notes_found)
        {
            //Class constructor
            //Class parameters :
            //  -ArrayList Notes_found : contains all the resulting Notes from the search

            //GUI Component Initialization
            InitializeComponent();

            //gbNote
            //  -New created GUI component -User Control- contais : 
            //      -groupbox
            //      -labels to view Note informations ( Title - Text - Tags )
            //  -Size : 
            //      Width :  460
            //      Height : 110

            //set the location of the gbNote
            int Location_Y = 0;
            foreach(Note n in Notes_found)
            {
                gbNote result_note = new gbNote(n);
                result_note.Location = new Point(0, Location_Y);

                panel1.Controls.Add(result_note);

                Location_Y += 110;      //110 - > gbNote Height
            }
        }
    }
}