namespace Perceptron
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.trackLearningRate = new System.Windows.Forms.TrackBar();
            this.lblLearningRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.txterror = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.lblerroradmisible = new System.Windows.Forms.Label();
            this.lbliteraciones = new System.Windows.Forms.Label();
            this.lblmuestras = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lblalfa = new System.Windows.Forms.Label();
            this.lbl_estadisticas = new System.Windows.Forms.Label();
            this.lblWO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.txtW1 = new System.Windows.Forms.TextBox();
            this.txtW2 = new System.Windows.Forms.TextBox();
            this.rdbAdaline = new System.Windows.Forms.RadioButton();
            this.rdbperceptron = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackLearningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(12, 218);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(80, 26);
            this.btnLearn.TabIndex = 1;
            this.btnLearn.Text = "Entrenar";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(110, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 26);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Borrar ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // trackLearningRate
            // 
            this.trackLearningRate.Location = new System.Drawing.Point(229, 73);
            this.trackLearningRate.Maximum = 50;
            this.trackLearningRate.Name = "trackLearningRate";
            this.trackLearningRate.Size = new System.Drawing.Size(141, 45);
            this.trackLearningRate.TabIndex = 3;
            this.trackLearningRate.TickFrequency = 20;
            this.trackLearningRate.Scroll += new System.EventHandler(this.trackLearningRate_Scroll);
            // 
            // lblLearningRate
            // 
            this.lblLearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearningRate.Location = new System.Drawing.Point(229, 47);
            this.lblLearningRate.Name = "lblLearningRate";
            this.lblLearningRate.Size = new System.Drawing.Size(187, 23);
            this.lblLearningRate.TabIndex = 4;
            this.lblLearningRate.Text = "Tasa de Aprendizaje: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Iteraciones:";
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(319, 141);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(42, 20);
            this.txtIterations.TabIndex = 6;
            this.txtIterations.Text = "500";
            this.txtIterations.TextChanged += new System.EventHandler(this.txtIterations_TextChanged);
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Location = new System.Drawing.Point(12, 15);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(200, 200);
            this.pnlCanvas.TabIndex = 7;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 253);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Error";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(604, 219);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Error Admisible:";
            // 
            // txterror
            // 
            this.txterror.Location = new System.Drawing.Point(338, 111);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(39, 20);
            this.txterror.TabIndex = 11;
            this.txterror.Text = "0,25";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbltiempo);
            this.panel1.Controls.Add(this.lblerroradmisible);
            this.panel1.Controls.Add(this.lbliteraciones);
            this.panel1.Controls.Add(this.lblmuestras);
            this.panel1.Controls.Add(this.lbl_error);
            this.panel1.Controls.Add(this.lblalfa);
            this.panel1.Controls.Add(this.lbl_estadisticas);
            this.panel1.Location = new System.Drawing.Point(434, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 194);
            this.panel1.TabIndex = 14;
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempo.Location = new System.Drawing.Point(8, 168);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(58, 16);
            this.lbltiempo.TabIndex = 6;
            this.lbltiempo.Text = "Tiempo:";
            // 
            // lblerroradmisible
            // 
            this.lblerroradmisible.AutoSize = true;
            this.lblerroradmisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerroradmisible.Location = new System.Drawing.Point(8, 58);
            this.lblerroradmisible.Name = "lblerroradmisible";
            this.lblerroradmisible.Size = new System.Drawing.Size(100, 16);
            this.lblerroradmisible.TabIndex = 5;
            this.lblerroradmisible.Text = "ErrorAdmisible:";
            // 
            // lbliteraciones
            // 
            this.lbliteraciones.AutoSize = true;
            this.lbliteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliteraciones.Location = new System.Drawing.Point(8, 118);
            this.lbliteraciones.Name = "lbliteraciones";
            this.lbliteraciones.Size = new System.Drawing.Size(107, 16);
            this.lbliteraciones.TabIndex = 4;
            this.lbliteraciones.Text = "Cant iteraciones:";
            this.lbliteraciones.Click += new System.EventHandler(this.lbliteraciones_Click);
            // 
            // lblmuestras
            // 
            this.lblmuestras.AutoSize = true;
            this.lblmuestras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmuestras.Location = new System.Drawing.Point(8, 89);
            this.lblmuestras.Name = "lblmuestras";
            this.lblmuestras.Size = new System.Drawing.Size(96, 16);
            this.lblmuestras.TabIndex = 3;
            this.lblmuestras.Text = "Cant muestras:";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.Location = new System.Drawing.Point(8, 142);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(40, 16);
            this.lbl_error.TabIndex = 2;
            this.lbl_error.Text = "Error:";
            // 
            // lblalfa
            // 
            this.lblalfa.AutoSize = true;
            this.lblalfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalfa.Location = new System.Drawing.Point(8, 31);
            this.lblalfa.Name = "lblalfa";
            this.lblalfa.Size = new System.Drawing.Size(34, 16);
            this.lblalfa.TabIndex = 1;
            this.lblalfa.Text = "Alfa:";
            this.lblalfa.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_estadisticas
            // 
            this.lbl_estadisticas.AutoSize = true;
            this.lbl_estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadisticas.Location = new System.Drawing.Point(38, 0);
            this.lbl_estadisticas.Name = "lbl_estadisticas";
            this.lbl_estadisticas.Size = new System.Drawing.Size(99, 20);
            this.lbl_estadisticas.TabIndex = 0;
            this.lbl_estadisticas.Text = "Estadísticas:";
            // 
            // lblWO
            // 
            this.lblWO.AutoSize = true;
            this.lblWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWO.Location = new System.Drawing.Point(230, 172);
            this.lblWO.Name = "lblWO";
            this.lblWO.Size = new System.Drawing.Size(31, 16);
            this.lblWO.TabIndex = 15;
            this.lblWO.Text = "W0:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "W2: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "W1:";
            // 
            // txtWO
            // 
            this.txtWO.Location = new System.Drawing.Point(267, 168);
            this.txtWO.Name = "txtWO";
            this.txtWO.Size = new System.Drawing.Size(31, 20);
            this.txtWO.TabIndex = 18;
            this.txtWO.Text = "0,8";
            // 
            // txtW1
            // 
            this.txtW1.Location = new System.Drawing.Point(266, 192);
            this.txtW1.Name = "txtW1";
            this.txtW1.Size = new System.Drawing.Size(32, 20);
            this.txtW1.TabIndex = 19;
            this.txtW1.Text = "0,2";
            // 
            // txtW2
            // 
            this.txtW2.Location = new System.Drawing.Point(267, 218);
            this.txtW2.Name = "txtW2";
            this.txtW2.Size = new System.Drawing.Size(32, 20);
            this.txtW2.TabIndex = 20;
            this.txtW2.Text = "0,3";
            // 
            // rdbAdaline
            // 
            this.rdbAdaline.AutoSize = true;
            this.rdbAdaline.Checked = true;
            this.rdbAdaline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdaline.Location = new System.Drawing.Point(3, 3);
            this.rdbAdaline.Name = "rdbAdaline";
            this.rdbAdaline.Size = new System.Drawing.Size(72, 20);
            this.rdbAdaline.TabIndex = 21;
            this.rdbAdaline.TabStop = true;
            this.rdbAdaline.Text = "Adaline";
            this.rdbAdaline.UseVisualStyleBackColor = true;
            this.rdbAdaline.CheckedChanged += new System.EventHandler(this.rdbAdaline_CheckedChanged);
            // 
            // rdbperceptron
            // 
            this.rdbperceptron.AutoSize = true;
            this.rdbperceptron.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbperceptron.Location = new System.Drawing.Point(96, 3);
            this.rdbperceptron.Name = "rdbperceptron";
            this.rdbperceptron.Size = new System.Drawing.Size(92, 20);
            this.rdbperceptron.TabIndex = 22;
            this.rdbperceptron.Text = "Perceptron";
            this.rdbperceptron.UseVisualStyleBackColor = true;
            this.rdbperceptron.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdbAdaline);
            this.panel2.Controls.Add(this.rdbperceptron);
            this.panel2.Location = new System.Drawing.Point(227, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 25);
            this.panel2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Iteraciones";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtW2);
            this.Controls.Add(this.txtW1);
            this.Controls.Add(this.txtWO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLearningRate);
            this.Controls.Add(this.trackLearningRate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLearn);
            this.Name = "frmMain";
            this.Text = "Simulación Adaline & Perceptron";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackLearningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblLearningRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txterror;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lblalfa;
        private System.Windows.Forms.Label lbl_estadisticas;
        private System.Windows.Forms.Label lbliteraciones;
        private System.Windows.Forms.Label lblmuestras;
        private System.Windows.Forms.Label lblerroradmisible;
        private System.Windows.Forms.Label lblWO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWO;
        private System.Windows.Forms.TextBox txtW1;
        private System.Windows.Forms.TextBox txtW2;
        public System.Windows.Forms.TrackBar trackLearningRate;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.RadioButton rdbAdaline;
        private System.Windows.Forms.RadioButton rdbperceptron;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}

