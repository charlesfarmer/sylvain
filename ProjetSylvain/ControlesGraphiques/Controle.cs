using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlesGraphiques
{
    public partial class Controle : UserControl
    {
        public Controle()
        {
            //nothing to do
        }

        public void ClearFields()
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(txtBox => txtBox.Clear());
            this.Controls.OfType<DateTimePicker>().ToList().ForEach(dtp => dtp.Value = new DateTime());
            this.Controls.OfType<ComboBox>().ToList().ForEach(comboBox => comboBox.SelectedIndex = 0);
        }
    }
}
