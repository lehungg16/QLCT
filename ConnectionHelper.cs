using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    public partial class ConnectionHelper : Form
    {
        
        public ConnectionHelper()
        {
            InitializeComponent();
        }

        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString
            ?? throw new Exception("Không tìm thấy ConnectionString 'DefaultConnection' trong App.config");

        private void ConnectionHelper_Load(object sender, EventArgs e)
        {
            
        }
    }
}
