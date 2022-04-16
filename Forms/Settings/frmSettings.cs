using IniParser;
using IniParser.Model;
using System;
using System.Windows.Forms;

namespace InvoiceSoftware.Forms.Settings {
    public partial class frmSettings : Form {
        public frmSettings() => InitializeComponent();

        private string CONFIG_APPLICATION = "APPLICATION";
        private string CONFIG_CONNECTIONS = "CONNECTIONS";

        private void frmSettings_Load(object sender, EventArgs e) {
            if (!Roles.isAdmin()) {
                DialogBox.Error("Access denied; only administrators may access application-level settings.");
                this.Close();
                this.Visible = false;
                frmMain.instance.Focus();
                return;
            }
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(filePath: AAS.GetConfigFile());
            int maxLoginAttempts = Utils.CInt(data[CONFIG_APPLICATION]["MaxLoginAttempts"]);
            bool showDialogAfterSave = Utils.CBool(data[CONFIG_APPLICATION]["ShowDialogAfterSave"]);
            this.txtMaxLoginAttempts.Text = maxLoginAttempts.ToString();
            this.chkShowDialog.Checked = showDialogAfterSave;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e) {
            AAS.maxLoginAttempts = Utils.CInt(this.txtMaxLoginAttempts.Text);
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(filePath: AAS.GetConfigFile());

            data[CONFIG_APPLICATION]["MaxLoginAttempts"] = AAS.maxLoginAttempts.ToString();
            data[CONFIG_APPLICATION]["ShowDialogAfterSave"] = AAS.showDialogsAfterSave.ToString();

            parser.WriteFile(filePath: AAS.GetConfigFile(), data);
            this.Close();
            this.Visible = false;
            frmMain.instance.Focus();
        }
    }
}