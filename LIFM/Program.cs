using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIFM
{
    static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form1();
            Application.Run(form);
        }
    }

    public static class Runner
    {
        public static Neuron n1 = new Neuron();
        public static Neuron n2 = new Neuron();
        public static long Ticks = 0;

        public static void Run(Form1 form)
        {
            form.output.Text = "Running...";
            new Thread(() =>
            {
                for(int i = 0; i < 100000; i++)
                {
                    form.current.Invoke((MethodInvoker)delegate
                    {
                        var current = form.current.Value * 0.005f;
                        if (form.Fired)
                        {
                            current += 0.345f;
                            form.Fired = false;
                        }
                        n1.tick(current, form.gl.Value * 0.1f, form.cm.Value * 0.0001f);
                        var n2In = n1.currentV > 0 ? 0.345f : 0.005f;
                        n2.tick(n2In, form.gl.Value * 0.1f, form.cm.Value * 0.0001f);
                        ++Ticks;
                    });


                    form.AddTick(i, n1.currentV);
                    form.AddTick2(i, n2.currentV);
                }
                form.Enabled = true;
            }).Start();
            
        }
    }

    public class Neuron
    {
        private const float El = -0.065f;
        private const float threshold = -0.05f;
        private float gl = 0.16f;
       // private const float Cm = 0.0049f;
        public float dt = 0.0002f;
        public float currentV = El;
        public float previousV = El;
        public float I = 0.005f;
        private bool fired = false;

        private float dV = 0f;

        public int spikes = 0;

        public string info = "";

        public void tick(float i = 0.005f, float gl = 0.16f, float Cm = 0.0049f)
        {
            this.I = i;
            this.gl = gl;
            dV = (float)((I - gl * (currentV - El)) / (float)Cm);
            currentV = currentV + dV * dt;
            if (currentV > threshold)
            {

                if (fired)
                {
                    currentV = El;
                    fired = false;
                }
                else
                {
                    currentV = 0.04f;
                    fired = true;
                    spikes++;
                }
            }
            info = $"{dV}";
            previousV = currentV;

            //Thread.Sleep(100);
        }
    }
}
