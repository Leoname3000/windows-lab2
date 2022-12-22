using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;

namespace WindowsLab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        // Constants

        const int FUNC_QTY = 5;

        const int ZOOM_STEP = 5;

        const int MAX_ZOOM = ZOOM_STEP * 24;
        const int DEFAULT_ZOOM = ZOOM_STEP * 8; // * 8
        const int MIN_ZOOM = ZOOM_STEP * 2; //30

        const int LABEL_X = 8;
        const int LABEL_Y = 10;


        private void MainForm_Load(object sender, EventArgs e)
        {

            funcChoice = 1; // Выбирает параболу
            zoom = DEFAULT_ZOOM;

            marginX = panel.Width / 2;
            marginY = panel.Height * 2 / 3;

            panel.Paint += new PaintEventHandler(panel_Marking);
            panel.Paint += new PaintEventHandler(panel_Paint);
            //panel.Paint += new PaintEventHandler(panel_DrawRolling);

            panel.MouseWheel += panel_MouseWheel;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //DoubleBuffered = true;

        }


        // Variables

        int funcChoice; 

        int zoom; // в пкс / у.е.

        int marginX;
        int marginY;


        // Graphics properties
        
        public bool showGrid = true;
        public bool showCircle = true;
        public bool showUnits = false;
        public bool showColor = false;
        public bool showGradient = false;
        
        public double step = 1.0;
        
        Color plotPenColor = Color.Black;
        public Color axisPenColor = Color.Black;
        public Color linePenColor = Color.LightGray;

        public Color backColor = Color.White;

        public Color gradTopColor = Color.White;
        public Color gradBottomColor = Color.White;
        public float gradAngle = 0.0f;


        private void panel_Marking_test(object sender, PaintEventArgs e)
        {
            Pen linePen = new Pen(linePenColor);
            Pen axisPen = new Pen(axisPenColor);
            Graphics g = e.Graphics;

            double step = Math.PI;

            // Vertical lines
            for (int plotX = 0; plotX < panel.Width; plotX++)
            {
                double realX = (double)plotX / zoom;
                if(realX % step <= 0.1)
                {
                    Point pVerTop = new Point(plotX, 0);
                    Point pVerBtm = new Point(plotX, panel.Height);

                    g.DrawLine(linePen, pVerTop, pVerBtm);
                }
            }
        }

        private void panel_Marking(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (showColor)
            {
                Brush brush = new SolidBrush(backColor);
                g.FillRectangle(brush, ClientRectangle);
            }

            if (showGradient) 
            {
                LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, gradTopColor, gradBottomColor, gradAngle);
                g.FillRectangle(brush, ClientRectangle);
            }

            //var p = sender as Panel;
            Pen axisPen = new Pen(axisPenColor);
            Pen linePen = new Pen(linePenColor);


            if (showGrid)
            { 
                // Upper horizontal lines
                for (double i = step; (int)Math.Round(marginY - i * zoom) >= 0; i += step)
                {
                    Point pHorLeft = new Point(0, (int)Math.Round(marginY - i * zoom));
                    Point pHorRight = new Point(panel.Width, (int)Math.Round(marginY - i * zoom));

                    g.DrawLine(linePen, pHorLeft, pHorRight);
                }

                // Lower horizontal lines
                for (double i = step; (int)Math.Round(marginY + i * zoom) <= panel.Height; i += step)
                {
                    Point pHorLeft = new Point(0, (int)Math.Round(marginY + i * zoom));
                    Point pHorRight = new Point(panel.Width, (int)Math.Round(marginY + i * zoom));

                    g.DrawLine(linePen, pHorLeft, pHorRight);
                }

                // Left vertical lines
                for (double i = step; (int)Math.Round(marginX - i * zoom) >= 0; i += step)
                {
                    Point pVerTop = new Point((int)Math.Round(marginX - i * zoom), 0);
                    Point pVerBottom = new Point((int)Math.Round(marginX - i * zoom), panel.Height);

                    g.DrawLine(linePen, pVerTop, pVerBottom);
                    //Console.WriteLine("For " + i + " value is " + (marginY - i * zoom) + ", zoom = " + zoom + ", width = " + panel.Width);

                }

                // Right vertical lines
                for (double i = step; (int)Math.Round(marginX + i * zoom) <= panel.Width; i += step)
                {
                    Point pVerTop = new Point((int)Math.Round(marginX + i * zoom), 0);
                    Point pVerBottom = new Point((int)Math.Round(marginX + i * zoom), panel.Height);

                    g.DrawLine(linePen, pVerTop, pVerBottom);
                    // Console.WriteLine("For " + i + " value is " + (marginY + i * zoom) + ", zoom = " + zoom + ", width = " + panel.Width);

                }
            }


            // Circle
            if (showCircle)
            {
                g.DrawEllipse(axisPen, (int)Math.Round(marginX - step * zoom), (int)Math.Round(marginY - step * zoom), (int)Math.Round(2 * step * zoom), (int)Math.Round(2 * step * zoom));
            }


            // Main axis
            Point axisHorLeft = new Point(0, marginY);
            Point axisHorRight = new Point(panel.Width, marginY);
            g.DrawLine(axisPen, axisHorLeft, axisHorRight);

            Point axisVerTop = new Point(marginX, 0);
            Point axisVerBottom = new Point(marginX, panel.Height);
            g.DrawLine(axisPen, axisVerTop, axisVerBottom);


            //g.DrawLine(pen, new Point(panel.Width - 10, 0), new Point(panel.Width - 10, panel.Height));
            //int marginX = panel.Width / 2;
            //int marginY = panel.Height / 2 + extraOffsetY;

            //int zoom = 20;
            //int seed = panel.Width / 2;
            //int size = seed * 2 + 1;
            //int start = -seed;

            //Point[] points = new Point[size];

            //for (int i = 0; i < points.Length; i++)
            //{
            //    int x = (start + i);
            //    int y = x;
            //    points[i] = new Point(x * zoom + marginX, -y * zoom + marginY);
            //}

            //g.DrawCurve(pen, points);

            //for (int i = 0; i < Width / zoom; i++)
            //{
            //    int p1 = new Point(1, 2);
            //    g.DrawLine(pen, p1, p1);
            //}

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(plotPenColor, 1.0f);
            Graphics g = e.Graphics;

            int lineCounter = 0;
            List<Point> pointList = new List<Point>();


            //double realX(int pX)
            //{
            //    return (double)pX / zoom;
            //}

            //double realY(int pX)
            //{
            //    double rX = realX(pX);

            //    switch (funcChoice)
            //    {
            //        case 0:
            //            label.Text = "y = sin(x)";
            //            return new Sin().calc(rX);
            //        case 1:
            //            label.Text = "y = x^2";
            //            return new Square().calc(rX);
            //        case 2:
            //            label.Text = "y = tg(x)";
            //            return new Tg().calc(rX);
            //        case 3:
            //            label.Text = "y = x^3";
            //            return new Cube().calc(rX);
            //        case 4:
            //            label.Text = "y = 2x + 5";
            //            return new Linear().calc(rX);
            //        default:
            //            Console.WriteLine("Error! No function selected!");
            //            return 0;
            //    }
            //}

            //int plotY(int pX)
            //{
            //    int y = (int)Math.Round(-realY(pX) * zoom);
            //    return y;
            //}

            //bool onScreen(int pX) 
            //{
            //    double realLeftX = (double)-marginX / zoom;
            //    double realRightX = (double)(panel.Width - marginX) / zoom;
            //    double realTopY = (double)-marginY / zoom;
            //    double realBottomY = (double)(panel.Height - marginX) / zoom;
            //    //return pX + marginX > 0 && pX + marginX < panel.Width && -realY(pX) >= realBottomY && -realY(pX) <= realTopY;
            //    return plotY(pX) >= -marginY && plotY(pX) <= panel.Height - marginY && pX + marginX > 0 && pX + marginX < panel.Width;
            //}


            for (int plotX = -marginX; plotX <= panel.Width - marginX; plotX++)
            {
                Point pointToAdd = new Point(plotX + marginX, plotY(plotX) + marginY);

                if (!onScreen(plotX) && onScreen(plotX + 1))
                {
                    pointList.Add(pointToAdd);
                }
                else if (onScreen(plotX))
                {
                    pointList.Add(pointToAdd);
                }
                else if (!onScreen(plotX) && onScreen(plotX - 1))
                {
                    pointList.Add(pointToAdd);

                    if (pointList.Count >= 2)
                    {
                        Point[] pointArray = pointList.ToArray();
                        g.DrawCurve(pen, pointArray);

                        pointList.Clear();
                        lineCounter += 1;
                    }
                }

                //------Rolling------//
                timer.Interval = 30;

                int radius = 2;
                Pen rollPen = new Pen(plotPenColor, 5.0f);

                if (timer.Enabled && rollX == plotX && onScreen(rollX))
                    g.DrawEllipse(rollPen, rollX - radius + marginX, plotY(rollX) - radius + marginY, 2 * radius, 2 * radius);

            }

            double scale = (double)zoom / DEFAULT_ZOOM;
            if (scale == 1.0)
                labelScale.Visible = false;
            else
                labelScale.Visible = true;
            labelScale.Text = scale/*.ToString("0.00")*/ + "x";
            labelScale.BackColor = Color.Transparent;
            labelScale.Location = new Point(panel.Width - labelScale.Width - LABEL_X, LABEL_Y);

            label.Location = new Point(buttonRandFunc.Location.X + buttonRandFunc.Width / 2 - label.Width / 2, label.Location.Y);

            Console.WriteLine(lineCounter);
            //Console.WriteLine(zoom);
        }

        private void panel_Paint_old(object sender, PaintEventArgs e)
        {
            //string emoji = Char.ConvertFromUtf32(0x1f5ff);
            //label.Text = emoji;

            //Pen pen = new Pen(penColor, 1.0f);
            //Graphics g = e.Graphics;

            //int lineCounter = 0;
            //List<Point> pointList = new List<Point>();

            //double y(double x)
            //{
            //    //return Math.Sin(x);
            //    //return Math.Tan(x);
            //    return x * x;
            //}

            ////bool onScreen = plotX >= 0 && plotX <= panel.Width - marginX;

            //for (int plotX = -marginX; plotX <= panel.Width - marginX; plotX++)
            //{
            //    double realX = (double)plotX / zoom;
            //    double realY = y(realX);
            //    int plotY = (int)Math.Round(-realY * zoom);

            //    bool onScreen = plotY + marginY >= 0 && plotY + marginY <= panel.Height;// && plotX + marginX > 0 && plotX + marginX < panel.Width;

            //    if (pointList.Count <= 0 && onScreen)
            //    {
            //        Point pointToAdd = new Point(plotX + marginX, plotY + marginY);
            //        pointList.Add(pointToAdd);
            //    }
            //    else if (onScreen)
            //    {
            //        Point pointToAdd = new Point(plotX + marginX, plotY + marginY);
            //        pointList.Add(pointToAdd);
            //    }
            //    else if(pointList.Count >= 2 && !onScreen)
            //    {
            //        Point pointToAdd = new Point(plotX + marginX, plotY + marginY);
            //        pointList.Add(pointToAdd);

            //        Point[] pointArray = pointList.ToArray();
            //        g.DrawCurve(pen, pointArray);

            //        pointList.Clear();
            //        lineCounter += 1;
            //    }
            //}

            //Console.WriteLine(lineCounter);

            //if (pointList.Count >= 2)
            //{
            //    Point[] pointArray = pointList.ToArray();
            //    g.DrawCurve(pen, pointArray);
            //}



            Panel p = sender as Panel;
            Pen pen = new Pen(plotPenColor);
            pen.Width = 2.0f;
            //Console.WriteLine(pen.Width);
            Graphics g = e.Graphics;

            //int seed = marginX;
            //int size = seed * 2 + 1;
            //int start = -seed;

            //Point[] points = new Point[size];
            //List<Point> pointList = new List<Point>();

            //for (int i = 0; i < points.Length; i++)
            //{
            //    int x = start + i;
            //    int y = (x * x) * zoom;
            //    if (y <= p.Height && y >= 0)
            //    {
            //        //points[i] = new Point(x * zoom + marginX, -y + marginY);
            //        Point toAdd = new Point(x * zoom + marginX, -y + marginY);
            //        pointList.Add(toAdd);
            //        //Console.WriteLine("Element " + i + " is " + points[i] + " -- Height is " + p.Height);
            //    }

            //}
            //points = pointList.ToArray();
            ////for (int i = 0; i < pointArray.Length; i++)
            ////    Console.WriteLine("Element " + i + " is " + pointArray[i] + " -- Height is " + p.Height);
            //g.DrawCurve(pen, points);
            int linesCounter = 0;

            List<Point> pointList = new List<Point>();

            //for (int totalCounter = (marginX < 0 ? marginX : 0); totalCounter < panel.Width * 2; totalCounter++)
            //{
            //    int x = totalCounter - marginX;

            //    int yFormal(int xVal)
            //    {
            //        return xVal * xVal;
            //    }

            //    int ySin(int xVal)
            //    {
            //        return (int)(Math.Sin(xVal) * 10);
            //    }

            //    int y(int xVal)
            //    {
            //        return -1 * yFormal(xVal) * zoom + marginY;
            //    }

            //    bool prewOnPanel = y(x - 1) >= -zoom && y(x - 1) <= panel.Height + zoom && (totalCounter - 1 - marginX) * zoom + marginX >= -zoom;
            //    bool currentOnPanel = y(x) >= -zoom && y(x) <= panel.Height + zoom && x * zoom + marginX >= -zoom;

            //    if (!prewOnPanel && currentOnPanel)
            //    {
            //        pointList.Add(new Point((totalCounter - 1 - marginX) * zoom + marginX, y(x - 1)));
            //    }
            //    if (currentOnPanel)
            //    {
            //        pointList.Add(new Point(x * zoom + marginX, y(x)));
            //    }
            //    if (prewOnPanel && !currentOnPanel)
            //    {
            //        pointList.Add(new Point(x * zoom + marginX, y(x)));
            //        if (pointList.Count > 1)
            //        {
            //            Point[] pointArray = pointList.ToArray();
            //            g.DrawCurve(pen, pointArray);
            //        }
            //        //g.DrawCurve(pen, new Point[0]);
            //        pointList.Clear();

            //        linesCounter++;
            //    }

            //    //Point p1 = new Point(totalCounter, 2 + marginY);
            //    //Point p2 = new Point(totalCounter, -2 + marginY);
            //    //g.DrawLine(pen, p1, p2);
            //}


            for (int x = -marginX-zoom; x < panel.Width - marginX + zoom; x++)
            {
                //int x = totalCounter - marginX;

                int ySquare(int xVal)
                {
                    return xVal * xVal * zoom;
                }

                int yLinear(int xVal)
                {
                    return xVal * zoom;
                }

                int ySin(int xVal)
                {
                    
                    return (int)(Math.Sin(xVal) * zoom);
                }

                int y(int xVal)
                {
                    return -1 * yLinear(xVal) + marginY;
                }

                //bool prewOnPanel = y(x - 1) >= -zoom && y(x - 1) <= panel.Height + zoom && (totalCounter - 1 - marginX) * zoom + marginX >= -zoom;
                //bool currentOnPanel = y(x) >= -zoom && y(x) <= panel.Height + zoom && x * zoom + marginX >= -zoom;

                bool isOnPanel(int xVal) 
                {
                    return y(xVal) >= -zoom && y(xVal) <= panel.Height + zoom;
                }

                if (!isOnPanel(x))
                {
                    if (isOnPanel(x - 1))
                    {
                        pointList.Add(new Point(x * zoom + marginX, y(x)));
                        if (pointList.Count > 1)
                        {
                            Point[] pointArray = pointList.ToArray();
                            g.DrawCurve(pen, pointArray);
                            linesCounter++;
                        }
                        pointList.Clear();
                    }
                    if (isOnPanel(x + 1))
                    {
                        pointList.Add(new Point(x * zoom + marginX, y(x)));
                    }
                }
                if (isOnPanel(x))
                {
                    pointList.Add(new Point(x * zoom + marginX, y(x)));
                }
                
            }


            label.Text = "Zoom = " + zoom;
            Console.WriteLine("There are " + linesCounter + " lines!");
            
        }


        // Buttons

        private void buttonRandFunc_Click(object sender, EventArgs e)
        {
            funcChoice = new Random().Next(0, FUNC_QTY);

            marginX = panel.Width / 2;
            marginY = panel.Height * 2 / 3;

            zoom = DEFAULT_ZOOM;
            panel.Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int width = panel.Width;
            int height = panel.Height;

            Bitmap bm = new Bitmap(width, height);
            panel.DrawToBitmap(bm, new Rectangle(0, 2, width, height));

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Bitmap (.bmp)|*.bmp"; //PNG(.png) | *.png | JPEG(.jpeg) | *.jpeg | Bitmap(.bmp) | *.bmp

            if (sf.ShowDialog() == DialogResult.OK)
            {
                String path = sf.FileName;
                StreamWriter streamWriter = new StreamWriter(path);
                bm.Save(streamWriter.BaseStream, ImageFormat.Bmp);
            }
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                plotPenColor = colorDialog.Color;
                panel.Refresh();
            }
        }

        StyleForm styleForm;
        public bool styleFormOpened = false;

        private void buttonChangeStyle_Click(object sender, EventArgs e)
        {
            
            if (!styleFormOpened) 
            {
                styleFormOpened = true;
                styleForm = new StyleForm();
                styleForm.Owner = this;
                styleForm.FormClosed += StyleForm_FormClosed;
                styleForm.Show();
            }
            else
            {
                styleForm.Close();
            }

            //marginX = panel.Width / 2;
            //marginY = panel.Height / 2 + extraOffsetY;
            //panel.Refresh();
        }

        private void StyleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            styleFormOpened = false;
        }


        // Controls

        int deltaX;
        int deltaY;

        bool isMouseHold = false;

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            deltaX = Cursor.Position.X - marginX;
            deltaY = Cursor.Position.Y - marginY;

            isMouseHold = true;
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseHold = false;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseHold)
            {
                marginX = Cursor.Position.X - deltaX;
                marginY = Cursor.Position.Y - deltaY;

                panel.Refresh();
            }
        }

        private void panel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && zoom < MAX_ZOOM)
            {
                zoom += ZOOM_STEP;
                panel.Refresh();
            }
            else if (e.Delta < 0 && zoom > MIN_ZOOM)
            {
                zoom -= ZOOM_STEP;
                panel.Refresh();
            }
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            marginX = panel.Width / 2;
            marginY = panel.Height * 2 / 3 /*+ extraOffsetY*/;

            panel.Refresh();
        }



        double realX(int pX)
        {
            return (double)pX / zoom;
        }

        double realY(int pX)
        {
            double rX = realX(pX);

            switch (funcChoice)
            {
                case 0:
                    label.Text = "y = sin(x)";
                    return new Sin().calc(rX);
                case 1:
                    label.Text = "y = x^2";
                    return new Square().calc(rX);
                case 2:
                    label.Text = "y = tg(x)";
                    return new Tg().calc(rX);
                case 3:
                    label.Text = "y = x^3";
                    return new Cube().calc(rX);
                case 4:
                    label.Text = "y = 2x + 5";
                    return new Linear().calc(rX);
                default:
                    Console.WriteLine("Error! No function selected!");
                    return 0;
            }
        }

        int plotY(int pX)
        {
            int y = (int)Math.Round(-realY(pX) * zoom);
            return y;
        }

        bool onScreen(int pX)
        {
            double realLeftX = (double)-marginX / zoom;
            double realRightX = (double)(panel.Width - marginX) / zoom;
            double realTopY = (double)-marginY / zoom;
            double realBottomY = (double)(panel.Height - marginX) / zoom;
            //return pX + marginX > 0 && pX + marginX < panel.Width && -realY(pX) >= realBottomY && -realY(pX) <= realTopY;
            return plotY(pX) >= -marginY && plotY(pX) <= panel.Height - marginY && pX + marginX > 0 && pX + marginX < panel.Width;
        }


        int rollX;
        int radius = 2;
        bool drawRolling = false;

        private void checkBtnRoll_CheckedChanged(object sender, EventArgs e)
        {
            timer.Enabled = checkBtnRoll.Checked;

            for (rollX = panel.Width - marginX; !onScreen(rollX); rollX--) ;

        }



        private void timer_Tick(object sender, EventArgs e)
        {
            

            string txt = "no";
            if (onScreen(rollX))
                txt = "yes";

            rollX--;

            Console.WriteLine("Roll X: " + rollX + "" + txt);

            panel.Refresh();
        }

        //private void panel_DrawRolling(object sender, PaintEventArgs e)
        //{
            
        //    Graphics g = e.Graphics;

        //    //int radius = 10;
        //    g.DrawEllipse(pen, rollX - radius + marginX, plotY(rollX) - radius + marginY, 2 * radius, 2 * radius);
        //}
    }
}
