namespace Storyboard
{
    partial class gbNote
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_Note = new System.Windows.Forms.GroupBox();
            this.lb_Note_Tags = new System.Windows.Forms.Label();
            this.lb_Note_Text = new System.Windows.Forms.Label();
            this.lb_Note_Title = new System.Windows.Forms.Label();
            this.lb_Tags = new System.Windows.Forms.Label();
            this.lb_Text = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.grp_Note.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Note
            // 
            this.grp_Note.Controls.Add(this.lb_Note_Tags);
            this.grp_Note.Controls.Add(this.lb_Note_Text);
            this.grp_Note.Controls.Add(this.lb_Note_Title);
            this.grp_Note.Controls.Add(this.lb_Tags);
            this.grp_Note.Controls.Add(this.lb_Text);
            this.grp_Note.Controls.Add(this.lb_Title);
            this.grp_Note.Location = new System.Drawing.Point(3, 3);
            this.grp_Note.Name = "grp_Note";
            this.grp_Note.Size = new System.Drawing.Size(451, 98);
            this.grp_Note.TabIndex = 4;
            this.grp_Note.TabStop = false;
            this.grp_Note.Text = "Note";
            // 
            // lb_Note_Tags
            // 
            this.lb_Note_Tags.AutoSize = true;
            this.lb_Note_Tags.Location = new System.Drawing.Point(48, 74);
            this.lb_Note_Tags.Name = "lb_Note_Tags";
            this.lb_Note_Tags.Size = new System.Drawing.Size(0, 13);
            this.lb_Note_Tags.TabIndex = 3;
            // 
            // lb_Note_Text
            // 
            this.lb_Note_Text.AutoSize = true;
            this.lb_Note_Text.Location = new System.Drawing.Point(48, 48);
            this.lb_Note_Text.Name = "lb_Note_Text";
            this.lb_Note_Text.Size = new System.Drawing.Size(0, 13);
            this.lb_Note_Text.TabIndex = 3;
            // 
            // lb_Note_Title
            // 
            this.lb_Note_Title.AutoSize = true;
            this.lb_Note_Title.Location = new System.Drawing.Point(48, 22);
            this.lb_Note_Title.Name = "lb_Note_Title";
            this.lb_Note_Title.Size = new System.Drawing.Size(0, 13);
            this.lb_Note_Title.TabIndex = 3;
            // 
            // lb_Tags
            // 
            this.lb_Tags.AutoSize = true;
            this.lb_Tags.Location = new System.Drawing.Point(6, 74);
            this.lb_Tags.Name = "lb_Tags";
            this.lb_Tags.Size = new System.Drawing.Size(30, 13);
            this.lb_Tags.TabIndex = 2;
            this.lb_Tags.Text = "Tags";
            // 
            // lb_Text
            // 
            this.lb_Text.AutoSize = true;
            this.lb_Text.Location = new System.Drawing.Point(6, 48);
            this.lb_Text.Name = "lb_Text";
            this.lb_Text.Size = new System.Drawing.Size(29, 13);
            this.lb_Text.TabIndex = 1;
            this.lb_Text.Text = "Text";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Location = new System.Drawing.Point(3, 22);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(27, 13);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Title";
            // 
            // gbNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grp_Note);
            this.Name = "gbNote";
            this.Size = new System.Drawing.Size(460, 110);
            this.grp_Note.ResumeLayout(false);
            this.grp_Note.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Note;
        private System.Windows.Forms.Label lb_Note_Tags;
        private System.Windows.Forms.Label lb_Note_Text;
        private System.Windows.Forms.Label lb_Note_Title;
        private System.Windows.Forms.Label lb_Tags;
        private System.Windows.Forms.Label lb_Text;
        private System.Windows.Forms.Label lb_Title;
    }
}
