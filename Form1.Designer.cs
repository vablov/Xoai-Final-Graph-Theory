namespace GMap_Sample
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.lbllat = new System.Windows.Forms.Label();
            this.lbllongt = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.btnLoadIntoMap = new System.Windows.Forms.Button();
            this.btnsatt = new System.Windows.Forms.Button();
            this.btmClearList = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnAddPoly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(541, 541);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(558, 541);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            // 
            // lbllat
            // 
            this.lbllat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllat.AutoSize = true;
            this.lbllat.Location = new System.Drawing.Point(564, 49);
            this.lbllat.Name = "lbllat";
            this.lbllat.Size = new System.Drawing.Size(54, 16);
            this.lbllat.TabIndex = 2;
            this.lbllat.Text = "Latitude";
            // 
            // lbllongt
            // 
            this.lbllongt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllongt.AutoSize = true;
            this.lbllongt.Location = new System.Drawing.Point(564, 86);
            this.lbllongt.Name = "lbllongt";
            this.lbllongt.Size = new System.Drawing.Size(66, 16);
            this.lbllongt.TabIndex = 3;
            this.lbllongt.Text = "Longitude\r\n";
            // 
            // txtLat
            // 
            this.txtLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLat.Location = new System.Drawing.Point(653, 49);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 22);
            this.txtLat.TabIndex = 4;
            // 
            // txtLong
            // 
            this.txtLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLong.Location = new System.Drawing.Point(653, 86);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 22);
            this.txtLong.TabIndex = 5;
            // 
            // btnLoadIntoMap
            // 
            this.btnLoadIntoMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadIntoMap.Location = new System.Drawing.Point(567, 132);
            this.btnLoadIntoMap.Name = "btnLoadIntoMap";
            this.btnLoadIntoMap.Size = new System.Drawing.Size(100, 42);
            this.btnLoadIntoMap.TabIndex = 6;
            this.btnLoadIntoMap.Text = "Load Into Map";
            this.btnLoadIntoMap.UseVisualStyleBackColor = true;
            this.btnLoadIntoMap.Click += new System.EventHandler(this.btnLoadIntoMap_Click);
            // 
            // btnsatt
            // 
            this.btnsatt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsatt.Location = new System.Drawing.Point(775, 12);
            this.btnsatt.Name = "btnsatt";
            this.btnsatt.Size = new System.Drawing.Size(86, 39);
            this.btnsatt.TabIndex = 7;
            this.btnsatt.Text = "Satellite";
            this.btnsatt.UseVisualStyleBackColor = true;
            this.btnsatt.Click += new System.EventHandler(this.btnsatt_Click);
            // 
            // btmClearList
            // 
            this.btmClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmClearList.Location = new System.Drawing.Point(775, 72);
            this.btmClearList.Name = "btmClearList";
            this.btmClearList.Size = new System.Drawing.Size(86, 35);
            this.btmClearList.TabIndex = 8;
            this.btmClearList.Text = "Clear";
            this.btmClearList.UseVisualStyleBackColor = true;
//            this.btmClearList.Click += new System.EventHandler(this.btmClearList_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPoint.Location = new System.Drawing.Point(673, 132);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(85, 42);
            this.btnAddPoint.TabIndex = 9;
            this.btnAddPoint.Text = "Add Point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnAddPoly
            // 
            this.btnAddPoly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPoly.Location = new System.Drawing.Point(764, 132);
            this.btnAddPoly.Name = "btnAddPoly";
            this.btnAddPoly.Size = new System.Drawing.Size(97, 42);
            this.btnAddPoly.TabIndex = 10;
            this.btnAddPoly.Text = "Demilit";
            this.btnAddPoly.UseVisualStyleBackColor = true;
            this.btnAddPoly.Click += new System.EventHandler(this.btnAddPoly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(873, 541);
            this.Controls.Add(this.btnAddPoly);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.btmClearList);
            this.Controls.Add(this.btnsatt);
            this.Controls.Add(this.btnLoadIntoMap);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.lbllongt);
            this.Controls.Add(this.lbllat);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label lbllat;
        private System.Windows.Forms.Label lbllongt;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Button btnLoadIntoMap;
        private System.Windows.Forms.Button btnsatt;
        private System.Windows.Forms.Button btmClearList;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnAddPoly;
    }
}

