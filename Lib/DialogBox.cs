using System;
using System.Windows.Forms;

namespace InvoiceSoftware {
    public class DialogBox {
        public static void Show(string msg, string title = AAS.PROGRAM_TITLE, MessageBoxButtons btns = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information) => MessageBox.Show(msg, title, btns, icon);

        public static void ChangesSaved(string msg = "", string title = AAS.PROGRAM_TITLE, MessageBoxButtons btns = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information) => DialogBox.Show("Changes saved. " + msg, title, btns, icon);

        public static void Error(string msg, string title = "Error", MessageBoxButtons btns = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error) => MessageBox.Show(msg, title, btns, icon);

        public static bool Confirm(string msg, string title = AAS.PROGRAM_TITLE, MessageBoxButtons btns = MessageBoxButtons.YesNo, MessageBoxIcon icon = MessageBoxIcon.Question) => (MessageBox.Show(msg, title, btns, icon) == DialogResult.Yes);

        public static void ErrorUnexpected(Exception ex, string msg = "", string title = "Unexpected Error", MessageBoxButtons btns = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error) {
            DialogBox.Error("An unexpected error has occurred. The application will now close. " + msg + "\n\n" + ex.GetBaseException().ToString() + ":\n\n"
            + ex.Message, title, btns, icon);
            Environment.Exit(1);
        }

        public static DialogResult AbortRetryIgnore(string msg, string title = AAS.PROGRAM_TITLE, MessageBoxButtons btns = MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon icon = MessageBoxIcon.Warning) => MessageBox.Show(msg, title, btns, icon);
    }
}