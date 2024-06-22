using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.ListView;

namespace SotoZaragozamisaelA01
{
    public partial class Form1 : Form
    {
        Bitmap bmpImagen;
        List<Circle> CircleList;
        int id;
        public Form1()
        {
            InitializeComponent();
            CircleList = new List<Circle>();
            id = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = 0;
                listView1.Items.Clear();
                CircleList.Clear();
                openFileDialog1.ShowDialog();
                
                bmpImagen = new Bitmap(openFileDialog1.FileName);

                binar();
                pictureBoxImagen.Image = bmpImagen;
               

            } 
            catch(Exception error) 
            {
                MessageBox.Show("No se seleccionó ninguna imagen");
            }
         

        }
        private void buttonPixel_Click(object sender, EventArgs e)
        {
            try
            {
                DetectCircle();

                foreach (Circle c in CircleList)
                {
                    ListViewItem item = new ListViewItem((c.getID() + 1) + "", c.getID());
                    item.SubItems.Add(c.getX() + "");
                    item.SubItems.Add(c.getY() + "");
                    item.SubItems.Add(c.getRadius() + "");
                    listView1.Items.Add(item);
                }
                MessageBox.Show("Proceso Terminado con Exito");
            }
            catch(ArgumentOutOfRangeException except)
            {
                MessageBox.Show(except + "");
            }
            
        }
        private void paintWhiteCircle(ref Bitmap auxBMP, ref Bitmap auxNumberBitmap, int cX, int cY, int cR)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            Font writeFont = new Font("Arial", 40);
            Graphics newGraphic = Graphics.FromImage(auxBMP);
            Graphics numberGraphics = Graphics.FromImage(auxNumberBitmap);
            newGraphic.DrawEllipse(new Pen(Color.White, 2), cX - cR, cY - cR, cR * 2, cR * 2);
            newGraphic.FillEllipse(brush, cX - cR, cY - cR, cR * 2, cR * 2);
            numberGraphics.DrawString(id + "", writeFont, brush, cX + 10, cY - 20);

        }
        private int getRadio(int x, int y, Bitmap bmp)
        {
            int centro_x = x;

            while (!isWhite(bmp.GetPixel(centro_x, y)))
            {
                centro_x++;
            }
            return centro_x - x;
        }
        private bool isWhite(Color c)
        {
            if (c.R == 255)
                if (c.G == 255)
                    if (c.B == 255)
                        return true;
            return false;
        }
        private bool isBlack(Color c)
        {
            if (c.R == 0)
                if (c.G == 0)
                    if (c.B == 0)
                        return true;
            return false;
        }
        private int detectCenterX(int xI, int yI,Bitmap bmp)
        {
            int x = xI;
            int y = yI;
            int centro;
            
            while (!isWhite(bmp.GetPixel(x, y)) && !isWhite(bmp.GetPixel(x + 1, y)))
                x++;

            centro = (x + xI) / 2;
            
            return centro;
        }
        private int detectCenterY(int xI, int yI,Bitmap bmp)
        {
            
            int x = xI;
            int y = yI;

            Color c1 = bmp.GetPixel(x, y);
            Color c2 = bmp.GetPixel(x, y + 1);

            while (!isWhite(c1) && !isWhite(c2) && y < bmp.Width) {
                c1 = bmp.GetPixel(x, y);
                c2 = bmp.GetPixel(x, y + 1);
                y++;
            }
            int centro = (y + yI) / 2;

            return centro;
        }

        private void DetectCircle()
        {
            Bitmap auxBmp = new Bitmap(bmpImagen);
            Bitmap auxNumber = new Bitmap(bmpImagen);

            for(int j = 0; j < auxBmp.Height-1; j++) {
                for(int i = 0; i < auxBmp.Width-1; i++)
                {
                    if(!isWhite(auxBmp.GetPixel(i,j))) 
                    {
                        Circle newCircle = new Circle();
                        
                        if(i > 0 && j > 0 && j < auxBmp.Height && i < auxBmp.Width) { 
                            int centerX = detectCenterX(i, j,auxBmp);
                            int centerY = detectCenterY(i, j, auxBmp);
                            int radius = getRadio(centerX,centerY,auxBmp);
                        
                            newCircle.SetX(centerX);
                            newCircle.SetY(centerY);
                            newCircle.SetRadius(radius);
                            newCircle.SetID(id);

                            CircleList.Add(newCircle);

                            id++;

                            paintWhiteCircle(ref auxBmp, ref auxNumber, newCircle.getX(), newCircle.getY(), newCircle.getRadius());
                        }
                    }
                }
            }
            pictureBoxImagen.Image = auxNumber;
        }
        
        private void binar()
        {
            for (int j = 0; j < bmpImagen.Height; j++)
            {
                for (int i = 0; i < bmpImagen.Width; i++)
                {
                    if (!isWhite(bmpImagen.GetPixel(i, j)))
                    {
                        bmpImagen.SetPixel(i, j, Color.Black);
                    }
                }
            }
        }

        private void buttonCircleSize_Click(object sender, EventArgs e)
        {
            OrdenarTamanio(CircleList);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            OrdenarX(CircleList);
        }
        private void OrdenarX(List<Circle> CircleList)
        {
            listView1.Items.Clear();
            Circle aux;
            for (int z = 1; z < CircleList.Count; ++z)
            {
                for (int v = 0; v < (CircleList.Count - z); v++)
                {
                    if (CircleList[v].getX() > CircleList[v + 1].getX())
                    {
                        aux = CircleList[v];
                        CircleList[v] = CircleList[v + 1];
                        CircleList[v + 1] = aux;
                    }
                }
            }
            foreach (Circle c in CircleList)
            {
                ListViewItem item = new ListViewItem((c.getID() + 1) + "", c.getID());
                item.SubItems.Add(c.getX() + "");
                item.SubItems.Add(c.getY() + "");
                item.SubItems.Add(c.getRadius() + "");
                listView1.Items.Add(item);
            }
            MessageBox.Show("Lista Ordenada con Exito");

        }
        private void OrdenarTamanio(List<Circle> CircleList)
        {
            List<Circle> sortedCircles = new List<Circle>();
            Circle aux;
            for (int z = 1; z < CircleList.Count; ++z)
            {
                for (int v = 0; v < (CircleList.Count - z); v++)
                {
                    if (CircleList[v].getRadius() > CircleList[v + 1].getRadius())
                    {
                        aux = CircleList[v];
                        CircleList[v] = CircleList[v + 1];
                        CircleList[v + 1] = aux;
                    }
                }
            }

            listView1.Items.Clear();
            foreach (Circle c in CircleList)
            {
                ListViewItem item = new ListViewItem((c.getID() + 1) + "", c.getID());
                item.SubItems.Add(c.getX() + "");
                item.SubItems.Add(c.getY() + "");
                item.SubItems.Add(c.getRadius() + "");
                listView1.Items.Add(item);
            }
            MessageBox.Show("Lista Ordenada con Exito");

        }
        private void buttonY_Click(object sender, EventArgs e)
        {
            OrdenarY(CircleList); 
        }
        private void OrdenarY(List<Circle> CircleList)
        {
            listView1.Items.Clear();
            Circle aux;
            for (int z = 1; z < CircleList.Count; ++z)
            {
                for (int v = 0; v < (CircleList.Count - z); v++)
                {
                    if (CircleList[v].getY() > CircleList[v + 1].getY())
                    {
                        aux = CircleList[v];
                        CircleList[v] = CircleList[v + 1];
                        CircleList[v + 1] = aux;
                    }
                }
            }
            foreach (Circle c in CircleList)
            {
                ListViewItem item = new ListViewItem((c.getID() + 1) + "", c.getID());
                item.SubItems.Add(c.getX() + "");
                item.SubItems.Add(c.getY() + "");
                item.SubItems.Add(c.getRadius() + "");
                listView1.Items.Add(item);
            }
            MessageBox.Show("Lista Ordenada con Exito");

        }

        
    }   
}
