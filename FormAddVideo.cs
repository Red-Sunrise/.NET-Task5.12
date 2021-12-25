using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class FormAddVideo : Form
    {
        Form1 form;
        public FormAddVideo(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string Title = textBoxTitle.Text;
            string Genre = textBoxGenre.Text;
            int Duration = Convert.ToInt32(NumericUpDownDuration.Value);
            Video video = new Video(Title,Genre,Duration);
            form.AddVideo(video);
            this.Close();
        }
    }
}
