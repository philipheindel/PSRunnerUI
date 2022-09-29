using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptRunnerUI.Classes
{
    public class Script
    {
        private string name;
        private string scriptPath;
        private ScriptArg sa;
        
        public string Name { 
            get { return name; } 
            set { this.name = value; } 
        }
        
        public string ScriptPath
        {
            get { return scriptPath; }
            set { this.scriptPath = value; }
        }

        private class ScriptArg
        {
            private string name;
            private int type;

            public string Name { 
                get { return this.name; }
                set { this.name = value; }
            }
        }
    }
}
