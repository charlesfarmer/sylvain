using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlCoordonées
{
    public partial class ControleCoordonees: UserControl
    {
        #region constructor
        public ControleCoordonees()
        {
            InitializeComponent();
        }
        #endregion
        #region properties
        public string TxtNom
        {
            get;
            set;
        }
        public string TxtPrenom
        {
            get;
            set;
        }
        public string TxtAdresse
        {
            get;
            set;
        }
        public string TxtTelephone
        {
            get;
            set;
        }
        #endregion
        #region events
        #endregion
        #region event handlers
        #endregion
    }
}
