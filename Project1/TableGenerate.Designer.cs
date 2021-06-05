
namespace Project1
{
    partial class TableGenerate
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
            this.panelChild = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtnLocation = new FontAwesome.Sharp.IconButton();
            this.iconBtnStudet = new FontAwesome.Sharp.IconButton();
            this.iconLecturer = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.White;
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(0, 138);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1326, 748);
            this.panelChild.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sesion And Not-Available Time Allocation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconBtnLocation);
            this.panel1.Controls.Add(this.iconBtnStudet);
            this.panel1.Controls.Add(this.iconLecturer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 138);
            this.panel1.TabIndex = 14;
            // 
            // iconBtnLocation
            // 
            this.iconBtnLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.iconBtnLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnLocation.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnLocation.ForeColor = System.Drawing.Color.Black;
            this.iconBtnLocation.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnLocation.IconColor = System.Drawing.Color.Black;
            this.iconBtnLocation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnLocation.Location = new System.Drawing.Point(761, 60);
            this.iconBtnLocation.Name = "iconBtnLocation";
            this.iconBtnLocation.Size = new System.Drawing.Size(173, 55);
            this.iconBtnLocation.TabIndex = 1;
            this.iconBtnLocation.Text = "Location";
            this.iconBtnLocation.UseVisualStyleBackColor = false;
            this.iconBtnLocation.Click += new System.EventHandler(this.iconBtnLocation_Click);
            // 
            // iconBtnStudet
            // 
            this.iconBtnStudet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.iconBtnStudet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnStudet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnStudet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnStudet.ForeColor = System.Drawing.Color.Black;
            this.iconBtnStudet.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnStudet.IconColor = System.Drawing.Color.Black;
            this.iconBtnStudet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnStudet.Location = new System.Drawing.Point(512, 60);
            this.iconBtnStudet.Name = "iconBtnStudet";
            this.iconBtnStudet.Size = new System.Drawing.Size(173, 55);
            this.iconBtnStudet.TabIndex = 1;
            this.iconBtnStudet.Text = "Student";
            this.iconBtnStudet.UseVisualStyleBackColor = false;
            this.iconBtnStudet.Click += new System.EventHandler(this.iconBtnStudet_Click);
            // 
            // iconLecturer
            // 
            this.iconLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.iconLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLecturer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLecturer.ForeColor = System.Drawing.Color.Black;
            this.iconLecturer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconLecturer.IconColor = System.Drawing.Color.Black;
            this.iconLecturer.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconLecturer.Location = new System.Drawing.Point(254, 60);
            this.iconLecturer.Name = "iconLecturer";
            this.iconLecturer.Size = new System.Drawing.Size(173, 55);
            this.iconLecturer.TabIndex = 1;
            this.iconLecturer.Text = "Lecturer";
            this.iconLecturer.UseVisualStyleBackColor = false;
            this.iconLecturer.Click += new System.EventHandler(this.iconLecturer_Click);
            // 
            // TableGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 886);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel1);
            this.Name = "TableGenerate";
            this.Text = "TableGenerate";
            this.Load += new System.EventHandler(this.TableGenerate_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnLocation;
        private FontAwesome.Sharp.IconButton iconBtnStudet;
        private FontAwesome.Sharp.IconButton iconLecturer;
    }
}