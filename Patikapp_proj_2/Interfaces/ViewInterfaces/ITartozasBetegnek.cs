using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public interface ITartozasBetegnek
    {
        DataGridView ActiveDebtGridView1 { get; set; }
        Button AddDebt1 { get; set; }
        Button DeleteDebt1 { get; set; }
        DataGridView GyogyszDataGridView { get; set; }
        DataGridView UserPickerGridView1 { get; set; }
        BindingSource UsersBindingSource { get; set; }
        NumericUpDown AmountPicker1 { get; set; }
    }
}