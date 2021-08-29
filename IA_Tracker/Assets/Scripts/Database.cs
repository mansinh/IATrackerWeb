using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

public class Database : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string connection = "URI=file:" + Application.persistentDataPath + "/Database";
        IDbConnection dbConnection = new SqliteConnection(connection);
        dbConnection.Open();

        IDbCommand dbcmd;
        IDataReader reader;

        dbcmd = dbConnection.CreateCommand();
        string createTable = "CREATE TABLE IF NOT EXISTS table_test (id INTEGER PRIMARY KEY, val INTEGER)";
        dbcmd.CommandText = createTable;
        reader = dbcmd.ExecuteReader();

        IDbCommand cmd = dbConnection.CreateCommand();
        cmd.CommandText = "INSERT INTO table_test (id,val) VALUES (0,5)";
        cmd.ExecuteNonQuery();

        cmd = dbConnection.CreateCommand();
        string query = "SELECT * FROM table_test";
        cmd.CommandText = query;
        reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Debug.Log("id: " + reader[0].ToString());
            Debug.Log("val: " + reader[1].ToString());
        }

        dbConnection.Close();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

