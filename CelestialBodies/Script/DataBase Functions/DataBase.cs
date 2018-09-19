using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Подключаем необходимые пространства имен
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.UI;

public class DataBase : MonoBehaviour {

    public SSLN ssln;

    Vector3 hitTransformTargit;
    Vector3 destinationPoint;
    public Transform target;

    public Text StarInformation;
    public string bodiesID;
    public bool _navigationTextPanelDB;

   public bool _StarObjInfo;
    public bool _PlanetsObjInfo;
    public bool _MoonsObjInfo;
    public bool _Constell;

    // Bodies Name
    string Name;
    string NameB;
    string NameF;
    string NameHD;
    string NameHIP;

    // Star Information
    string TypeObj;
    string Value;
    string Distance;
    string SpectralClass;
    string Radius;
    string Temperature;
    string Lumin;
    string Rotation;

    // Planets Information
    string planetsTypeObj;
    string palanetsNameSpectalClass;
    string planetsDistance;
    string planetsDiameter;
    string planetsPeriodRotation;
    string planetsTemperature;
    int planetsMoonsCount;
    string planetsParentStar;

    //public string SSName;
    //public string SSName2;
    //public bool _StarName, _PlanetName;

    public Text BodiesName_LMenu;
    public Text BodiesName_ContextMenu;
    public Text Information_LMenu;

    string sqlQuery;

    Move move;
    public GameObject trigcam;
    public GameObject targetName2;

    // Use this for initialization
    void Start () {
		bodiesID = target.transform.name;
		_navigationTextPanelDB = true;
        _StarObjInfo = true;
        move = trigcam.GetComponent<Move>();
    }

