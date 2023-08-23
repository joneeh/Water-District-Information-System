using System.Windows.Forms;

namespace Water_District_Information_System
{
    public partial class waterDistrictInformationSystem : Form
    {
        public waterDistrictInformationSystem()
        {
            InitializeComponent();
        }

        private void waterDistrictInformationSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
