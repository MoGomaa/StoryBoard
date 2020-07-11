using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Storyboard
{
    //Add_Note_Form class  -   Windows Form class
    //Add_Note_Form class contains :
    //  - 3 textbox ( txt_Title - txt_Text - txt_Tags ) : contains the Title/Text/Tag of the new Note
    //  - 2 button  ( btn_Add - btn_Clear )
    //  -Additional : groupbox - lables
    public partial class Add_Note_Form : Form
    {
        public Add_Note_Form()
        {
            //Class constructor -  parameterless class

            //GUI Component Initialization
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //btn_Add_Click method : 
            //  -Take information ( Title - Text  - Tags ) from 3 TextBox
            //  -Creat a new Note object and add it to static ArrayList Notes in the Storyboard class
            //  -Show MessageBox("Note has been added") with OK button

            //btn_Add_Click method : 
            //  -event handler for the ( btn_Add_Click ) click
            //  -No additional input parameters
            //  -No output

            //The Tags TextBox may contain more than 1 tag seperated by ','
            string[] tags = txt_Tags.Text.Split(',');       //tags : string array contains the tags
            for(int i=0; i<tags.Length ; ++i)
            {
                tags[i] = tags[i].Trim();                   //Trim any (white spaces) from the begining and end of the tag string
            }

            //Creat the Note and add it to ArrayList Storyboard.Notes
            Note n = new Note(txt_Title.Text, txt_Text.Text, tags);
            Storyboard.Notes.Add(n);

            //MessageBox("Note has been added") with OK button
            string message = "Note has been added";
            string title = "Add Note";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

            //Clear the 3 TextBox for new (Add Note) operation if needed
            txt_Title.Text = "";
            txt_Text.Text = "";
            txt_Tags.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //btn_Search_Click method : Clear the 3 TextBox
            //  -event handler for the ( btn_Clear_Click ) click
            //  -No additional input parameters
            //  -No output

            txt_Title.Text = "";
            txt_Text.Text = "";
            txt_Tags.Text = "";
        }
    }
}
