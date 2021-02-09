using System.Windows.Forms;

namespace Patikapp_proj_2.Interfaces.ViewInterfaces
{
    public interface IChatForm
    {
        TextBox chatBox { get; set; }
        TextBox msgBox { get; set; }
        DataGridView userGridView { get; set; }
    }
}