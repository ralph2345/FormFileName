using System;
using System.IO;
using System.Windows.Forms;

namespace FrmLab1
{
    internal class Form1 : Form
    {
        private Button btnCreate;
        private TextBox textBox1;

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(90, 115);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 39);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            FormFilaName frm = new FormFilaName();
            frm.ShowDialog();

            string getInput = btnCreate.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, FormFilaName.SetFileName)))
            {

                sw.WriteLine(getInput);   
            }
        }
    }
}