namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            
            ApplicationConfiguration.Initialize();
           // AppIcons.Init(); // Load font icon trước khi chạy form nào để tránh lỗi font
            Application.Run(new Quản_Lý_Chi_Tiêu());
        }
    }
}