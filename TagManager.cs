using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csScada
{
    // Binds Tag matching from controls to be shown vs actual tag from PLC(simulated for now)
    class TagItem {
        public ITag itagRef;        // Control object that displays tag (instances are on page controls)
        public CTag ctagRef;        // Data containing actual tag values (instances are in simulation class)

        // Constructor
        public TagItem(ITag itag, CTag ctag) {
            itagRef = itag;
            ctagRef = ctag;
        }
    }
        
    // Tag manager acts like as an observer pattern that's dispatch control's refresh updates notifications
    class TagManager
    {
        // Constructor
        public TagManager() {}

        // Inject the Control to value changes notification list (will be notified for new values)
        // All controls must be added in order to have visualization refresh
        public void addTag(string varName, ref ITag iTag){
            CTag cTag = Program.sim.getCTag(iTag.getTagName());         // Lookup
            TagItem item = new TagItem(iTag, cTag);                     // Binding

            tagNotificationList__.Add(item);
        }

        public void removeTag(string groupName, ITag Tag)
        {
            // will be implemented 
        }
        
        // On page unload, all controls references are removed
        public void cleanTagList() {
            tagNotificationList__.Clear();
        }

        // Iterates all the controls registered for a page and sends visualization refresh 
        public void refreshAllVisibleControls()
        {
            foreach (TagItem obj in tagNotificationList__) {
                ITag displayObj = obj.itagRef;
                displayObj.onNewValue(obj.ctagRef.data.value);          // Fires data change event
            }
        }
            
        // Observer list
        List<TagItem> tagNotificationList__ = new List<TagItem>();      // Tags list to be notified for value changes
    }
}
