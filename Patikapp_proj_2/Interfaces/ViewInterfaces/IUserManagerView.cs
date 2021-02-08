using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public interface IUserManagerView
    {
        Button DeleteButtun1 { get; set; }
        Button DisplayButton1 { get; set; }
        Label LabelName { get; set; }
        Button ResetPsw1 { get; set; }
        DataGridView UserDataGridView1 { get; set; }
        TextBox TextBox1 { get; set; }
    }
}