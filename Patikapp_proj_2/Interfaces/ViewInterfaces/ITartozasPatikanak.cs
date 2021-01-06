using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public interface ITartozasPatikanak
    {
        Button AddButton1 { get; set; }
        DataGridView DataGridView1 { get; set; }
        DataGridView GyogyszTorzsGridView { get; set; }
        Label PhNameLabel1 { get; set; }
        Button RemoveButton1 { get; set; }
        TextBox SearchTextBox1 { get; set; }
    }
}