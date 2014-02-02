using System;
using System.Windows.Forms;

namespace DraggableControls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void checkBox_DragForm_CheckedChanged(object sender, EventArgs e)
        {
            this.Draggable(checkBox_DragForm.Checked);
        }

        private void checkBox_DragButton_CheckedChanged(object sender, EventArgs e)
        {
            btnTest.Draggable(checkBox_DragButton.Checked);
        }
    }
}
