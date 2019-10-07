using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace csScada
{
    /* The control Inherits Windows.Form in order to enhance load/unload tag to tagmanager.
     * Once control's undelying tags are registered to TagManager, are subject to be notified while a value
     * changes and the "magic" of refresh without any code is achieved.
     */

    public class TagWindowsForm : System.Windows.Forms.Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Injects ITags into master TagManager to monitor values
            foreach (var obj in this.Controls)
            {
                // Each object that implements ITag - value change notification behaviour, is added to be monitored for data change
                if (obj is ITag) {
                    ITag instObject = (ITag)obj;
                    csScada.Program.tagmanager.addTag(instObject.getTagName(), ref instObject);
                }
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            // Empty TagManager, removes any object notification
            csScada.Program.tagmanager.cleanTagList();

            base.OnClosed(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TagWindowsForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "TagWindowsForm";
            this.Load += new System.EventHandler(this.TagWindowsForm_Load);
            this.ResumeLayout(false);

        }

        private void TagWindowsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
