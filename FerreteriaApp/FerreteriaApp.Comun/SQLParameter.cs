﻿using System.Data;

namespace FerreteriaApp.Comun
{
    public class SQLParameter
    {
        public string Name;
        public object Value;
        public SqlDbType Type;
        public SQLParameter(string name, object value, SqlDbType type)
        {
            Name = name;
            Value = value;
            Type = type;
        }
    }
}
