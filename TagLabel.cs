using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using csScada;

namespace csScada
{
    /* 
     * TagControlLabel represents a displayable control, draggable to window by toolbox, 
     * that shows actual value for a Tag. 
     * It's populated overriding "onNewValue(ref Tag newValue)" from ITag abstract class.  
     * 
     */

    public class TagLabel : System.Windows.Forms.Label, ITag
    {
        public TagLabel() {}                        // Contructor

        public string TagName { get; set; }         // Get and set value from property pane in Solution Explorer
        
        string ITag.getTagName()                    
        {
            // Helper to return variable name to ITag interface class (suddenly quite redundant for controls)
            return TagName;
        }

        // Main implementation for value update
        void ITag.onNewValue(object newValue) {
            this.Invoke(new Action(() => this.Text = newValue.ToString()));     // Thread safe control update
        }

    }
}