    void Update()
	{
		BodiesName_LMenu.text = ssln.bodiesName;
		BodiesName_ContextMenu.text = ssln.bodiesName_ContextMenu;
		Information_LMenu.text = ssln.Information;


        string conn = "URI=file:" + (Application.dataPath) + "/DataBase/CelestiaBodiesDataBase.db3"; //Путь к базе
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Открытие Базы данных
        IDbCommand dbcmd = dbconn.CreateCommand();

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || (_navigationTextPanelDB == true))
		{
            
            RaycastHit hit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
			{
                if (hit.collider != null)
                {
                    target = hit.transform;
                    targetName2 = target.parent.gameObject;

                    if (target.tag != "ObjName")
                    {
                        if (hit.collider.tag == "StarObj")
                        {
                            bodiesID = hit.transform.name;
                            _StarObjInfo = true;
                            _PlanetsObjInfo = false;
                            _MoonsObjInfo = false;
                        }
                        else if (hit.collider.tag == "StarObjSS")
                        {
                            bodiesID = hit.transform.name;
                            _StarObjInfo = true;
                            _PlanetsObjInfo = false;
                            _MoonsObjInfo = false;
                        }
                        else if (hit.collider.tag == "PlanetsObj")
                        {
                            bodiesID = hit.transform.name;
                            _StarObjInfo = false;
                            _PlanetsObjInfo = true;
                            _MoonsObjInfo = false;
                        }
                        else if (hit.collider.tag == "MoonObj")
                        {
                            _MoonsObjInfo = true;
                            _StarObjInfo = false;
                            _PlanetsObjInfo = false;
                        }
                    }
                    else if (target.tag == "ObjName")
                    {
                        if (targetName2.tag == "StarObj")
                        {
                            bodiesID = targetName2.name;
                            _StarObjInfo = true;
                            _PlanetsObjInfo = false;
                            _MoonsObjInfo = false;
                        }
                        else if (targetName2.tag == "StarObjSS")
                        {
                            bodiesID = targetName2.name;
                            _StarObjInfo = true;
                            _PlanetsObjInfo = false;
                            _MoonsObjInfo = false;
                        }
                        else if (targetName2.tag == "PlanetsObj")
                        {
                            bodiesID = targetName2.name;
                            _StarObjInfo = false;
                            _PlanetsObjInfo = true;
                            _MoonsObjInfo = false;
                        }
                        else if (targetName2.tag == "MoonObj")
                        {
                            _MoonsObjInfo = true;
                            _StarObjInfo = false;
                            _PlanetsObjInfo = false;
                        }
                    }
                }
			}

            if (_StarObjInfo)
            {
                string sqlQuery = "SELECT * FROM tbl_Star WHERE starID=('" + bodiesID + "')";
                dbcmd.CommandText = sqlQuery;
                object result = dbcmd.ExecuteScalar();
                if (result == null)
                {
                    Name = "0";
                    NameB = "0";
                    NameF = "0";
                    NameHD = "0";
                    NameHIP = "0";
                    Value = "0";
                    Distance = "0";
                    SpectralClass = "0";
                    Radius = "0";
                    Temperature = "0";
                    Lumin = "0";
                    Rotation = "0";

                    ssln.BodiesName(Name, NameB, NameF, NameHD, NameHIP);
                    ssln.StarInfo(TypeObj, Value, Distance, SpectralClass, Radius, Temperature, Lumin, Rotation);
                }
                else
                {


                    IDataReader reader = dbcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Name = reader.GetString(1);
                        NameB = reader.GetString(2);
                        NameF = reader.GetString(3);
                        NameHD = reader.GetString(4);
                        NameHIP = reader.GetString(5);
                        TypeObj = reader.GetString(6);
                        Value = reader.GetString(7);
                        Distance = reader.GetString(8);
                        SpectralClass = reader.GetString(9);
                        Radius = reader.GetString(10);
                        Temperature = reader.GetString(11);
                        Lumin = reader.GetString(12);
                        Rotation = reader.GetString(13);

                        ssln.BodiesName(Name, NameB, NameF, NameHD, NameHIP);
                        ssln.StarInfo(TypeObj, Value, Distance, SpectralClass, Radius, Temperature, Lumin, Rotation);
                    }
                    reader.Close();
                    reader = null;
                }
                dbcmd.Dispose();
                dbcmd = null;

                
            }
            if (_PlanetsObjInfo)
            {

                string sqlQuery = "SELECT * FROM tbl_Planets WHERE planetsID=('" + bodiesID + "')";
                dbcmd.CommandText = sqlQuery;

                object result = dbcmd.ExecuteScalar();
                if (result == null)
                {
                    Name = "0";

                    NameB = "0";
                    NameF = "0";
                    NameHD = "0";
                    NameHIP = "0";

                    palanetsNameSpectalClass = "0";
                    planetsDistance = "0";
                    planetsDiameter = "0";
                    planetsPeriodRotation = "0";
                    planetsTemperature = "0";
                    planetsMoonsCount = 0;

                    ssln.BodiesName(Name, NameB, NameF, NameHD, NameHIP);
                    ssln.PlanetsInformation(planetsTypeObj, planetsParentStar, palanetsNameSpectalClass, planetsDistance, planetsDiameter, planetsPeriodRotation, planetsTemperature, planetsMoonsCount);
                }
                else
                {
                    IDataReader reader = dbcmd.ExecuteReader();
                    while (reader.Read())
                    {

                        Name = reader.GetString(1);

                        NameB = "0";
                        NameF = "0";
                        NameHD = "0";
                        NameHIP = "0";

                        planetsTypeObj = reader.GetString(2);
                        palanetsNameSpectalClass = reader.GetString(3);
                        planetsDistance = reader.GetString(4);
                        planetsDiameter = reader.GetString(5);

                        planetsPeriodRotation = reader.GetString(6);
                        planetsTemperature = reader.GetString(7);
                        planetsMoonsCount = reader.GetInt32(8);

                        planetsParentStar = reader.GetString(9);

                        ssln.BodiesName(Name, NameB, NameF, NameHD, NameHIP);
                        ssln.PlanetsInformation(planetsTypeObj, planetsParentStar, palanetsNameSpectalClass, planetsDistance, planetsDiameter, planetsPeriodRotation, planetsTemperature, planetsMoonsCount);

                    }
                    reader.Close();
                    reader = null;
                }

                
                dbcmd.Dispose();
                dbcmd = null;
            }

            if (_MoonsObjInfo)
            {
                Name = "0";

                NameB = "0";
                NameF = "0";
                NameHD = "0";
                NameHIP = "0";

                palanetsNameSpectalClass = "0";
                planetsDistance = "0";
                planetsDiameter = "0";
                planetsPeriodRotation = "0";
                planetsTemperature = "0";
                planetsMoonsCount = 0;

                ssln.BodiesName(Name, NameB, NameF, NameHD, NameHIP);
                ssln.PlanetsInformation(planetsTypeObj, planetsParentStar, palanetsNameSpectalClass, planetsDistance, planetsDiameter, planetsPeriodRotation, planetsTemperature, planetsMoonsCount);
            }




            _navigationTextPanelDB = false;
		}

        dbconn.Close();
        dbconn = null;
    }
}
