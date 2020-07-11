using System;

namespace Storyboard
{
    //Note class
    //Note class contains :
    //  - 3 property accessors ( Title - string
    //                           Text  - string
    //                           Tags  - string array )
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string[] Tags { get; set; }

        public Note(string title, string text, string[] tags)
        {
            //Class constructor
            //Class parameters :
            //  -Values for class properties  ( Title - Text  - Tags )
            Title = title;
            Text = text;
            Tags = tags;
        }
    }
}
