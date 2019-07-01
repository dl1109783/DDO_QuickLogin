using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuickLogin.Connect;

namespace QuickLogin
{
    public partial class CheckUser : Form
    {
        public SubscriptionUser SelectUser;

        public CheckUser(List<SubscriptionUser> p_alList)
        {
            InitializeComponent();
            SelectUser = null;
            if (p_alList != null && p_alList.Count > 0)
            {
                lbCheckList.DisplayMember = "Description";
                lbCheckList.Items.Clear();
                foreach (SubscriptionUser gsb in p_alList)
                {
                    lbCheckList.Items.Add(gsb);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SelectUser = (SubscriptionUser)lbCheckList.SelectedItem;
            this.Hide();
        }
    }
}