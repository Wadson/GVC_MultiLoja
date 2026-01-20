using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.Infra.Database
{
    internal static class ScriptManifest
    {
        public static readonly string[] Scripts =
        {
            "01_CreateDatabase.sql",
            "02_Tables.sql",
            "03_Functions.sql",
            "04_Defaults.sql",
            "05_ForeignKeys.sql",
            "06_Checks.sql",
            "07_Views.sql",
            "08_Procedures.sql",
            "09_Seed.sql",
            "10_CargaEstado.sql",
            "11_CargaCidade.sql"
        };
    }
}

