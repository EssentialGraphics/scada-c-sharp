using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csScada
{
    // Tag quality, actually not used
    public enum enuTagQuality {
            unknown=0,
            BAD=1,
            GOOGD=2
    }

    // Complete TAG data fields (desumed by OPC layout)
    public class TagInfo{
        Int16 id;                               // Unique identifier
        public string TagName;                  // ie: tankLevel
        public string FullTagName;              // ie: plc1://areaAlpha/fuel/tankLevel
        public DateTime lastUpdateTime;         // Last refresh datetime from field

        public enuTagQuality quality=0;         // Tag Quality from field
        public object value=0;                  // Tag Value
    }

    // Tags helper class 
    public class CTag
    {
        public TagInfo data;                        // Internal data
        public CTag() { data = new TagInfo(); }     // Constructor
    }
     
   
    public interface ITag {
        /* 
         * Main function. Receives notifications for Tag update.
         * Has to be overloaded in derived controls to achieve polimorphic behaviour.
         * 
         * To implement a new control, i.e. a db-logger, a bargraph, a trend, tag value file write, or any other you like,
         * it's enough to implement for it the method ITag.onNewValue and that control will result as transparent as 
         * TagLabel or TagProgressBar. They practically will not require any code to be written each time you design
         * a new itam, it's enough to drag and drop from Controls toolbox and assign TAG Varible Name in Control's 
         * property pane. The magic is handled by underlying TagWindowsForm extension of forms.
         * 
         */
        void onNewValue(object newValue);

        // Returns Control TagName property (that is specified in property pane in Solution Explorer window)
        string getTagName();        // This must match a variable name stored into the PLC (simulator for now - @VAR1/2/3)

    };
}
