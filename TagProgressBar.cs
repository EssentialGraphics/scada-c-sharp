using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csScada
{

    // NOTE: see TagLabel for comments

    class TagProgressBar : System.Windows.Forms.ProgressBar, ITag
    {
        
        public TagProgressBar(){}

        public string TagName { get; set; }

        string ITag.getTagName()
        {
            return TagName;
        }

        
        void ITag.onNewValue(object newValue)
        {
            // custom implementation for this type of control class is here
            this.Invoke(new Action(() => this.Value = (int)newValue));
        }
       
    }
}
