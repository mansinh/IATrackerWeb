using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;

public class SqliteHelper 
{
    public string db_connectionString;
    public IDbConnection db_connection;

    public SqliteHelper(string database_name) {
        db_connectionString = "URI=file:" + Application.persistentDataPath + "/" + database_name;
        db_connection = new SqliteConnection(db_connectionString);
        db_connection.Open();
    }


    public IDbCommand GetDbCommand()
    {
        return db_connection.CreateCommand();
    }

    public IDataReader GetByValue(string table, string key, string value)
    {
        IDbCommand cmd = GetDbCommand();
        cmd.CommandText = "SELECT * FROM" + table + "WHERE "+key+"= '" + value +"'";
        IDataReader reader = cmd.ExecuteReader();
        return reader;
    }

    public IDataReader GetAll(string table) {
        IDbCommand cmd = GetDbCommand();
        cmd.CommandText = "SELECT * FROM" + table;
        IDataReader reader = cmd.ExecuteReader();
        return reader;
    }


    public void DeleteByValue(string table, string key, string value)
    {
        IDbCommand cmd = GetDbCommand();
        cmd.CommandText = "DELETE FROM " + table + "WHERE " + key + "= '" + value + "'";
        cmd.ExecuteNonQuery();
    }
 
    public void DeleteAllData(string table)
    {
        IDbCommand cmd = GetDbCommand();
        cmd.CommandText = "DROP TABLE IF EXISTS " + table;
        cmd.ExecuteNonQuery();
    }

    
    public void Close() {
        db_connection.Close();
    }
}



