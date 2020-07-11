using System;
using System.Windows.Forms;
using System.Collections;       //For using ArrayList

namespace Storyboard
{
    //Search_Form class  -   Windows Form class
    //Search_Form class contains :
    //  -radiio buttons #3 : to select what we are searching for ( Title/Text/Tag )
    //  -textbox ( txt_Search ) : contains the Title/Text/Tag which we searching for
    //  -button  ( btn_Search )
    //  -Additional : groupbox - lable
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            //Class constructor -  parameterless class

            //GUI Component Initialization
            InitializeComponent();
        }

        private ArrayList searchByTitle(string s)
        {
            //searchByTitle method : 
            //  -Input parameters : string (s) - Title which we are searching for
            //  -output           : ArrayList Notes_found - contains all the Notes with Title (s)

            //ArrayList Notes_found - contains all the resulting Notes from the search
            ArrayList Notes_found = new ArrayList();

            //Looping on all the Notes we have in the Storyboard to check its Title
            foreach (Note n in Storyboard.Notes)    //Notes : static class member in the Storyboard class contains all the Notes
            {
                if (n.Title == s)
                    Notes_found.Add(n);
            }

            return Notes_found;
        }

        private ArrayList searchByText(string s)
        {
            //searchByText method : 
            //  -Input parameters : string (s) - Text which we are searching for
            //  -output           : ArrayList Notes_found - contains all the Notes with Text (s)

            //ArrayList Notes_found - contains all the resulting Notes from the search
            ArrayList Notes_found = new ArrayList();

            //Looping on all the Notes we have in the Storyboard to check its Text
            foreach (Note n in Storyboard.Notes)    //Notes : static class member in the Storyboard class contains all the Notes
            {
                if (n.Text == s)
                    Notes_found.Add(n);
            }
            return Notes_found;
        }

        private ArrayList searchByTag(string[] Search_tags)
        {
            //searchByTag method  : 
            //  -Input parameters : string (s) - Tags which we are searching for
            //  -output           : ArrayList Notes_found - contains all the Notes with Tags is (s)
            //  -Assumption :
            //      

            //ArrayList Notes_found - contains all the resulting Notes from the search
            ArrayList Notes_found = new ArrayList();

            //Looping on each tag and search in all the Notes 
            foreach (string s_tag in Search_tags)
            {
                //Looping on all the Notes to search for the tag in str
                foreach (Note n in Storyboard.Notes)    //Notes : static class member in the Storyboard class contains all the Notes
                {
                    string[] Note_tags = n.Tags;
                    //Looping on the every tag inside the Note
                    foreach (string n_tag in Note_tags)
                    {
                        if (n_tag == s_tag)
                        {
                            Notes_found.Add(n);
                            break;      //If one tag is found  --> Done for this Note
                        }
                    }
                }
            }
            return Notes_found;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //btn_Search_Click method : is used for
            //  -select which search function will be called ( searchByTitle - searchByText - searchByTag ) based on the RadioButton choice
            //  -show a MesageBox with the result and asking if the usder want to view it
            
            //btn_Search_Click method : 
            //  -event handler for the ( btn_Search ) click
            //  -No additional input parameters
            //  -No output

            //ArrayList Notes_found - contains all the resulting Notes from the search
            ArrayList Notes_found = new ArrayList();

            //Depending on which RadioButton selected we call one of the search functions ( searchByTitle - searchByText - searchByTag )
            //and the output will be stored in ArrayList Notes_found
            if (Rbtn_Title.Checked == true)
            {
                Notes_found = searchByTitle(txt_Search.Text);
            }
            else if (Rbtn_Text.Checked == true)
            {
                Notes_found = searchByText(txt_Search.Text);
            }
            else if (Rbtn_Tag.Checked == true)
            {
                //The Tags TextBox may contain more than 1 tag seperated by ','
                string[] Search_tags = txt_Search.Text.Split(',');       //tags : string array contains the tags
                for (int i = 0; i < Search_tags.Length; ++i)
                {
                    Search_tags[i] = Search_tags[i].Trim();                   //Trim any (white spaces) from the begining and end of the tag string
                }

                Notes_found = searchByTag(Search_tags);
            }

            //In case of no result found  -->  MessageBox("No result found.") with OK button
            if (Notes_found.Count == 0)
            {
                string message = "No result found.";
                string title = "Search Result";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
            }

            //In case ther is result  -->  MessageBox("Number of result") asking the user to see with Yes/No buttons 
            else if (Notes_found.Count > 0)
            {
                string message = Notes_found.Count.ToString() + " results found.\nDo you want to view results?";
                string title = "Search Result";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult msgbox_response = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                
                if (msgbox_response == DialogResult.Yes)
                {
                    //Creat the Search_Result_Form containing the Notes_found
                    Search_Result_Form result_form = new Search_Result_Form(Notes_found);
                    result_form.Show();
                }
            }
        }
    }
}
