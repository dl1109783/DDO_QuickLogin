using System;
using System.Collections;
using System.Windows.Forms;
using QuickLogin.AuthServer;

namespace QuickLogin
{
    public partial class CheckUser : Form
    {
        public GameSubscription checkGsb;

        public CheckUser(ArrayList p_alList)
        {
            InitializeComponent();
            checkGsb = null;
            if (p_alList != null && p_alList.Count > 0)
            {
                lbCheckList.DisplayMember = "Name";
                lbCheckList.Items.Clear();
                foreach (GameSubscription gsb in p_alList)
                {
                    lbCheckList.Items.Add(gsb);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            checkGsb = (GameSubscription)lbCheckList.SelectedItem;
            this.Hide();
        }
    }
}