using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAppForm
{
    public partial class AddQuestionForm : Form
    {
        int yPosition = 41;
        int dy = 40;
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(34, yPosition);
            textBox.Name = "txtSemenXachik";
            textBox.Size = new System.Drawing.Size(499, 30);
            textBox.TabIndex = 2;

            CheckBox checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.Location = new System.Drawing.Point(548, yPosition);
            checkBox.Name = "cbSemenXachik";
            checkBox.Size = new System.Drawing.Size(222, 29);
            checkBox.TabIndex = 1;
            checkBox.Text = "Правильна відповідь";
            checkBox.UseVisualStyleBackColor = true;
            gbListAnswers.Controls.Add(textBox);
            gbListAnswers.Controls.Add(checkBox);
            yPosition += dy;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var listConrols=this.gbListAnswers.Controls;
            string result = "";
            foreach(object item in listConrols)
            {
                if(item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    result += textBox.Text + "\r\n";
                }
            }
            MessageBox.Show(result);
        }
    }
}
