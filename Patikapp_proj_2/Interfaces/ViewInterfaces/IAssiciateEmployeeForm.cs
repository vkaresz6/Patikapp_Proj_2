using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public interface IAssiciateEmployeeForm
    {
        Button AssociateButton1 { get; set; }
        DataGridView employeeGridView { get; set; }
        Button DissociateButton1 { get; set; }
        Label TitleLabel1 { get; set; }
        DataGridView UsersGridView { get; set; }
    }
}