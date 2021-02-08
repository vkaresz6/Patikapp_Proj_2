using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public interface IUpdatePharmacy
    {
        TextBox AdressTextBox1 { get; set; }
        Button CreatePharmacyButton1 { get; set; }
        TextBox FacebookTextBox1 { get; set; }
        TextBox NameTextBox1 { get; set; }
        TextBox PhoneTextBox1 { get; set; }
        TextBox WebTextBox1 { get; set; }
        void HideClose();
    }
}