using System.Windows.Forms;

namespace Patikapp_proj_2.Views
{
    public interface IPharmacyManager_action_picker
    {
        Label Label1 { get; set; }
        Button PharmacyManager_AssociateEmployeeAction { get; set; }
        Button PharmacyManager_DeleteAction1 { get; set; }
        Button PharmacyManager_ModifyAction { get; set; }
        Label Selected1 { get; set; }
    }
}