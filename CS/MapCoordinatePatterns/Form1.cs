using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace MapCoordinatePatterns {

    public partial class Form1 : Form {

        string[] patterns = new string[] {
            "{D:1}°{CP}",
            "{CP}{D:6}°",
            "{D}°{M:2}\'{CP}",
            "{CP}{D}°{M:2}\'",
            "{D}°{M}\'{S:4}\'\'{CP}",            
            "{CP}{D}°{M}\'{S:4}\'\'",
            "Coordinates: {D}°{M}\'{S:2}\'\'{CP}"
        };

        public Form1() {
            InitializeComponent();
            PopulateComboBox(cbXCoordinatePattern);
            PopulateComboBox(cbYCoordinatePattern);
        }

        private void PopulateComboBox(ComboBoxEdit comboBox) {
            comboBox.Properties.Items.AddRange(patterns);
            comboBox.EditValue = comboBox.Properties.Items[0];
        }
        private void OnXCoordinatePatternSelectedIndexChanged(object sender, EventArgs e) {
            map.NavigationPanelOptions.XCoordinatePattern = cbXCoordinatePattern.EditValue as String;
        }

        private void OnYCoordinatePatternSelectedIndexChanged(object sender, EventArgs e) {
            map.NavigationPanelOptions.YCoordinatePattern = cbYCoordinatePattern.EditValue as String;
        }
    }
}
