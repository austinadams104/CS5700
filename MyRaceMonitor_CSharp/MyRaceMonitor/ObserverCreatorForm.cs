using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRaceMonitor
{
    public partial class ObserverCreatorForm : Form
    {
        public ObserverCreatorForm()
        {
            InitializeComponent();
        }

        public string ObserverTitle
        {
            get { return txtObserverTitle.Text; }
            set { txtObserverTitle.Text = value; }
        }
        public string ObserverType
        {
            get { return (getObserverType()); }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public string getObserverType()
        {
            //This will get the radiobutton that is clicked
            if(rdList.Checked)
            {
                return "L";
            }
            else if (rdGraphical.Checked)
            {
                return "G";
            }
            else if (rdEmail.Checked)
            {
                return "E";
            }
            else if (rdCompare.Checked)
            {
                return "C";
            }
            else
            {
                return "B";
            }
        }
    }
}
