using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FFImageTest.Client.Lib.Controls.ListView
{
    public partial class DetailsActionTemplate : BaseDetailsRowViewCell
    {
        public double ValueWithActionsWidth => ValueWidth - ActionsWidth;
        public double ActionsWidth => 40;

        public DetailsActionTemplate()
        {
            InitializeComponent();
        }

        protected override void OnWidthChanged()
        {
            base.OnWidthChanged();
            OnPropertyChanged(nameof(ValueWithActionsWidth));
        }

        private void ShortcutButton_Clicked(object sender, EventArgs e)
        {
            var button = (ImageButton)sender;
        }
    }
}