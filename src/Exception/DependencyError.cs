﻿using Oracle.ManagedDataAccess.Client;
using AdminLib.Data.Query.Exception;
using AdminLib.Data.Query;

namespace AdminLib.Data.Adapter.Oracle.Exception {

    public class DependencyError : AdapterException {

        //******************** Constants ********************/
        public const Code code = Code.DEPENDENCY_ERROR;

        //******************** Constructors ********************/
        public DependencyError ( OracleException exception
                               , string query=null
                               , QueryParameter[] parameters=null) : base(exception, query, parameters) { }

    }
}