using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Подключаем необходимые пространства имен
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.UI;




public class DataBaseObjName : MonoBehaviour
{

    string bodiesID, Name, NameB;
    string sqlQuery;
    public TextMesh text;
    bool _planetObj, _starObj, _constellObj, _readDB;


    public bool _name, _nameB;

    // Use this for initialization
    void Start()
    {
        bodiesID = gameObject.transform.name;
        if (gameObject.transform.tag == "PlanetsObj")
        {
            _planetObj = true;
            
        }
        else if (gameObject.transform.tag == "StarObj")
        {
            _starObj = true;
        }
        else if (gameObject.transform.tag == "StarObjSS")
        {
            _starObj = true;
        }
        else if (gameObject.transform.tag == "ConstellationLine")
        {
            _constellObj = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        string conn = "URI=file:" + (Application.dataPath) + "/DataBase/CelestiaBodiesDataBase.db3"; //Путь к базе
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Открытие Базы данных
        IDbCommand dbcmd = dbconn.CreateCommand();

        if (_planetObj)
        {
            sqlQuery = "SELECT * FROM tbl_Planets WHERE planetsID=('" + bodiesID + "')";
            _readDB = true;

            if (_name)
            {
                text.text = Name;
            }
            else if (_nameB)
            {
                text.text = NameB;
            }
        }
        else if (_starObj)
        {
            sqlQuery = "SELECT * FROM tbl_Star WHERE starID=('" + bodiesID + "')";
            _readDB = true;

            if (_name)
            {
                text.text = Name;
            }
            else if (_nameB)
            {
                text.text = NameB;
            }
            
        }
        else if (_constellObj)
        {
            sqlQuery = "SELECT * FROM tbl_Constellation WHERE constellID=('" + bodiesID + "')";
            _readDB = true;
            text.text = Name;
        }

        if (_readDB)
        {
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                Name = reader.GetString(1);
                if (_starObj)
                {
                    NameB = reader.GetString(2);
                }

            }
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
        }

        dbconn.Close();
        dbconn = null;
    }
}