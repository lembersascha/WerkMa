﻿// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

#region Verweise

using System;

#endregion

namespace Lember.WerkMa.Allgemein.Variablen.VariablenClass
{
    public static class ConnectionString
    {
        #region Fields

        private static bool _isConnectionStringSet;

        public static string ConnectionStringPath { get; private set; }

        #endregion

        #region Methods

        public static void SetConnectionStringPath(string path)
        {
            if (!_isConnectionStringSet)
            {
                ConnectionStringPath   = path;
                _isConnectionStringSet = true;
            }
            else
            {
                throw new InvalidOperationException(
                        "Der Datenbankstring kann nur beim Programmstart gesetzt werden");
            }
        }

        #endregion
    }
}