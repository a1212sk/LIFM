
namespace LIFM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.current = new System.Windows.Forms.TrackBar();
            this.gl = new System.Windows.Forms.TrackBar();
            this.cm = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)(this.current)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cm)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(12, 9);
            this.output.MinimumSize = new System.Drawing.Size(400, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(400, 30);
            this.output.TabIndex = 0;
            this.output.Text = "Output";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(41, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plotView1.Location = new System.Drawing.Point(231, 9);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(557, 208);
            this.plotView1.TabIndex = 4;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // current
            // 
            this.current.Location = new System.Drawing.Point(12, 186);
            this.current.Maximum = 100;
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(189, 45);
            this.current.TabIndex = 5;
            // 
            // gl
            // 
            this.gl.Location = new System.Drawing.Point(12, 237);
            this.gl.Maximum = 20;
            this.gl.Minimum = 1;
            this.gl.Name = "gl";
            this.gl.Size = new System.Drawing.Size(189, 45);
            this.gl.TabIndex = 6;
            this.gl.Value = 16;
            // 
            // cm
            // 
            this.cm.Location = new System.Drawing.Point(15, 288);
            this.cm.Maximum = 100;
            this.cm.Minimum = 1;
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(189, 45);
            this.cm.TabIndex = 7;
            this.cm.Value = 46;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(50, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 57);
            this.button2.TabIndex = 8;
            this.button2.Text = "Fire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // plotView2
            // 
            this.plotView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plotView2.Location = new System.Drawing.Point(231, 223);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(557, 208);
            this.plotView2.TabIndex = 9;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.gl);
            this.Controls.Add(this.current);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.Text = "LIFM";
            ((System.ComponentModel.ISupportInitialize)(this.current)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void SetOutput(string str)
        {
            output.Text = str;
            output.Refresh();
        }

        #endregion

        public System.Windows.Forms.Label output;
        public System.Windows.Forms.Button button1;
        public OxyPlot.WindowsForms.PlotView plotView1;
        public System.Windows.Forms.TrackBar current;
        public System.Windows.Forms.TrackBar gl;
        public System.Windows.Forms.TrackBar cm;
        public System.Windows.Forms.Button button2;
        public OxyPlot.WindowsForms.PlotView plotView2;
    }
}

