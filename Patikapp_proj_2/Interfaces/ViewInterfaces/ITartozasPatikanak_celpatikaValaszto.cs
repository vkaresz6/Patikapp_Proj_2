using Patikapp_proj_2.Presenters;
using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public interface ITartozasPatikanak_celpatikaValaszto
    {
        TextBox amountTextBox1 { get; set; }
        DataGridView pharmaciesDataGridView1 { get; set; }
        Button saveButton1 { get; set; }
    }
}