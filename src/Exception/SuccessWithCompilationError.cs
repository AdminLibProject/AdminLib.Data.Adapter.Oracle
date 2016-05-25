﻿using Oracle.ManagedDataAccess.Client;
using AdminLib.Data.Query.Exception;
using AdminLib.Data.Query;

namespace AdminLib.Data.Adapter.Oracle.Exception {

    public class SuccessWithCompilationError : QueryException {

        //******************** Constants ********************/
        public const Code code = Code.SUCCESS_WITH_COMPILATION_ERROR;

        //******************** Constructors ********************/
        public SuccessWithCompilationError ( OracleException exception
                                           , string query=null
                                           , QueryParameter[] parameters=null) : base(exception, query, parameters) { }

    }
}