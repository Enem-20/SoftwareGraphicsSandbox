using System;
using System.Windows.Forms;

namespace SoftwareGraphicsSandbox {
    static class Program
    {
        private static Image image;
        private static bool _running = true;
       
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new RenderWindow();
            form.Width = 1024;
            form.Height = 768;
            form.FormClosed += Form_FormClosed;
            form.Show();

            Renderer renderer = new Renderer(form.Handle);
            image = renderer.BackBuffer;
            UserSoftwareGraphicsSandbox.AnyLine anyLine = new UserSoftwareGraphicsSandbox.AnyLine(100, 100, 200, 200);
            anyLine.color32 = Color32.Red;
            while (_running){
                //Render image 
                image.FillColor(Color32.Black);
                //Process window messages
                Application.DoEvents();


                //example draw horizontal line
                //for (int x = 0; x < 100; ++x) {
                //    image.SetPixel(x + 100, 100, Color32.Green);
                //}

                anyLine.SetPixels(image);

                //Show image in window
                renderer.Present();
            }
        }


        private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _running = false;
        }
    }
}
