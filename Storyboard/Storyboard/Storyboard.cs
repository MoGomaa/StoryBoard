using System;
using System.Windows.Forms;
using System.Drawing;           //For using "Point" as location for the Note location
using System.Collections;       //For using ArrayList

namespace Storyboard
{
    //Storyboard class  -   Main Windows Form class
    //Storyboard class contains :
    //  -File menu : used to ( Add new Note, Search )
    //  -panel1 : to view the Notes
    //  -timer1 : to continously chceck if there is any new Note to view in panel1 
    public partial class Storyboard : Form
    {
        //ArrayList contains all the Note in the Storyboard
        //ArrayList elements : object type --> Every object is class Note type
        public static ArrayList Notes = new ArrayList();
        //Counter for the Note that has been viewed on the Storyboard already
        private static int Viewed_Notes_counter = 0;

        public Storyboard()
        {
            //Class constructor -  parameterless class

            //GUI Component Initialization
            InitializeComponent();
        }

        private void Storyboard_Load(object sender, EventArgs e)
        {
            /////////////////////   test \\\\\\\\\\\\\\\\\\\\\\\\\\\\
            string title = "Test Traceplayer";
            string text = "Implement a unit test for the class Traceplayer of the spark core framework.";
            string[] tags = new string[] { "tag 1", "tag 2"};
            Note n1 = new Note(title, text, tags);

            title = "Test 2";
            text = "The text for test 2";
            tags = new string[]{ "tag 1", "tag 2", "tag 3", "tag 4" };
            Note n2 = new Note(title, text, tags);

            title = "Test 3";
            text = "The text for test 6";            
            tags = new string[] { "tag 1", "tag 2", "tag 3"};
            Note n3 = new Note(title, text, tags);

            Notes.Add(n1); Notes.Add(n2); Notes.Add(n3);
            /////////////////////   test \\\\\\\\\\\\\\\\\\\\\\\\\\\\
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add Note --> menu_File Item
            //searchToolStripMenuItem_Click : event handler for Add Note menu item click

            //Creat new Add_Note_Form and show it
            Add_Note_Form addNote_form = new Add_Note_Form();
            addNote_form.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Search --> menu_File Item
            //searchToolStripMenuItem_Click : event handler for Search menu item click

            //Creat new Search_Form and show it
            Search_Form search_form = new Search_Form();
            search_form.Show();
        }

        public void Show_Note(Note n)
        {
            //Show_Note method :
            //  -Input Parameters : Note to be viewed - Note class type
            //  -No output

            //gbNote
            //  -New created GUI component -User Control- contais : 
            //      -groupbox
            //      -labels to view Note informations ( Title - Text - Tags )
            //  -Size : 
            //      Width :  460
            //      Height : 110
            gbNote note = new gbNote(n);

            //set the location of the gbNote
            int Location_Y = Viewed_Notes_counter * 110;    //110 - > gbNote Height
            note.Location = new Point(0, Location_Y);

            panel1.Controls.Add(note);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1 : to continously chceck if there is any new Note to view in panel1
            //timer1 interval : 0.01 sec
            //timer1_Tick method : 
            //  -event handler for the timer tick
            //  -No additional input parameters
            //  -No output

            //Check if there is any new Notes added
            if (Notes.Count > Viewed_Notes_counter)
            {
                //n : number of the new Notes
                int n = Notes.Count - Viewed_Notes_counter;
                //Looping n times to show the new Notes --> Show_Note()
                for (int i = 0; i < n; ++i)
                {
                    Show_Note((Note)Notes[Viewed_Notes_counter]);   //casting object ArrayList elements to Note type
                    Viewed_Notes_counter++;
                }
            }
        }
    }
}
