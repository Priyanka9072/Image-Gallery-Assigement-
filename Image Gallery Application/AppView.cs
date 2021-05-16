using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1Tile;

namespace ImageGallery_Application
{
    class AppView
    {
        public static TableLayoutPanel GetTableLayoutPanel()
        {
            TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            //tableLayoutPanel1.Controls.Add(panel1forsearchtextcol, 1, 0);
            //tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel1";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(784, 40);
            tableLayoutPanel2.TabIndex = 0;

            return tableLayoutPanel2;
        }

        public static Panel GetPanel()
        {
            Panel panel1forsearchtextcol = new Panel
            {
                //Controls.Add(_searchbox),
                Dock = DockStyle.Fill,
                Location = new System.Drawing.Point(199, 3),
                Name = "panel1forsearchtextcol",
                Size = new System.Drawing.Size(288, 34),
                TabIndex = 0,
                //panel1forsearchtextcol.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1forsearchtextcol_Paint);
            };
            return panel1forsearchtextcol;

        }

        public static SplitContainer GetSplitContainer()
        {
            SplitContainer splitContainer1main = new SplitContainer()
            {
                Dock = DockStyle.Fill,
                FixedPanel = FixedPanel.Panel1,
                IsSplitterFixed = true,
                Location = new System.Drawing.Point(0, 0),
                Margin = new System.Windows.Forms.Padding(2),
                Name = "splitContainer1main",
                Orientation = System.Windows.Forms.Orientation.Horizontal,
            };
            return splitContainer1main;
        }

        public static TextBox GetSearchBox()
        {
            TextBox _searchBox = new TextBox
            {
                BorderStyle = System.Windows.Forms.BorderStyle.None,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(0, 0),
                Name = "_searchbox",
                Size = new System.Drawing.Size(288, 13),
                TabIndex = 0,
                Text = "Search Image ",
            };
            return _searchBox;
        }

        public static PictureBox GetSearchImagePictureBox()
        {
            PictureBox _search = new PictureBox
            {
                Dock = System.Windows.Forms.DockStyle.Left,
                Image = Properties.Resources.download,
                Location = new Point(0, 0),
                Margin = new Padding(0),
                Name = "_search",
                Size = new Size(40, 16),
                //FileMode = PictureBoxSizeMode.Zoom,
                TabIndex = 0,
                 TabStop = false,
             };
            return _search;
        }

        public static PictureBox GetExportPDFButton()
        {
            PictureBox _exportImage = new PictureBox
            {
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
                Image = Properties.Resources.ExportToPdf,
                Location = new Point(20, 46),
                Margin = new Padding(20, 3, 3, 10),
                Name = "_exportImage",
                Size = new Size(135, 28),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 2,
                TabStop = false,
                Visible = false
            };

            return _exportImage;
        }

        public static Group GetGroup()
        {
            Group group1 = new Group
            {
                Name = "group1",
                Visible = false
            };
            return group1;
        }

        public static C1TileControl GetTileCntrol()
        {
            C1TileControl _imageTileControl = new C1TileControl
            {
                AllowChecking = true,
                AllowRearranging = true,
                CellHeight = 78,
                CellSpacing = 11,
                CellWidth = 78,
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "_imageTileControl",
                Orientation = LayoutOrientation.Vertical,
                Padding = new Padding(0),
                Size = new Size(784, 573),
                SurfacePadding = new Padding(12, 4, 12, 4),
                SwipeDistance = 20,
                SwipeRearrangeDistance = 98,
                TabIndex = 1,
                TextSize = 0F
            };
            return _imageTileControl;
        }

        public static ToolStripProgressBar GetProgressBarTool()
        {
            ToolStripProgressBar toolStripProgressBar1 = new ToolStripProgressBar
            {
                Name = "toolStripProgressBar1",
                Size = new Size(135, 16),
                Style = ProgressBarStyle.Marquee
            };
            return toolStripProgressBar1;
        }

        public static StatusStrip GetStatusStrip()
        //done
        {
            StatusStrip statusStrip1 = new StatusStrip
            {
                Location = new Point(0, 683),
                Name = "statusStrip1",
                Size = new Size(784, 22),
                TabIndex = 2,
                Text = "statusStrip1",
                Visible = false
            };
            return statusStrip1;
        }

        public static Label GetStausLabel()
        {
            Label statusLabel = new Label
            {
                Cursor = Cursors.Default,
                Dock = DockStyle.Fill,
                Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ControlDarkDark,
                Location = new Point(0, 0),
                Name = "statusLabel",
                Size = new Size(784, 549),
                TabIndex = 4,
                Text = "Initial Status Label",
                TextAlign = ContentAlignment.MiddleCenter,           
            };
            return statusLabel;
        }

        public static Label GetBorder()
        {
            Label label1 = new Label
            {
                BorderStyle = BorderStyle.Fixed3D,
                Dock = DockStyle.Top,
                Location = new Point(0, 0),
                Name = "label1",
                Size = new Size(784, 2),
                TabIndex = 3,
        };
            return label1;
        }

        public static VScrollBar GetVScrollBar()
        {
            VScrollBar vScrollBar1 = new VScrollBar()
            {
                Location = new System.Drawing.Point(762, 85),
                Maximum = 13,
                Name = "vScrollBar1",
                Size = new System.Drawing.Size(22, 636),
                TabIndex = 4,
                //Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll),
            };
            return vScrollBar1;
        }
    }
}
