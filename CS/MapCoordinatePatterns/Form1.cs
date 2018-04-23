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
            FillLongitudePattern();
            FillLatitudePattern();
        }

        public void FillLongitudePattern() {
            cbLongitude.EditValue = patterns[0];
            cbLongitude.Properties.Items.AddRange(patterns);
        }

        public void FillLatitudePattern() {
            cbLatitude.EditValue = patterns[0];
            cbLatitude.Properties.Items.AddRange(patterns);
        }

        private void cbLatitude_EditValueChanged(object sender, EventArgs e) {
            mapControl1.NavigationPanelOptions.LatitudePattern = cbLatitude.EditValue.ToString();
        }

        private void cbLongitude_EditValueChanged(object sender, EventArgs e) {
            mapControl1.NavigationPanelOptions.LongitudePattern = cbLongitude.EditValue.ToString();
        }
    }
}
