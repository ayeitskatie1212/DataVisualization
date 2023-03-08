using UnityEngine;
using System.Collections;

public class DataLoader : MonoBehaviour {
    public DataVisualizer Visualizer;
	// Use this for initialization
	void Start () {
        TextAsset jsonData = Resources.Load<TextAsset>("population");
        string json = jsonData.text;
        SeriesArray data = JsonUtility.FromJson<SeriesArray>(json);
        Visualizer.CreateMeshes(data.AllData);

    }
	
	void Update () {
        // if (Input.GetKey("1"))
        // {
        //     Debug.Log("Year 1990");
        //     Visualizer.ActivateSeries(0);

        // }
        // else if (Input.GetKey("2"))
        // {
        //     Debug.Log("Year 1995");
        //     Visualizer.ActivateSeries(1);

        // }
        // else if (Input.GetKey("3"))
        // {
        //     Debug.Log("Year 2000");
        //     Visualizer.ActivateSeries(2);

        // }
	}
}
[System.Serializable]
public class SeriesArray
{
    public SeriesData[] AllData;
}