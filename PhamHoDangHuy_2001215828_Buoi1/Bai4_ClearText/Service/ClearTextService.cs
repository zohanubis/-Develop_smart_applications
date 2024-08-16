using System.Windows.Forms;

namespace Bai4_ClearText.Service
{
    public static class ClearTextService
    {
        // Hàm để xóa dữ liệu trong tất cả các TextBox trên form
        public static void ClearAllTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        // Hàm để xóa dữ liệu trong các TextBox nằm trong Container cụ thể
        public static void ClearTextBoxesInContainer(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }
    }
}
