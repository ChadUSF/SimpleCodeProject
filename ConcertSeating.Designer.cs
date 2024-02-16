
namespace ISM3232_Final_Project
{
    partial class FormConcertSeating
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSeatSection = new System.Windows.Forms.TextBox();
            this.pictureBoxSeatingChart = new System.Windows.Forms.PictureBox();
            this.labelSeatSection = new System.Windows.Forms.Label();
            this.listBoxSeats = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelNumberSeats = new System.Windows.Forms.Label();
            this.labelSeatCount = new System.Windows.Forms.Label();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.labelFormHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeatingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(82, 129);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 29);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "&Add to List";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSeatSection
            // 
            this.textBoxSeatSection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSeatSection.Location = new System.Drawing.Point(49, 96);
            this.textBoxSeatSection.Name = "textBoxSeatSection";
            this.textBoxSeatSection.Size = new System.Drawing.Size(150, 27);
            this.textBoxSeatSection.TabIndex = 0;
            // 
            // pictureBoxSeatingChart
            // 
            this.pictureBoxSeatingChart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxSeatingChart.BackgroundImage = global::ISM3232_Final_Project.Properties.Resources.Seating;
            this.pictureBoxSeatingChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxSeatingChart.Location = new System.Drawing.Point(233, 66);
            this.pictureBoxSeatingChart.Name = "pictureBoxSeatingChart";
            this.pictureBoxSeatingChart.Size = new System.Drawing.Size(555, 460);
            this.pictureBoxSeatingChart.TabIndex = 2;
            this.pictureBoxSeatingChart.TabStop = false;
            // 
            // labelSeatSection
            // 
            this.labelSeatSection.AutoSize = true;
            this.labelSeatSection.Location = new System.Drawing.Point(64, 73);
            this.labelSeatSection.Name = "labelSeatSection";
            this.labelSeatSection.Size = new System.Drawing.Size(135, 20);
            this.labelSeatSection.TabIndex = 3;
            this.labelSeatSection.Text = "Enter section color:";
            // 
            // listBoxSeats
            // 
            this.listBoxSeats.FormattingEnabled = true;
            this.listBoxSeats.ItemHeight = 20;
            this.listBoxSeats.Location = new System.Drawing.Point(49, 180);
            this.listBoxSeats.Name = "listBoxSeats";
            this.listBoxSeats.Size = new System.Drawing.Size(150, 124);
            this.listBoxSeats.TabIndex = 5;
            this.listBoxSeats.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(65, 442);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(134, 29);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "C&LEAR ALL";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(65, 478);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(134, 29);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(15, 415);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(78, 20);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total Cost:";
            // 
            // labelCost
            // 
            this.labelCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCost.Location = new System.Drawing.Point(99, 405);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(100, 30);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "$0";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumberSeats
            // 
            this.labelNumberSeats.AutoSize = true;
            this.labelNumberSeats.Location = new System.Drawing.Point(56, 329);
            this.labelNumberSeats.Name = "labelNumberSeats";
            this.labelNumberSeats.Size = new System.Drawing.Size(84, 20);
            this.labelNumberSeats.TabIndex = 10;
            this.labelNumberSeats.Text = "Total Seats:";
            // 
            // labelSeatCount
            // 
            this.labelSeatCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeatCount.Location = new System.Drawing.Point(145, 319);
            this.labelSeatCount.Name = "labelSeatCount";
            this.labelSeatCount.Size = new System.Drawing.Size(54, 30);
            this.labelSeatCount.TabIndex = 11;
            this.labelSeatCount.Text = "0";
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(82, 372);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(117, 30);
            this.buttonTotal.TabIndex = 3;
            this.buttonTotal.Text = "&Calculate Total";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // labelFormHeader
            // 
            this.labelFormHeader.Font = new System.Drawing.Font("Goudy Old Style", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelFormHeader.Location = new System.Drawing.Point(1, 9);
            this.labelFormHeader.Name = "labelFormHeader";
            this.labelFormHeader.Size = new System.Drawing.Size(799, 39);
            this.labelFormHeader.TabIndex = 12;
            this.labelFormHeader.Text = "Where to Want to Sit?";
            this.labelFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConcertSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.labelFormHeader);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.labelSeatCount);
            this.Controls.Add(this.labelNumberSeats);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxSeats);
            this.Controls.Add(this.labelSeatSection);
            this.Controls.Add(this.pictureBoxSeatingChart);
            this.Controls.Add(this.textBoxSeatSection);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormConcertSeating";
            this.Text = "Concert Seating Seat Selection Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeatingChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxSeatSection;
        private System.Windows.Forms.PictureBox pictureBoxSeatingChart;
        private System.Windows.Forms.Label labelSeatSection;
        private System.Windows.Forms.ListBox listBoxSeats;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelNumberSeats;
        private System.Windows.Forms.Label labelSeatCount;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.Label labelFormHeader;
    }
}

