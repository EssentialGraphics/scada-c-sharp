using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using csScada;


namespace csScada
{   
    static class Program
    {

        public static Simulator sim;                    // PLC Tag Simulator instance (will be relaced with an "OPC" interface in future)          
        public static AsynchLoop loop;                  // Main visualization refresh loop 
        public static TagManager tagmanager;            // Master Tag Manager instance
               
        [STAThread]
        static void Main()
        {
            // Instances of core components
            tagmanager = new TagManager();              // Acts like observer pattern      
            sim = new Simulator();                      // Updates simulated variables
            loop = new AsynchLoop();                    // Poll that executes visualization refresh
                        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
