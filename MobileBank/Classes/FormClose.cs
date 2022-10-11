using System.Windows.Forms;

namespace MobileBank.Classes
{
    class FormClose
    {
        static volatile FormClose Class;
        static object SyncObject = new object();
        public static FormClose GetInstance
        {
            get
            {
                if (Class == null)
                    lock (SyncObject)
                    {
                        if (Class == null)
                            Class = new FormClose();
                    }
                return Class;
            }
        }

        public bool FClose()
        {
            var result = MessageBox.Show("Вы действительно хотите закрыть программу?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) return false;
            else return true;
        }
    }
}
