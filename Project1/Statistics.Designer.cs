
namespace WD_R_14
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRoom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartRoom1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuilding = new FontAwesome.Sharp.IconButton();
            this.btnRooms = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoom1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartRoom
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRoom.ChartAreas.Add(chartArea1);
            this.chartRoom.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chartRoom.Legends.Add(legend1);
            this.chartRoom.Location = new System.Drawing.Point(155, 119);
            this.chartRoom.Name = "chartRoom";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Goldenrod;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Rooms";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartRoom.Series.Add(series1);
            this.chartRoom.Size = new System.Drawing.Size(266, 277);
            this.chartRoom.TabIndex = 1;
            this.chartRoom.Text = "chart1";
            this.chartRoom.Click += new System.EventHandler(this.chartRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(352, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(208, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Registered Rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(472, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Registered Room Located in Building";
            // 
            // chartRoom1
            // 
            chartArea2.AxisX2.CustomLabels.Add(customLabel1);
            chartArea2.AxisX2.CustomLabels.Add(customLabel2);
            chartArea2.AxisX2.CustomLabels.Add(customLabel3);
            chartArea2.AxisX2.CustomLabels.Add(customLabel4);
            chartArea2.Name = "ChartArea1";
            this.chartRoom1.ChartAreas.Add(chartArea2);
            this.chartRoom1.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            this.chartRoom1.Legends.Add(legend2);
            this.chartRoom1.Location = new System.Drawing.Point(454, 127);
            this.chartRoom1.Name = "chartRoom1";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.ForestGreen;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerSize = 1;
            series2.Name = "Buildings";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartRoom1.Series.Add(series2);
            this.chartRoom1.Size = new System.Drawing.Size(266, 277);
            this.chartRoom1.TabIndex = 21;
            this.chartRoom1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(726, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 133);
            this.label4.TabIndex = 22;
            this.label4.Text = "1 - Business Building\r\n2 - Main Building\r\n3 - Engineering Building\r\n4 - New Build" +
    "ing\r\n\r\n\r\n\r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuilding);
            this.panel1.Controls.Add(this.btnRooms);
            this.panel1.Controls.Add(this.chartRoom1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 609);
            this.panel1.TabIndex = 23;
            // 
            // btnBuilding
            // 
            this.btnBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuilding.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuilding.ForeColor = System.Drawing.Color.White;
            this.btnBuilding.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnBuilding.IconColor = System.Drawing.Color.White;
            this.btnBuilding.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuilding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuilding.Location = new System.Drawing.Point(584, 509);
            this.btnBuilding.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuilding.Name = "btnBuilding";
            this.btnBuilding.Size = new System.Drawing.Size(136, 46);
            this.btnBuilding.TabIndex = 87;
            this.btnBuilding.Text = "Buildings";
            this.btnBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuilding.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuilding.UseVisualStyleBackColor = false;
            this.btnBuilding.Click += new System.EventHandler(this.btnBuilding_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.White;
            this.btnRooms.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnRooms.IconColor = System.Drawing.Color.White;
            this.btnRooms.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.Location = new System.Drawing.Point(255, 509);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(2);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(118, 46);
            this.btnRooms.TabIndex = 86;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 609);
            this.Controls.Add(this.chartRoom);
            this.Controls.Add(this.panel1);
            this.Name = "Statistics";
            this.Text = " Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoom1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRoom1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton btnBuilding;
        public FontAwesome.Sharp.IconButton btnRooms;
    }
}