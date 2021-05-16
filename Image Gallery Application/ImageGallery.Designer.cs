using C1.C1Pdf;

namespace ImageGallery_Application
{
    partial class ImageGalleryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageGalleryForm));
            C1.Win.C1Tile.PanelElement panelElement1 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement1 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement1 = new C1.Win.C1Tile.TextElement();
            this.splitContainer1main = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._searchboxx = new System.Windows.Forms.TextBox();
            this.panel3usedforsearchbutton = new System.Windows.Forms.Panel();
            this._searchh = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this._imageTileControl = new C1.Win.C1Tile.C1TileControl();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tile1 = new C1.Win.C1Tile.Tile();
            this.tile2 = new C1.Win.C1Tile.Tile();
            this.tile3 = new C1.Win.C1Tile.Tile();
            this._exportImage = new System.Windows.Forms.PictureBox();
            this.panel1forsearchtextcol = new System.Windows.Forms.Panel();
            this._searchbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._search = new System.Windows.Forms.PictureBox();
            this.c1PdfDocument1 = new C1.C1Pdf.C1PdfDocument();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1main)).BeginInit();
            this.splitContainer1main.Panel1.SuspendLayout();
            this.splitContainer1main.Panel2.SuspendLayout();
            this.splitContainer1main.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3usedforsearchbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._searchh)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).BeginInit();
            this.panel1forsearchtextcol.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1main
            // 
            this.splitContainer1main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1main.IsSplitterFixed = true;
            this.splitContainer1main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1main.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1main.Name = "splitContainer1main";
            this.splitContainer1main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1main.Panel1
            // 
            this.splitContainer1main.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1main.Panel1.Controls.Add(this.statusLabel);
            this.splitContainer1main.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1main_Panel1_Paint);
            // 
            // splitContainer1main.Panel2
            // 
            this.splitContainer1main.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1main.Panel2.Controls.Add(this.vScrollBar1);
            this.splitContainer1main.Panel2.Controls.Add(this.label1);
            this.splitContainer1main.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1main.Panel2.Controls.Add(this._imageTileControl);
            this.splitContainer1main.Panel2.Controls.Add(this._exportImage);
            this.splitContainer1main.Size = new System.Drawing.Size(784, 749);
            this.splitContainer1main.SplitterDistance = 40;
            this.splitContainer1main.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3usedforsearchbutton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 40);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._searchboxx);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(199, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 34);
            this.panel2.TabIndex = 0;
            // 
            // _searchboxx
            // 
            this._searchboxx.BackColor = System.Drawing.SystemColors.Window;
            this._searchboxx.Dock = System.Windows.Forms.DockStyle.Fill;
            this._searchboxx.Location = new System.Drawing.Point(0, 0);
            this._searchboxx.Name = "_searchboxx";
            this._searchboxx.Size = new System.Drawing.Size(288, 20);
            this._searchboxx.TabIndex = 0;
            this._searchboxx.Text = "Search Image ";
            this._searchboxx.Click += new System.EventHandler(this._searchboxx_ClickAsync);
            this._searchboxx.TextChanged += new System.EventHandler(this._searchboxx_TextChanged);
            // 
            // panel3usedforsearchbutton
            // 
            this.panel3usedforsearchbutton.Controls.Add(this._searchh);
            this.panel3usedforsearchbutton.Location = new System.Drawing.Point(492, 12);
            this.panel3usedforsearchbutton.Margin = new System.Windows.Forms.Padding(2, 12, 45, 12);
            this.panel3usedforsearchbutton.Name = "panel3usedforsearchbutton";
            this.panel3usedforsearchbutton.Size = new System.Drawing.Size(40, 16);
            this.panel3usedforsearchbutton.TabIndex = 1;
            // 
            // _searchh
            // 
            this._searchh.Dock = System.Windows.Forms.DockStyle.Left;
            this._searchh.Image = ((System.Drawing.Image)(resources.GetObject("_searchh.Image")));
            this._searchh.Location = new System.Drawing.Point(0, 0);
            this._searchh.Margin = new System.Windows.Forms.Padding(0);
            this._searchh.Name = "_searchh";
            this._searchh.Size = new System.Drawing.Size(40, 16);
            this._searchh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._searchh.TabIndex = 0;
            this._searchh.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 24);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(762, 76);
            this.vScrollBar1.Maximum = 13;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 645);
            this.vScrollBar1.TabIndex = 4;
            // this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 15);
            this.label1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(135, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // _imageTileControl
            // 
            this._imageTileControl.AllowChecking = true;
            this._imageTileControl.AllowRearranging = true;
            this._imageTileControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._imageTileControl.CellHeight = 78;
            this._imageTileControl.CellSpacing = 11;
            this._imageTileControl.CellWidth = 78;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this._imageTileControl.DefaultTemplate.Elements.Add(panelElement1);
            this._imageTileControl.Groups.Add(this.group1);
            this._imageTileControl.Location = new System.Drawing.Point(3, 37);
            this._imageTileControl.Name = "_imageTileControl";
            this._imageTileControl.Size = new System.Drawing.Size(778, 665);
            this._imageTileControl.SurfacePadding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this._imageTileControl.SwipeDistance = 20;
            this._imageTileControl.SwipeRearrangeDistance = 98;
            this._imageTileControl.TabIndex = 1;
            this._imageTileControl.TileChecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileChecked);
            this._imageTileControl.TileUnchecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileUnchecked);
            this._imageTileControl.Paint += new System.Windows.Forms.PaintEventHandler(this._imageTileControl_Paint);
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.LightCoral;
            this.tile1.Name = "tile1";
            this.tile1.Text = "Tile 1";
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.Teal;
            this.tile2.Name = "tile2";
            this.tile2.Text = "Tile 2";
            this.tile2.Click += new System.EventHandler(this.tile2_Click);
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.SteelBlue;
            this.tile3.Name = "tile3";
            this.tile3.Text = "Tile 3";
            // 
            // _exportImage
            // 
            this._exportImage.Image = ((System.Drawing.Image)(resources.GetObject("_exportImage.Image")));
            this._exportImage.Location = new System.Drawing.Point(29, 3);
            this._exportImage.Name = "_exportImage";
            this._exportImage.Size = new System.Drawing.Size(135, 28);
            this._exportImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._exportImage.TabIndex = 0;
            this._exportImage.TabStop = false;
            this._exportImage.Visible = false;
            this._exportImage.Click += new System.EventHandler(this._exportImage_Click);
            this._exportImage.Paint += new System.Windows.Forms.PaintEventHandler(this._exportImage_Paint);
            // 
            // panel1forsearchtextcol
            // 
            this.panel1forsearchtextcol.Controls.Add(this._searchbox);
            this.panel1forsearchtextcol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1forsearchtextcol.Location = new System.Drawing.Point(199, 3);
            this.panel1forsearchtextcol.Name = "panel1forsearchtextcol";
            this.panel1forsearchtextcol.Size = new System.Drawing.Size(288, 34);
            this.panel1forsearchtextcol.TabIndex = 0;
            this.panel1forsearchtextcol.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1forsearchtextcol_Paint);
            // 
            // _searchbox
            // 
            this._searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._searchbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._searchbox.Location = new System.Drawing.Point(0, 0);
            this._searchbox.Name = "_searchbox";
            this._searchbox.Size = new System.Drawing.Size(288, 13);
            this._searchbox.TabIndex = 0;
            this._searchbox.Text = "Search Image ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._search);
            this.panel1.Location = new System.Drawing.Point(492, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 12, 45, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 16);
            this.panel1.TabIndex = 1;
            // 
            // _search
            // 
            this._search.Dock = System.Windows.Forms.DockStyle.Left;
            this._search.Image = ((System.Drawing.Image)(resources.GetObject("_search.Image")));
            this._search.Location = new System.Drawing.Point(0, 0);
            this._search.Margin = new System.Windows.Forms.Padding(0);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(40, 16);
            this._search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._search.TabIndex = 0;
            this._search.TabStop = false;
            // 
            // c1PdfDocument1
            // 
            this.c1PdfDocument1.DocumentInfo.Author = "";
            this.c1PdfDocument1.DocumentInfo.CreationDate = new System.DateTime(((long)(0)));
            this.c1PdfDocument1.DocumentInfo.Creator = "";
            this.c1PdfDocument1.DocumentInfo.Keywords = "";
            this.c1PdfDocument1.DocumentInfo.Producer = "ComponentOne C1Pdf";
            this.c1PdfDocument1.DocumentInfo.Subject = "";
            this.c1PdfDocument1.DocumentInfo.Title = "";
            this.c1PdfDocument1.MaxHeaderBookmarkLevel = 0;
            this.c1PdfDocument1.PdfVersion = "1.3";
            this.c1PdfDocument1.RefDC = null;
            this.c1PdfDocument1.RotateAngle = 0F;
            this.c1PdfDocument1.UseFastTextOut = true;
            this.c1PdfDocument1.UseFontShaping = true;
            // 
            // ImageGalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.splitContainer1main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 810);
            this.Name = "ImageGalleryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Gallery ";
            this.Load += new System.EventHandler(this.ImageGalleryForm_Load);
            this.splitContainer1main.Panel1.ResumeLayout(false);
            this.splitContainer1main.Panel1.PerformLayout();
            this.splitContainer1main.Panel2.ResumeLayout(false);
            this.splitContainer1main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1main)).EndInit();
            this.splitContainer1main.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3usedforsearchbutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._searchh)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).EndInit();
            this.panel1forsearchtextcol.ResumeLayout(false);
            this.panel1forsearchtextcol.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
    }
}

