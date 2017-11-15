using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Perceptron
{
    public partial class frmMain : Form
    {
        List<Sample> samples = new List<Sample>();
        Graphics objGraphics;
        Graphics grph;
        double w1, w2, w0 = 0;
        double alpha = 0.5;
        double x0 = -1;
        int factorScale = 10;
        int maxIterations;
        List<double> errors = new List<double>();
        //bool banderaParar = true;
        public frmMain()

        {
            InitializeComponent();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            objGraphics = pnlCanvas.CreateGraphics();
            grph = pnlCanvas.CreateGraphics();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            limpiarControles();
            double alfa = (double)trackLearningRate.Value / 100;
            lblalfa.Text = lblalfa.Text + alfa;
            lblmuestras.Text = lblmuestras.Text + samples.Count;
            if (rdbAdaline.Checked)
            {
                
                lblerroradmisible.Text = lblerroradmisible.Text + txterror.Text.ToString();
                
                var watch = System.Diagnostics.Stopwatch.StartNew();
                adaline();
                watch.Stop();
                var elapsedMs = watch.Elapsed.Seconds;
                lbltiempo.Text = lbltiempo.Text + elapsedMs + "s";
                //Thread adalina = new Thread(() => adaline(alfa));
                //adalina.Start();
                //adalina.Join();
                graficar(errors);
                errors.Clear();
            }

            if (rdbperceptron.Checked)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                perceptron();
                watch.Stop();
                var elapsedMs = watch.Elapsed.Seconds;
                lbltiempo.Text = lbltiempo.Text + elapsedMs + "s";
            }

           
           
        }


        private void graficar(List<double> errors)
        {

            chart1.Series["Error"].Points.Clear();
            // chart1.Series.Add("Error");

            foreach (var error in errors)
            {
                chart1.Series["Error"].Points.AddY(error);
            }

           


        }

        private void limpiarControles()
        {
            lblalfa.Text = "Alfa: ";
            lblerroradmisible.Text = "ErrorAdmisible: ";
            lblmuestras.Text = "Cant muestras: ";
            lbliteraciones.Text = "Cant iteraciones: ";
            lbl_error.Text = "Error: ";
            lbltiempo.Text = "Tiempo: ";
        }




        private void perceptron()
        {

            int i;
            int iterations = 0;
            bool error = true;

            maxIterations = int.Parse(txtIterations.Text);

            Random rnd = new Random();

            w0 = double.Parse(txtWO.Text.ToString());
            w1 = double.Parse(txtW1.Text.ToString());
            w2 = double.Parse(txtW2.Text.ToString());

            //w0 = rnd.NextDouble();
            //w1 = rnd.NextDouble();
            //w2 = rnd.NextDouble();

            alpha = (double)trackLearningRate.Value / 1000;

            while (error && iterations < maxIterations)
            {
                error = false;

                for (i = 0; i <= samples.Count - 1; i++)
                {
                    double x1 = samples[i].X1;
                    double x2 = samples[i].X2;
                    int y;

                    if (((w1 * x1) + (w2 * x2) - w0) < 0)
                    {
                        y = -1;
                    }
                    else
                    {
                        y = 1;
                    }

                    if (y != samples[i].Class)
                    {
                        error = true;

                        w0 = w0 + alpha * (samples[i].Class - y) * x0 / 2 ; //ak by x0 bolo +1, tak nedelime 2
                        w1 = w1 + alpha * (samples[i].Class - y) * x1 / 2;
                        w2 = w2 + alpha * (samples[i].Class - y) * x2 / 2 ;
                    }
                }
                objGraphics.Clear(Color.White);
                DrawSeparationLine();
                iterations++;
            }
            lbliteraciones.Text = lbliteraciones.Text + iterations;





        }



        private void adaline()
        {
            int i;
            int iterations = 0;
            double error = 0;
            double errorAdmisible = double.Parse(txterror.Text.ToString());
            //banderaParar = true;
            double errorMedio = 1;
            double errorCuadrado = 0;
            double sumaError = 0;
            maxIterations = int.Parse(txtIterations.Text);

            //Random rnd = new Random();

            //w0 = rnd.NextDouble();
            //w1 = rnd.NextDouble();
            //w2 = rnd.NextDouble();
            w0 = double.Parse(txtWO.Text.ToString());
            w1 = double.Parse(txtW1.Text.ToString());
            w2 = double.Parse(txtW2.Text.ToString());

            alpha = (double)trackLearningRate.Value / 1000;

            //alpha = (double)alfa / 1000;

            while (errorAdmisible < errorMedio && iterations < maxIterations /*&& banderaParar*/)
            {
                // error = false;

                for (i = 0; i <= samples.Count - 1; i++)
                {
                    double x1 = samples[i].X1;
                    double y1 = samples[i].X2;
                    double salidacalculada;

                    salidacalculada = x0 * w0 + x1 * w1 + y1 * w2;

                    error = samples[i].Class - salidacalculada;
                    //Console.WriteLine("error" + error);
                    // error = true;

                    w0 = w0 + alpha * (error) * x0 / 2; 
                    w1 = w1 + alpha * (error) * x1 / 2;
                    w2 = w2 + alpha * (error) * y1 / 2;

                    errorCuadrado = error * error;

                    sumaError = sumaError + errorCuadrado;
                }

                errorMedio = (1 / (2 * (double)samples.Count)) * sumaError;
               // Console.WriteLine("errorMedio: " + errorMedio);
                sumaError = 0;
                this.errors.Add(errorMedio);
                objGraphics.Clear(Color.White);
                DrawSeparationLine();
                iterations++;


            }


          

            lbliteraciones.Text = lbliteraciones.Text + iterations;
            lbl_error.Text = lbl_error.Text + errorMedio;

        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {

            double posX = (double)(e.X - pnlCanvas.Width / 2) / factorScale;
            double posY = (double)(pnlCanvas.Height / 2 - e.Y) / factorScale;

            this.Text = posX + " " + posY;
            Console.WriteLine(this.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            samples.Clear();
            objGraphics.Clear(Color.White);
            objGraphics.DrawLine(new Pen(Color.Gainsboro), new Point(0, pnlCanvas.Height / 2), new Point(pnlCanvas.Width, pnlCanvas.Height / 2));
            objGraphics.DrawLine(new Pen(Color.Gainsboro), new Point(pnlCanvas.Width / 2, 0), new Point(pnlCanvas.Width / 2, pnlCanvas.Height));
            chart1.Series["Error"].Points.Clear();
            limpiarControles();
        }

        private void DrawSamples()
        {
            foreach (Sample sample in samples)
            {

                double posX = (pnlCanvas.Width / 2) + sample.X1 * factorScale;
                double posY = (pnlCanvas.Height / 2) - sample.X2 * factorScale;

                Pen pen;
                if (sample.Class == 1)
                {
                    pen = new Pen(Color.Blue);
                }
                else
                {
                    pen = new Pen(Color.Red);
                }

                objGraphics.DrawLine(pen, new Point((int)posX - 3, (int)posY), new Point((int)posX + 3, (int)posY));
                objGraphics.DrawLine(pen, new Point((int)posX, (int)posY - 3), new Point((int)posX, (int)posY + 3));
            }
        }

        private void DrawSeparationLine()
        {
            objGraphics.DrawLine(new Pen(Color.Gainsboro), new Point(0, pnlCanvas.Height / 2), new Point(pnlCanvas.Width, pnlCanvas.Height / 2));
            objGraphics.DrawLine(new Pen(Color.Gainsboro), new Point(pnlCanvas.Width / 2, 0), new Point(pnlCanvas.Width / 2, pnlCanvas.Height));

            Pen pen = new Pen(Color.DarkGreen);
            double x1;

            x1 = -10;
            double y = -(x1 * w1 / w2) - ((x0*w0) / w2);

            double shift = pnlCanvas.Height / 2;


            Point p1 = new Point(0, (int)(shift - y * factorScale));

            x1 = 10;
            double y2 = -(x1 * w1 / w2) + ((w0) / w2);

            Point p2 = new Point(pnlCanvas.Width, (int)(shift - y2 * factorScale));
            if (w2 != 0)
            {
                objGraphics.DrawLine(pen, p1, p2);
                DrawSamples();
            }
        }

        private void trackLearningRate_Scroll(object sender, EventArgs e)
        {
            lblLearningRate.Text = "Tasa Aprendizaje: " + (double)trackLearningRate.Value/100;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtIterations_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbliteraciones_Click(object sender, EventArgs e)
        {

        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            //this.banderaParar = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txterror.Enabled = false;
        }

        private void rdbAdaline_CheckedChanged(object sender, EventArgs e)
        {
            txterror.Enabled = true;
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            Sample sample;
            Pen pen;

            double posX = (double)(e.X - pnlCanvas.Width / 2) / factorScale;
            double posY = (double)(pnlCanvas.Height / 2 - e.Y) / factorScale;
            Console.WriteLine(e.X + " "+ e.Y);
            if (e.Button == MouseButtons.Left)
            {
                pen = new Pen(Color.Blue);
                sample = new Sample(posX, posY, 1);
                Console.WriteLine(""+posX+";"+posY);
            }
            else
            {
                pen = new Pen(Color.Red);
                sample = new Sample(posX, posY, -1);
                Console.WriteLine("" + posX + ";" + posY);
            }
            samples.Add(sample);

            //Dibuja la cruz
            objGraphics.DrawLine(pen, new Point(e.X - 3, e.Y), new Point(e.X + 3, e.Y));
            objGraphics.DrawLine(pen, new Point(e.X, e.Y - 3), new Point(e.X, e.Y + 3));
        }
        
        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            objGraphics.DrawLine(new Pen(Color.Gainsboro), new Point(0, pnlCanvas.Height / 2), new Point(pnlCanvas.Width, pnlCanvas.Height / 2));
            objGraphics.DrawLine(new Pen(Color.Gainsboro), new Point(pnlCanvas.Width / 2, 0), new Point(pnlCanvas.Width / 2, pnlCanvas.Height));
        }


        
    }
}
