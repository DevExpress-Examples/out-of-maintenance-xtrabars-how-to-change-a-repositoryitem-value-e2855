using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using System.Threading;
using DevExpress.XtraEditors;

namespace WindowsApplication1
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
            InitValues();
            Calculate();
            foreach (RepositoryItem item in ribbon.Manager.RepositoryItems)
            {
                item.EditValueChanged += new EventHandler(item_EditValueChanged);
            }
        }

        void item_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is CheckEdit)
            {
                beiProgress.Visibility = (sender as CheckEdit).Checked ? BarItemVisibility.Always : BarItemVisibility.Never;
                return;
            }
            ribbon.Manager.ActiveEditItemLink.PostEditor();
            ShowProgress();
            Calculate();
        }
        private void InitValues()
        {
            beiValueA.EditValue = 1;
            beiOperation.EditValue = "Plus";
            beiValueB.EditValue = 2;
            beiShowProgress.EditValue = true;           
        }

        private void ShowProgress()
        {
            if (beiProgress.Visibility == BarItemVisibility.Never)
                return;
            for (int i = repositoryItemProgressBar1.Minimum; i < repositoryItemProgressBar1.Maximum; i++)
            {
                beiProgress.EditValue = i;
                Application.DoEvents();
                Thread.Sleep(1);
            }
        }
        private void Calculate()
        {
            int operation = object.Equals(beiOperation.EditValue, "Minus") ? -1 : 1;
            float result = Convert.ToInt32(beiValueA.EditValue) + Convert.ToInt32(beiValueB.EditValue) * operation;
            bsiResult.Caption ="Result = " +  result;
        }
    }
}