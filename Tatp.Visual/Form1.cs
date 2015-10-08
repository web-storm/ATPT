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
<<<<<<< HEAD
            sortCombo.DataSource = Enum.GetValues(typeof (SortingAlgorythmsEnum));
        }

        private void sortStart_Click(object sender, EventArgs e)
        {
            var mas = ArrayService.ArrayCreate(5);
            
            if (sortCombo.SelectedValue.Equals(SortingAlgorythmsEnum.QuickSort))
                toolStripProgressBar1.Increment(5);
=======
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mas = ArrayService.ArrayCreate(5);
>>>>>>> 951e7468580d7d9f1647dd4aded61ed55e1a7c55
        }
    }
}
