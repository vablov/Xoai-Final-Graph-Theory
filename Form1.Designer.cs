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
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnAddPoly = new System.Windows.Forms.Button();
            this.btnFindShortestPath = new System.Windows.Forms.Button();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.btndijsktra = new System.Windows.Forms.Button();
            this.btnfrim = new System.Windows.Forms.Button();
            this.txtStartLat = new System.Windows.Forms.TextBox();
            this.txtStartLng = new System.Windows.Forms.TextBox();
            this.txtEndLat = new System.Windows.Forms.TextBox();
            this.txtEndLng = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(541, 592);
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
            this.map.Size = new System.Drawing.Size(567, 592);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            // 
            // lbllat
            // 
            this.lbllat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllat.AutoSize = true;
            this.lbllat.Location = new System.Drawing.Point(572, 49);
            this.lbllat.Name = "lbllat";
            this.lbllat.Size = new System.Drawing.Size(54, 16);
            this.lbllat.TabIndex = 2;
            this.lbllat.Text = "Latitude";
            // 
            // lbllongt
            // 
            this.lbllongt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllongt.AutoSize = true;
            this.lbllongt.Location = new System.Drawing.Point(572, 86);
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
            this.btnsatt.Location = new System.Drawing.Point(775, 69);
            this.btnsatt.Name = "btnsatt";
            this.btnsatt.Size = new System.Drawing.Size(86, 39);
            this.btnsatt.TabIndex = 7;
            this.btnsatt.Text = "Satellite";
            this.btnsatt.UseVisualStyleBackColor = true;
            this.btnsatt.Click += new System.EventHandler(this.btnsatt_Click);
            // 
            // btnAddPoint
            // 
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
            // btnFindShortestPath
            // 
            this.btnFindShortestPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindShortestPath.BackColor = System.Drawing.Color.White;
            this.btnFindShortestPath.CausesValidation = false;
            this.btnFindShortestPath.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFindShortestPath.Enabled = false;
            this.btnFindShortestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindShortestPath.Location = new System.Drawing.Point(575, 503);
            this.btnFindShortestPath.Name = "btnFindShortestPath";
            this.btnFindShortestPath.Size = new System.Drawing.Size(157, 54);
            this.btnFindShortestPath.TabIndex = 11;
            this.btnFindShortestPath.Text = "FindShortestPath";
            this.btnFindShortestPath.UseVisualStyleBackColor = false;
            // 
            // lblfrom
            // 
            this.lblfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfrom.AutoSize = true;
            this.lblfrom.Location = new System.Drawing.Point(588, 259);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(38, 16);
            this.lblfrom.TabIndex = 12;
            this.lblfrom.Text = "From";
            // 
            // lblto
            // 
            this.lblto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblto.AutoSize = true;
            this.lblto.Location = new System.Drawing.Point(602, 370);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(24, 16);
            this.lblto.TabIndex = 13;
            this.lblto.Text = "To";
            // 
            // btndijsktra
            // 
            this.btndijsktra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndijsktra.Location = new System.Drawing.Point(760, 540);
            this.btndijsktra.Name = "btndijsktra";
            this.btndijsktra.Size = new System.Drawing.Size(93, 39);
            this.btndijsktra.TabIndex = 18;
            this.btndijsktra.Text = "Dijsktra";
            this.btndijsktra.UseVisualStyleBackColor = true;
            this.btndijsktra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // btnfrim
            // 
            this.btnfrim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfrim.Location = new System.Drawing.Point(760, 487);
            this.btnfrim.Name = "btnfrim";
            this.btnfrim.Size = new System.Drawing.Size(97, 39);
            this.btnfrim.TabIndex = 19;
            this.btnfrim.Text = "Prim";
            this.btnfrim.UseVisualStyleBackColor = true;
            this.btnfrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // txtStartLat
            // 
            this.txtStartLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartLat.Location = new System.Drawing.Point(632, 259);
            this.txtStartLat.Name = "txtStartLat";
            this.txtStartLat.Size = new System.Drawing.Size(100, 22);
            this.txtStartLat.TabIndex = 24;
            // 
            // txtStartLng
            // 
            this.txtStartLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartLng.Location = new System.Drawing.Point(632, 287);
            this.txtStartLng.Name = "txtStartLng";
            this.txtStartLng.Size = new System.Drawing.Size(100, 22);
            this.txtStartLng.TabIndex = 24;
            // 
            // txtEndLat
            // 
            this.txtEndLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndLat.Location = new System.Drawing.Point(632, 364);
            this.txtEndLat.Name = "txtEndLat";
            this.txtEndLat.Size = new System.Drawing.Size(100, 22);
            this.txtEndLat.TabIndex = 24;
            // 
            // txtEndLng
            // 
            this.txtEndLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndLng.Location = new System.Drawing.Point(632, 392);
            this.txtEndLng.Name = "txtEndLng";
            this.txtEndLng.Size = new System.Drawing.Size(100, 22);
            this.txtEndLng.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(873, 592);
            this.Controls.Add(this.txtEndLng);
            this.Controls.Add(this.txtEndLat);
            this.Controls.Add(this.txtStartLng);
            this.Controls.Add(this.txtStartLat);
            this.Controls.Add(this.btnfrim);
            this.Controls.Add(this.btndijsktra);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.btnFindShortestPath);
            this.Controls.Add(this.btnAddPoly);
            this.Controls.Add(this.btnAddPoint);
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
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnAddPoly;
        private System.Windows.Forms.Button btnFindShortestPath;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Button btndijsktra;
        private System.Windows.Forms.Button btnfrim;
        private System.Windows.Forms.TextBox txtStartLat;
        private System.Windows.Forms.TextBox txtStartLng;
        private System.Windows.Forms.TextBox txtEndLat;
        private System.Windows.Forms.TextBox txtEndLng;
    }
}

