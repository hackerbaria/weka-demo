using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;
            
            DialogResult a = openFileDialog1.ShowDialog();            

            // Process input if the user clicked OK.
            if (a == DialogResult.OK)
            {
                // Open the selected file to read.
                System.IO.Stream fileStream = openFileDialog1.OpenFile();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    // Read the first line from the file and write it the textbox.
                   // tbResults.Text = reader.ReadLine();
                }
                fileStream.Close();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gboxClusterer_Enter(object sender, EventArgs e)
        {

        }

        private void tagPreproccess_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gboxAttribute_Enter(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnInvert_Click(object sender, EventArgs e)
        {

        }

        private void btnNone_Click(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        private void gboxCurrent_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAttributes_Click(object sender, EventArgs e)
        {

        }

        private void txtInstances_Click(object sender, EventArgs e)
        {

        }

        private void txtRelationContent_Click(object sender, EventArgs e)
        {

        }

        private void txtRelation_Click(object sender, EventArgs e)
        {

        }

        private void gboxFilter_Enter(object sender, EventArgs e)
        {

        }

        private void txtChoose_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenDB_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenURL_Click(object sender, EventArgs e)
        {

        }

        private void tagClassify_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabCluster_Click(object sender, EventArgs e)
        {

        }

        private void tabAssociate_Click(object sender, EventArgs e)
        {

        }

        private void tabSelectAttributes_Click(object sender, EventArgs e)
        {

        }

        private void tabVisualize_Click(object sender, EventArgs e)
        {

        }

        private void gboxClassifier_Enter(object sender, EventArgs e)
        {

        }

        private void btnChooseCla_Click(object sender, EventArgs e)
        {

        }

        private void txtChooseCla_TextChanged(object sender, EventArgs e)
        {

        }

        private void gboxTestOptions_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMoreOptionCla_Click(object sender, EventArgs e)
        {

        }

        private void btnSetCla_Click(object sender, EventArgs e)
        {

        }

        private void lblFold_Click(object sender, EventArgs e)
        {

        }

        private void txtFoldCla_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPercent_Click(object sender, EventArgs e)
        {

        }

        private void txtPercentCla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStartCla_Click(object sender, EventArgs e)
        {

        }

        private void btnStopCla_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gboxClassifierOut_Enter(object sender, EventArgs e)
        {

        }

        private void txtClassifierOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtOkCla_Click(object sender, EventArgs e)
        {

        }

        private void btnLogCla_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtChooseClu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseClu_Click(object sender, EventArgs e)
        {

        }

        private void gboxClusterMode_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnStartClu_Click(object sender, EventArgs e)
        {

        }

        private void btnStopClu_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gboxClustererOutput_Enter(object sender, EventArgs e)
        {

        }

        private void txtClustererOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
