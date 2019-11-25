namespace CoachUI
{
    partial class Form1
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.SeatTextBox = new System.Windows.Forms.TextBox();
            this.AddLabel2 = new System.Windows.Forms.Label();
            this.AddLabel1 = new System.Windows.Forms.Label();
            this.AddLabel3 = new System.Windows.Forms.Label();
            this.AddLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(297, 70);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(251, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(506, 216);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(142, 58);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove by Name";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(163, 216);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(142, 58);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add To Bus";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.Location = new System.Drawing.Point(329, 216);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(142, 58);
            this.GetButton.TabIndex = 3;
            this.GetButton.Text = "Get by Name";
            this.GetButton.UseVisualStyleBackColor = false;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(329, 339);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(142, 58);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(297, 134);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // SeatTextBox
            // 
            this.SeatTextBox.Location = new System.Drawing.Point(448, 134);
            this.SeatTextBox.Name = "SeatTextBox";
            this.SeatTextBox.Size = new System.Drawing.Size(100, 20);
            this.SeatTextBox.TabIndex = 6;
            // 
            // AddLabel2
            // 
            this.AddLabel2.AutoSize = true;
            this.AddLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLabel2.Location = new System.Drawing.Point(241, 73);
            this.AddLabel2.Name = "AddLabel2";
            this.AddLabel2.Size = new System.Drawing.Size(38, 13);
            this.AddLabel2.TabIndex = 7;
            this.AddLabel2.Text = "Name:";
            // 
            // AddLabel1
            // 
            this.AddLabel1.AutoSize = true;
            this.AddLabel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddLabel1.Location = new System.Drawing.Point(241, 9);
            this.AddLabel1.Name = "AddLabel1";
            this.AddLabel1.Size = new System.Drawing.Size(154, 22);
            this.AddLabel1.TabIndex = 8;
            this.AddLabel1.Text = "Ed\'s Coach Booking";
            // 
            // AddLabel3
            // 
            this.AddLabel3.AutoSize = true;
            this.AddLabel3.Location = new System.Drawing.Point(250, 137);
            this.AddLabel3.Name = "AddLabel3";
            this.AddLabel3.Size = new System.Drawing.Size(29, 13);
            this.AddLabel3.TabIndex = 9;
            this.AddLabel3.Text = "Age:";
            // 
            // AddLabel4
            // 
            this.AddLabel4.AutoSize = true;
            this.AddLabel4.Location = new System.Drawing.Point(413, 137);
            this.AddLabel4.Name = "AddLabel4";
            this.AddLabel4.Size = new System.Drawing.Size(32, 13);
            this.AddLabel4.TabIndex = 10;
            this.AddLabel4.Text = "Seat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddLabel4);
            this.Controls.Add(this.AddLabel3);
            this.Controls.Add(this.AddLabel1);
            this.Controls.Add(this.AddLabel2);
            this.Controls.Add(this.SeatTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox SeatTextBox;
        private System.Windows.Forms.Label AddLabel2;
        private System.Windows.Forms.Label AddLabel1;
        private System.Windows.Forms.Label AddLabel3;
        private System.Windows.Forms.Label AddLabel4;
    }
}

