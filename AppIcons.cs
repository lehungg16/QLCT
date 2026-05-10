using System;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    public static partial class AppIcons
    {
        // ==================== BIẾN NỘI BỘ ====================
        private static PrivateFontCollection? _pfc;
        private static FontFamily? _iconFamily;

        // ==================== UNICODE ICON ====================
        public const string Dashboard = "\ue871"; // dashboard
        public const string ThuNhap = "\ue227"; // attach_money
        public const string ChiTieu = "\ue150"; // money_off
        public const string BaoCao = "\ue85d"; // bar_chart
        public const string ThongKe = "\ue85d"; // bar_chart
        public const string DanhMuc = "\ue8ef"; // category
        public const string DangXuat = "\ue9ba"; // logout
        public const string NguoiDung = "\ue7fd"; // person
        public const string CaiDat = "\ue8b8"; // settings
        public const string LamMoi = "\ue5d5"; // refresh
        public const string Them = "\ue145"; // add_circle
        public const string Sua = "\ue3c9"; // edit
        public const string Xoa = "\ue872"; // delete

        // ==================== KÍCH THƯỚC FONT ====================
        public const float SizeMenu = 18f;
        public const float SizeButton = 14f;
        public const float SizeHeader = 22f;

        // ==================== KHỞI TẠO FONT ====================
        public static void Init()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();

                // Tự động tìm tên resource có đuôi materialicons.ttf
                string? resourceName = null;
                foreach (string n in assembly.GetManifestResourceNames())
                {
                    if (n.EndsWith("materialicons.ttf", StringComparison.OrdinalIgnoreCase))
                    {
                        resourceName = n;
                        break;
                    }
                }

                if (resourceName == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy font!\nKiểm tra:\n" +
                        "1. File materialicons.ttf có trong Resources/\n" +
                        "2. Build Action = Embedded Resource",
                        "Lỗi Font", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (Stream? stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream == null) return;

                    byte[] fontData = new byte[stream.Length];
                    stream.Read(fontData, 0, fontData.Length);

                    GCHandle handle = GCHandle.Alloc(fontData, GCHandleType.Pinned);

                    _pfc = new PrivateFontCollection();
                    _pfc.AddMemoryFont(handle.AddrOfPinnedObject(), fontData.Length);

                    if (_pfc.Families.Length == 0)
                    {
                        MessageBox.Show("Font load được nhưng Families rỗng!\nFile .ttf có thể bị hỏng.", "Lỗi");
                        return;
                    }

                    _iconFamily = _pfc.Families[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load font icon: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== LẤY FONT ====================
        public static Font GetFont(float size = SizeMenu)
        {
            if (_iconFamily == null) Init();
            return new Font(_iconFamily!, size, FontStyle.Regular, GraphicsUnit.Point);
        }

        // ==================== GÁN VÀO BUTTON ====================
        public static void Apply(Button btn, string iconChar, string label, float size = SizeMenu)
        {
            btn.Text = iconChar + "  " + label;
            btn.Font = GetFont(size);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(10, 0, 0, 0);
        }

        // ==================== GÁN VÀO LABEL ====================
        public static void Apply(Label lbl, string iconChar, float size = SizeHeader)
        {
            lbl.Text = iconChar;
            lbl.Font = GetFont(size);
        }
    }
}