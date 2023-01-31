using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Events;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using OmekaToUnity;


public class GameManager : MonoBehaviour
{
    public readonly string APIUrl = "http://serv-gi-34.utbm.fr/api/items?page=all";

    public long building5Id = 135;
    public long building13Id = 140;
    public long building14Id = 141;

    public bool fromBuilding5 = false;
    public bool fromBuilding13 = false; //not used for now
    public bool fromBuilding14 = false; //not used for now

    public bool toBuilding5 = false; // Not used for now
    public bool toBuilding13 = false;
    public bool toBuilding14 = false;

    public GameObject arrowFromBuilding5To13;
    public GameObject arrowFromBuilding5To14;


    public List<OmekaToUnity.OmekaToUnity> fluxTable = new List<OmekaToUnity.OmekaToUnity>();

    void Start()
    {
        arrowFromBuilding5To13.SetActive(false);
        arrowFromBuilding5To14.SetActive(false);

        StartCoroutine(get());
    }

    void Update()
    {

    }

    IEnumerator get()
    {

        UnityWebRequest www = UnityWebRequest.Get(APIUrl);

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError(www.error);
            yield break;
        }

        var omekaData = OmekaToUnity.OmekaToUnity.FromJson(www.downloadHandler.text);

        for (int i = 0; i < omekaData.Length; i++)
        {
            //Debug.Log(omekaData[i].Type[1]);
            if(omekaData[i].Type[1] == TypeElement.CrmE9Move)
            {
                fluxTable.Add(omekaData[i]);
                //Debug.Log("Item trouvé : " + omekaData[i].OId);
            }
        }


        //Parse the flux elements here (only the flux on index 0 is parsed for now)
        //Debug.Log(fluxTable[0]);

        var skosPrefLabel = fluxTable[0].SkosPrefLabel[0].Value;
        //Debug.Log(skosPrefLabel);

        var rdfsComment = fluxTable[0].RdfsComment[0].Value;
        //Debug.Log(rdfsComment);

        for (int i = 0; i < fluxTable[0].CrmP27MovedFrom.Length; i++)
        {
            if (fluxTable[0].CrmP27MovedFrom[i].ValueResourceId == building5Id)
            {
                fromBuilding5 = true;
                //Debug.Log(fluxTable[0].CrmP27MovedFrom[i].ValueResourceId);
            }
        }

        for (int i = 0; i < fluxTable[0].CrmP26MovedTo.Length; i++)
        {
            if (fluxTable[0].CrmP26MovedTo[i].ValueResourceId == building13Id)
            {
                toBuilding13 = true;
                //Debug.Log(fluxTable[0].CrmP26MovedTo[i].ValueResourceId);
            }else if (fluxTable[0].CrmP26MovedTo[i].ValueResourceId == building14Id)
            {
                toBuilding14 = true;
                //Debug.Log(fluxTable[0].CrmP26MovedTo[i].ValueResourceId);
            }
        }

        if(fromBuilding5 == true)
        {
            if(toBuilding13 == true)
            {
                arrowFromBuilding5To13.SetActive(true);
            }

            if(toBuilding14 == true)
            {
                arrowFromBuilding5To14.SetActive(true);
            }
        }
    }
}
