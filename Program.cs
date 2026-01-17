using System;
using System.Windows.Forms;

namespace mağaza
{
    static class Program
    {
        // Bu satırı class'ın içine, Main'in dışına ekle (DLL Import)
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main()
        {
            // --- BULANIKLIK ÇÖZÜMÜ BURAYA ---
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            // --------------------------------

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Burası senin ilk açılış ekranın hangisiyse o olmalı (GirisEkrani gibi)
            Application.Run(new GirisEkrani());
        }
    }
}