using System;
using System.Data;

namespace DTOGenerador
{
    public class DTOUtils
    {
        private int Type { get; set; }

        public DTOUtils(int type) 
        {
            this.Type = type;
        }

        public Tuple<int, object> GetDatabases(string server, string user, string pass)
        {
            string query;

            if (Type.Equals(0))
            {
                query = @"select 
	                            name 
                          from sys.databases
                          where name not in ('master', 'tempdb', 'model', 'msdb')
                          order by name;";
            }
            else
            {
                query = @"select distinct
	                             table_schema as name
                          from   information_schema.tables
                          where  lower(table_type) = 'base table' and table_schema not in ('mysql', 'information_schema', 'performance_schema', 'sys')
                          order by table_schema;";
            }

            var dtDatos  = new DataTable();
            var conexion = new DTOConexion(Type, server, user, pass);

            int result = conexion.CargaTabla(query, ref dtDatos);
            if (result.Equals(0))
            {
                return new Tuple<int, object>(0, dtDatos);
            } else
            {
                return new Tuple<int, object>(-1, conexion.MensajeError);
            }
        }

        public Tuple<int, object> GetTables(string server, string user, string pass, string bd)
        {
            string query;

            if (Type.Equals(0))
            {
                query = @"select 
	                            a.name
                          from sys.objects as a
                          inner join sys.schemas as b on (a.schema_id = b.schema_id) 
                          where type_desc = 'USER_TABLE' and a.name not like 'MSMerge%'
                          order by b.name, a.name;";
            }
            else
            {
                query = @"select 
	                            table_name as name
                          from information_schema.tables 
                          where lower(table_type) = 'base table' and table_schema = '" + bd + "';";
            }
            
            var dtDatos = new DataTable();
            var conexion = new DTOConexion(Type, server, user, pass, bd);

            int result = conexion.CargaTabla(query, ref dtDatos);
            if (result.Equals(0))
            {
                return new Tuple<int, object>(0, dtDatos);
            }
            else
            {
                return new Tuple<int, object>(-1, conexion.MensajeError);
            }
        }

        public Tuple<int, object> GetEstruc(string server, string user, string pass, string bd, string table)
        {
            string query;

            if (Type.Equals(0))
            {
                query = string.Format(
                        @"select
	                            col.name,
	                            typ.name as type,
	                            case when col.is_nullable = 1 then 1 else 0 end as isNull
                            from sys.columns col 
                            join sys.types typ on col.system_type_id = typ.system_type_id and col.user_type_id = typ.user_type_id 
                            where object_id = object_id('{0}') 
                            order by col.column_id;", table);
            }
            else
            {
                query = string.Format(
                        @"select 
	                            column_name as name,
	                            data_type as type,
	                            case when is_nullable = 'NO' then 0 else 1 end as isNull
                          from  information_schema.columns 
                          where table_name = '{0}'
                          order by ordinal_position;", table);
            }

            var dtDatos = new DataTable();
            var conexion = new DTOConexion(Type, server, user, pass, bd);

            int result = conexion.CargaTabla(query, ref dtDatos);
            if (result.Equals(0))
            {
                return new Tuple<int, object>(0, dtDatos);
            }
            else
            {
                return new Tuple<int, object>(-1, conexion.MensajeError);
            }
        }

        public string FormatName(string name)
        {
            name = name.ToLower().Replace(" ", "_");

            string[] nameCol = name.Split('_');
            string newName = "";

            for (int i = 0; i < nameCol.Length; i++)
            {
                if (newName != "")
                {
                    newName += "_";
                }

                newName += nameCol[i].Substring(0, 1).ToUpper() + nameCol[i].Substring(1, nameCol[i].Length - 1);
            }

            return newName;
        }

        public string FormatType(string type)
        {
            switch (type.ToLower())
            {
                case "bigint":           return "long";
                case "binary":           return "byte[]";
                case "bit":              return "bool";
                case "char":             return "string";
                case "date":             return "DateTime";
                case "datetime":         return "DateTime";
                case "datetime2":        return "DateTime";
                case "datetimeoffset":   return "DateTimeOffset";
                case "decimal":          return "decimal";
                case "float":            return "float";
                case "image":            return "byte[]";
                case "int":              return "int";
                case "money":            return "decimal";
                case "nchar":            return "char";
                case "ntext":            return "string";
                case "numeric":          return "decimal";
                case "nvarchar":         return "string";
                case "real":             return "double";
                case "smalldatetime":    return "DateTime";
                case "smallint":         return "short";
                case "smallmoney":       return "decimal";
                case "text":             return "string";
                case "time":             return "TimeSpan";
                case "timestamp":        return "DateTime";
                case "tinyint":          return "byte";
                case "uniqueidentifier": return "Guid";
                case "varbinary":        return "byte[]";
                case "varchar":          return "string";
                default:                 return "UNKNOWN_" + type;
            }
        }
    }
}
