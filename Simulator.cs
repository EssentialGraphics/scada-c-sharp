using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using csScada;
using System.Timers;

namespace csScada
{
    public class Simulator
    {
        List<CTag> plc__ = new List<CTag>();                
        private static System.Timers.Timer valueUpdateTimer;

        public Simulator()
        {
            // Creates tags simulating values from PLCs : are the sources 
            // This is just a simple and static representation of tags, must be replaced for production projects

            // TagNames MUST match the ITag Control's names placed by toolbox to window (in property pane)
            CTag var;
            var = new CTag(); var.data.TagName = "@VAR1"; var.data.value = 11; plc__.Add(var);
            var = new CTag(); var.data.TagName = "@VAR2"; var.data.value = 17; plc__.Add(var);
            var = new CTag(); var.data.TagName = "@VAR3"; var.data.value = 33; plc__.Add(var);

            timerIntervalInit();
        }

        public void timerIntervalInit()
        {
            // Create a timer and set a two second interval.
            valueUpdateTimer = new System.Timers.Timer();
            valueUpdateTimer.Interval = 200;

            // Hook up the Elapsed event for the timer. 
            valueUpdateTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            valueUpdateTimer.AutoReset = true;

            // Start the timer
            valueUpdateTimer.Enabled = true;
        }

        // PLC Values changes
        static int k1 = 1; static int k2 = 2; static int k3 = 3;
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            
            // Trivial increment/decrement beetween limits
            if ((int)plc__[0].data.value < 10) { k1 = 1; }; if ((int)plc__[0].data.value >= 90) { k1 = -9; };
            if ((int)plc__[1].data.value < 10) { k2 = 2; }; if ((int)plc__[1].data.value >= 90) { k2 = -1; };
            if ((int)plc__[2].data.value < 10) { k3 = 10; }; if ((int)plc__[2].data.value >= 90) { k3 = -2; };

            // Values variables update
            plc__[0].data.value = (int)(plc__[0].data.value) + k1;
            plc__[1].data.value = (int)(plc__[1].data.value) + k2;
            plc__[2].data.value = (int)(plc__[2].data.value) + k3;
        }

        // Returns variable value
        public int getValue(string tagname) {
            int res = -1;
            foreach (CTag obj in plc__) {
                if (obj.data.TagName == tagname) {
                    res = (int)obj.data.value;
                    goto exitLoop;                    
                }
            }
        exitLoop: return res;
        }
        
        // Lookup into the list
        public CTag getCTag(string tagname) {
            CTag res = null;
            foreach (CTag obj in plc__)
            {
                if (obj.data.TagName == tagname)
                {
                    res = obj;
                    goto exitLoop;
                }
            }
        exitLoop: return res;

        }


    }
}
 

