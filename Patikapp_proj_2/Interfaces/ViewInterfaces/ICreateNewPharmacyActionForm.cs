using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public interface ICreateNewPharmacyActionForm
    {
        TextBox AdressTextBox1 { get; set; }
        Button Associate_button { get; set; }
        Button CreatePharmacyButton1 { get; set; }
        Button DissociateButton { get; set; }
        TextBox FacebookTextBox1 { get; set; }
        DataGridViewTextBoxColumn IdDataGridViewTextBoxColumn { get; set; }
        TextBox NameTextBox1 { get; set; }
        TextBox PhoneTextBox1 { get; set; }
        DataGridViewTextBoxColumn UsernameDataGridViewTextBoxColumn { get; set; }
        BindingSource UsersBindingSource1 { get; set; }
        TextBox WebTextBox1 { get; set; }
    }
}