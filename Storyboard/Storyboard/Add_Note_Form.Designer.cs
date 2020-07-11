namespace Storyboard
{
    partial class Add_Note_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_AddNote = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lb_Tags = new System.Windows.Forms.Label();
            this.txt_Tags = new System.Windows.Forms.TextBox();
            this.lb_Text = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Text = new System.Windows.Forms.TextBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.grb_AddNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_AddNote
            // 
            this.grb_AddNote.Controls.Add(this.btn_Add);
            this.grb_AddNote.Controls.Add(this.btn_Clear);
            this.grb_AddNote.Controls.Add(this.lb_Tags);
            this.grb_AddNote.Controls.Add(this.txt_Tags);
            this.grb_AddNote.Controls.Add(this.lb_Text);
            this.grb_AddNote.Controls.Add(this.txt_Title);
            this.grb_AddNote.Controls.Add(this.txt_Text);
            this.grb_AddNote.Controls.Add(this.lb_Title);
            this.grb_AddNote.Location = new System.Drawing.Point(12, 12);
            this.grb_AddNote.Name = "grb_AddNote";
            this.grb_AddNote.Size = new System.Drawing.Size(451, 130);
            this.grb_AddNote.TabIndex = 4;
            this.grb_AddNote.TabStop = false;
            this.grb_AddNote.Text = "Add Note";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(289, 19);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(370, 19);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lb_Tags
            // 
            this.lb_Tags.AutoSize = true;
            this.lb_Tags.Location = new System.Drawing.Point(6, 103);
            this.lb_Tags.Name = "lb_Tags";
            this.lb_Tags.Size = new System.Drawing.Size(30, 13);
            this.lb_Tags.TabIndex = 2;
            this.lb_Tags.Text = "Tags";
            // 
            // txt_Tags
            // 
            this.txt_Tags.Location = new System.Drawing.Point(39, 100);
            this.txt_Tags.Name = "txt_Tags";
            this.txt_Tags.Size = new System.Drawing.Size(406, 20);
            this.txt_Tags.TabIndex = 5;
            // 
            // lb_Text
            // 
            this.lb_Text.AutoSize = true;
            this.lb_Text.Location = new System.Drawing.Point(6, 77);
            this.lb_Text.Name = "lb_Text";
            this.lb_Text.Size = new System.Drawing.Size(29, 13);
            this.lb_Text.TabIndex = 1;
            this.lb_Text.Text = "Text";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(39, 48);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(406, 20);
            this.txt_Title.TabIndex = 4;
            // 
            // txt_Text
            // 
            this.txt_Text.Location = new System.Drawing.Point(39, 74);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(406, 20);
            this.txt_Text.TabIndex = 4;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Location = new System.Drawing.Point(6, 51);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(27, 13);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Title";
            // 
            // Add_Note_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 151);
            this.Controls.Add(this.grb_AddNote);
            this.Name = "Add_Note_Form";
            this.Text = "Add Note";
            this.grb_AddNote.ResumeLayout(false);
            this.grb_AddNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_AddNote;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lb_Tags;
        private System.Windows.Forms.TextBox txt_Tags;
        private System.Windows.Forms.Label lb_Text;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Text;
        private System.Windows.Forms.Label lb_Title;
    }
}