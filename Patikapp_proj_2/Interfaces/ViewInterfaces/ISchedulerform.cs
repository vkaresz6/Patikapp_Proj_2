using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public interface ISchedulerform
    {
        Button AddButton { get; set; }
        DataGridView DataGridView1 { get; set; }
        Button DeleteButton1 { get; set; }
        DateTimePicker Exp { get; set; }
        TextBox Hh { get; set; }
        TextBox Mm { get; set; }
        RichTextBox RichTextBox2 { get; set; }
    }
}