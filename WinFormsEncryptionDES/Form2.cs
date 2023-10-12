using System.Drawing;
using System.Windows.Forms;

namespace WinFormsEncryptionDES
{
    public partial class Form2 : Form
    {
        private DESAlgorithm _des;
        private Form2()
        {
            InitializeComponent();
        }

        public Form2(DESAlgorithm des)
            : this()
        {
            _des = des;
            for(int i = 0; i < 16; i++)
            {
                Label label1 = new Label();
                Label label2 = new Label();
                Label label3 = new Label();
                label1.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label2.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label3.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label1.AutoSize = true;
                label2.AutoSize = true;
                label3.AutoSize = true;
                label1.Text = ((i + 1).ToString().PadLeft(2, '0') + ":  " + _des.HistoryKey[i].PadLeft(12,'0')).ToUpper();
                this.flowLayoutPanel1.Controls.Add(label1);
                label2.Text = ((i + 1).ToString().PadLeft(2, '0') + ":  " + _des.HistoryLeft[i].PadLeft(8,'0')).ToUpper();
                this.flowLayoutPanel2.Controls.Add(label2);
                label3.Text = ((i + 1).ToString().PadLeft(2, '0') + ":  " + _des.HistoryRight[i].PadLeft(8,'0')).ToUpper();
                this.flowLayoutPanel3.Controls.Add(label3);
            }
        }
    }
}
