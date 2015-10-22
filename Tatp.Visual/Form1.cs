using System;
using System.Windows.Forms;
using Tatp.Core;

namespace Tatp.Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sortCombo.DataSource = Enum.GetValues(typeof (SortingAlgorythmsEnum));
        }

        private void sortStart_Click(object sender, EventArgs e)
        {
            int firstRange = 0;
            int lastRange = 0;
            int percents = 0;
            try
            {
               firstRange = (int)startSize.Value;
               lastRange = (int)endSize.Value;
               percents = (int) 100 / (lastRange - firstRange);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (var i = firstRange; i < lastRange; i++)
            {
                var mas = ArrayService.ArrayCreate(i);
                mas.Sort();
                toolStripProgressBar1.Increment(++percents);
            }

            //if (sortCombo.SelectedValue.Equals(SortingAlgorythmsEnum.QuickSort))
            //    toolStripProgressBar1.Increment(5);
        }
    }
}
