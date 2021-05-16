using C1.Win.C1Tile;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.C1Pdf;
using System.Runtime.InteropServices;
using ImageGallery_Application;
using C1.Framework;
using System.Net.NetworkInformation;
using ImageElement = C1.Win.C1Tile.ImageElement;
using C1.Win.C1ScrollBar;
//using Newtonsoft.Json;

namespace ImageGallery_Application
{
    public partial class ImageGalleryForm : Form, DataFetcher.IStatus
    {
        private System.Windows.Forms.SplitContainer splitContainer1main;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1forsearchtextcol;
        //panel1forsearchtextcol_Paint eventhandler name
        private System.Windows.Forms.TextBox _searchbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox _search;
        //_search_Click event to click on search icon for search image
        private System.Windows.Forms.PictureBox _exportImage;/
        //_exportImage_Click event for click it and export into pdf and also _exportImage_Paint event handler
        private C1.Win.C1Tile.C1TileControl _imageTileControl;
        //_imageTileControl_TileChecked , _imageTileControl_TileUnchecked , _imageTileControl_Paint
        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile tile1;
        private C1.Win.C1Tile.Tile tile2;
        private C1.Win.C1Tile.Tile tile3;
        private C1PdfDocument c1PdfDocument1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;//
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox _searchboxx;
        private System.Windows.Forms.Panel panel3usedforsearchbutton;
        private System.Windows.Forms.PictureBox _searchh;
        [DllImport(Helpp.NET_DRIVER)]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        DataFetcher datafetch = new DataFetcher();
        List<ImageItem> imagesList;
        int checkedItems = 0;
        public ImageGalleryForm()
        {
            InitializeComponent();
            //intt();
        }
        
        //Search can perform when we pressed enter key
        private void ImageGalleryEnterPressed(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _searchboxx_ClickAsync(_search, null);
                    break;
            }
        }

        //Check Internet Connection for application
        public bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        //Perform paint event handling to panel with used to serach textbox
        private void panel1forsearchtextcol_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = _searchbox.Bounds;
            r.Inflate(3, 3);
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
        }

        //In this all the images and add it to the tile control
        private void AddTiles(List<ImageItem> imageList)
        {
            _imageTileControl.Groups[0].Tiles.Clear();
            foreach (var imageitem in imageList)//This method takes a list of images, iterates through each image and add tile for each image.
            {
                Tile tile = new Tile();
                tile.HorizontalSize = 2;
                tile.VerticalSize = 2;
                _imageTileControl.Groups[0].Tiles.Add(tile);
                Image img = Image.FromStream(new MemoryStream(imageitem.Base64));//It converts the base64 encoding to the corresponding image using MemoryStream class.
                Template tl = new Template();
                ImageElement ie = new ImageElement();
                ie.ImageLayout = ForeImageLayout.Stretch;
                tl.Elements.Add(ie);
                tile.Template = tl;
                tile.Image = img;
            }
        }

        
        //Add event handler for emporttopdf can click and perform their operations into the application
        private void _exportImage_Click(object sender, EventArgs e)
        {
            C1PdfDocument imageToPdf = new C1PdfDocument();
            List<Image> images = new List<Image>();
            foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
            {
                if (tile.Checked)
                {
                    images.Add(tile.Image);
                }
            }
            if (images.Count <= 0)
            {
                MessageBox.Show(Properties.Resources.no_images_selected, Properties.Resources.dialog_alert);
                return;
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "pdf";
            saveFile.Filter = "PDF files (*.pdf)|*.pdf*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ConvertToPdf(images, imageToPdf);
                    Console.WriteLine(saveFile.FileName);
                    imageToPdf.Save(saveFile.FileName);
                    DialogResult dialogResult = MessageBox.Show(saveFile.FileName + " " + Properties.Resources.saved_successfully, Properties.Resources.dialog_success, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(saveFile.FileName);
                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.StackTrace);
                    MessageBox.Show(e1.Message, Properties.Resources.dialog_error);
                }
            }
            else
            {
                Console.WriteLine("Donot Perform Further Operation");
            }
        }

        //This method iterates through all the tiles, gets its image and convert this list of images to pdf using 
        //ConvertToPdf method, which we are going to write in a moment.After converting to PDF, it opens a
       // SaveFileDialog to save the image.
        private void ConvertToPdf(List<Image> images, C1PdfDocument imageToPdf)
        {
            RectangleF rect = imageToPdf.PageRectangle;
            bool firstPage = true;
            foreach (var selectedimg in images)
            {
                if (!firstPage)
                {
                    imageToPdf.NewPage();
                }
                firstPage = false;
                rect.Inflate(-72, -72);
                try
                {
                    imageToPdf.DrawImage(selectedimg, rect);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, Properties.Resources.dialog_error);
                }
            }
        }

        //By using this control is redrawn according to need
        private void _exportImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(_exportImage.Location.X, _exportImage.Location.Y, _exportImage.Width, _exportImage.Height);
            r.X -= 29;
            r.Y -= 3;
            r.Width--;
            r.Height--;
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
            e.Graphics.DrawLine(p, new Point(0, 43), new Point(this.Width, 43));
        }


        //Perform task when user can check the images
         private void _imageTileControl_TileChecked(object sender, C1.Win.C1Tile.TileEventArgs e)
        {
            checkedItems++;
            _exportImage.Visible = true;
        }

        //Perform task when user can uncheck the images
        private void _imageTileControl_TileUnchecked(object sender, C1.Win.C1Tile.TileEventArgs e)
        {
            checkedItems--;
            _exportImage.Visible = checkedItems > 0;
        }



        private void _imageTileControl_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawLine(p, 0, 43, 800, 43);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void tile2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1main_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _searchboxx_TextChanged(object sender, EventArgs e)
        {

        }
        

        //private async void _searchboxx_ClickAsync(object sender, EventArgs e)
        private async void _searchboxx_ClickAsync(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            imagesList = await datafetch.GetImageData(_searchboxx.Text);
            AddTiles(imagesList);
            
            if (!imagesList.Any())
            {
                imagesList = await datafetch.GetImageData("No Image", 1);
                Console.WriteLine("Oopps.. No Image Found");
            }

            //checking for errors
            if (!datafetch.flag)
                Console.WriteLine("Network Error");

            AddTiles(imagesList);
            group1.Visible = true;
            
            statusStrip1.Visible = false;
        }

        private void ImageGalleryForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.splitContainer1main);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 810);
            this.Name = "ImageGalleryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Gallery ";

            vScrollBar1.Maximum= 13;
            vScrollBar1.Minimum =0;
            vScrollBar1.Value = 0;

            //Split Container
            splitContainer1main = AppView.GetSplitContainer();
            Controls.Add(splitContainer1main);

            //vertical scroll bar
            
            vScrollBar1 = AppView.GetVScrollBar();
            vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(vScrollBar1_Scroll);
            
            Controls.Add(vScrollBar1);
            
            
            
        }

        private Control GetSplitContainer()
        {
            throw new NotImplementedException();
        }
        
        //This can used for vertical scroll bar controls into the function
        int scroll = 0;
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
            if(e.OldValue > e.NewValue)
            {
                _imageTileControl.Location = new Point(_imageTileControl.Location.Y+2);
            }
            else
            {
                _imageTileControl.Location = new Point(_imageTileControl.Location.Y-2);
            }
            scroll = vScrollBar1.Value;
            
        }
    
    }
}

