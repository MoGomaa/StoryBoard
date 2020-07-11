using System;
using System.Windows.Forms;

namespace Storyboard
{
    //gbNote class  -  UserControl ( user defined Control )
    //gbNote class  :  used to view a Note iformation
    //gbNote class contains :
    //  - groupbox with labels  --> Information about the Note ( Title - Text  - Tags )
    public partial class gbNote : UserControl
    {
        public gbNote(Note n)
        {
            //Class constructor
            //Class parameters :
            //  -Notes n : The Note that wanted to view its information

            //GUI Component Initialization
            InitializeComponent();

            //set the labels with the Note information with the date/time information
            grp_Note.Text = "Note   ||   " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            lb_Note_Title.Text = n.Title;
            lb_Note_Text.Text = n.Text;
            lb_Note_Tags.Text = string.Join(", ", n.Tags);
        }
    }
}
