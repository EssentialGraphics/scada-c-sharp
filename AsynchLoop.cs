using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace csScada
{
    // This class supply the main control loop that executes the control's refresh on window as a poll
    class AsynchLoop
    {
        private static System.Timers.Timer loopTimer;   // Control loop timer
        
        public AsynchLoop() { timerIntervalInit(); }    // Constructo

        public void timerIntervalInit()
        {
            // Create a timer and set a two second interval.
            loopTimer = new System.Timers.Timer();
            loopTimer.Interval = 300;

            // Hook up the Elapsed event for the timer. 
            loopTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            loopTimer.AutoReset = true;

            // Start the timer
            loopTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            // Call main notificator method
            Program.tagmanager.refreshAllVisibleControls();     // Updates window visualization
        }

    }
}
