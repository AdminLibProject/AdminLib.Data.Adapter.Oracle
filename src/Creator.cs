using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminLib.Data.Adapter;

namespace AdminLib.Data.Adapter.Oracle {
    public class Creator : AdminLib.Data.Adapter.Adapter.ICreator {

        public string name {get; private set; }

        /******************** Constructor ********************/
        internal Creator(string name) {
            this.name = name;
        }

        /******************** Method ********************/
        public Data.Adapter.Adapter GetNewAdapter(Configuration configuration) {
            Adapter oracleAdapter;

            oracleAdapter = new Adapter ( configuration : configuration);

            return oracleAdapter;
        }

        public Data.Adapter.Adapter GetNewAdapter(AdapterConfiguration configuration, bool autoCommit)
        {
            
            if (!(configuration is Configuration))
                throw new System.Exception("Invalid configuration");

            return this.GetNewAdapter ( configuration : (Configuration) configuration
                                      , autoCommit    : autoCommit);

        }
    }
}