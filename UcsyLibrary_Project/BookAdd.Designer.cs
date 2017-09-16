namespace UcsyLibrary_Project
{
    partial class BookAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.name_input = new System.Windows.Forms.TextBox();
            this.type_input = new System.Windows.Forms.TextBox();
            this.author_input = new System.Windows.Forms.TextBox();
            this.country_input = new System.Windows.Forms.TextBox();
            this.date_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(108, 24);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(138, 20);
            this.name_input.TabIndex = 6;
            // 
            // type_input
            // 
            this.type_input.Location = new System.Drawing.Point(108, 50);
            this.type_input.Name = "type_input";
            this.type_input.Size = new System.Drawing.Size(138, 20);
            this.type_input.TabIndex = 7;
            // 
            // author_input
            // 
            this.author_input.Location = new System.Drawing.Point(108, 76);
            this.author_input.Name = "author_input";
            this.author_input.Size = new System.Drawing.Size(138, 20);
            this.author_input.TabIndex = 8;
            // 
            // country_input
            // 
            this.country_input.Location = new System.Drawing.Point(108, 102);
            this.country_input.Name = "country_input";
            this.country_input.Size = new System.Drawing.Size(138, 20);
            this.country_input.TabIndex = 9;
            // 
            // date_input
            // 
            this.date_input.Location = new System.Drawing.Point(108, 128);
            this.date_input.Name = "date_input";
            this.date_input.Size = new System.Drawing.Size(138, 20);
            this.date_input.TabIndex = 10;
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 211);
            this.Controls.Add(this.date_input);
            this.Controls.Add(this.country_input);
            this.Controls.Add(this.author_input);
            this.Controls.Add(this.type_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookAdd";
            this.Text = "Book Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox type_input;
        private System.Windows.Forms.TextBox author_input;
        private System.Windows.Forms.TextBox country_input;
        private System.Windows.Forms.TextBox date_input;
    }
}