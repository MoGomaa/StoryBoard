namespace Storyboard
{
    partial class Search_Form
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
            this.grp_Search = new System.Windows.Forms.GroupBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.Rbtn_Text = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.Rbtn_Tag = new System.Windows.Forms.RadioButton();
            this.Rbtn_Title = new System.Windows.Forms.RadioButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.grp_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Search
            // 
            this.grp_Search.Controls.Add(this.lb_Search);
            this.grp_Search.Controls.Add(this.Rbtn_Text);
            this.grp_Search.Controls.Add(this.btn_Search);
            this.grp_Search.Controls.Add(this.Rbtn_Tag);
            this.grp_Search.Controls.Add(this.Rbtn_Title);
            this.grp_Search.Controls.Add(this.txt_Search);
            this.grp_Search.Location = new System.Drawing.Point(12, 12);
            this.grp_Search.Name = "grp_Search";
            this.grp_Search.Size = new System.Drawing.Size(451, 75);
            this.grp_Search.TabIndex = 3;
            this.grp_Search.TabStop = false;
            this.grp_Search.Text = "Search";
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(6, 24);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(62, 13);
            this.lb_Search.TabIndex = 5;
            this.lb_Search.Text = "Search by :";
            // 
            // Rbtn_Text
            // 
            this.Rbtn_Text.AutoSize = true;
            this.Rbtn_Text.Location = new System.Drawing.Point(125, 22);
            this.Rbtn_Text.Name = "Rbtn_Text";
            this.Rbtn_Text.Size = new System.Drawing.Size(47, 17);
            this.Rbtn_Text.TabIndex = 4;
            this.Rbtn_Text.TabStop = true;
            this.Rbtn_Text.Text = "Text";
            this.Rbtn_Text.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(370, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Rbtn_Tag
            // 
            this.Rbtn_Tag.AutoSize = true;
            this.Rbtn_Tag.Location = new System.Drawing.Point(178, 22);
            this.Rbtn_Tag.Name = "Rbtn_Tag";
            this.Rbtn_Tag.Size = new System.Drawing.Size(43, 17);
            this.Rbtn_Tag.TabIndex = 3;
            this.Rbtn_Tag.TabStop = true;
            this.Rbtn_Tag.Text = "Tag";
            this.Rbtn_Tag.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Title
            // 
            this.Rbtn_Title.AutoSize = true;
            this.Rbtn_Title.Location = new System.Drawing.Point(74, 22);
            this.Rbtn_Title.Name = "Rbtn_Title";
            this.Rbtn_Title.Size = new System.Drawing.Size(45, 17);
            this.Rbtn_Title.TabIndex = 2;
            this.Rbtn_Title.TabStop = true;
            this.Rbtn_Title.Text = "Title";
            this.Rbtn_Title.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(6, 45);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(349, 20);
            this.txt_Search.TabIndex = 0;
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 95);
            this.Controls.Add(this.grp_Search);
            this.Name = "Search_Form";
            this.Text = "Search";
            this.grp_Search.ResumeLayout(false);
            this.grp_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.RadioButton Rbtn_Text;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.RadioButton Rbtn_Tag;
        private System.Windows.Forms.RadioButton Rbtn_Title;
        private System.Windows.Forms.TextBox txt_Search;
    }
}