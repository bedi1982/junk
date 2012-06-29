using System.Windows.Forms;

namespace DarthVader.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles(); // <– ADD THIS LINE
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Main()); // <– ADD THIS LINE
        }
    }
}