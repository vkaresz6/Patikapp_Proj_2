using Patikapp_proj_2.Resorurces.CustomControlls;
using System;
using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public interface IPharmaciesManager
    {
        TextBox AdressTextBox1 { get; set; }
        TextBox FacebookTextBox1 { get; set; }
        ComboBox NameCombobox1 { get; set; }
        TextBox PhoneTextBox1 { get; set; }
        TextBox WebTextBox1 { get; set; }
        int getSelected();
        String getName();
    }
}