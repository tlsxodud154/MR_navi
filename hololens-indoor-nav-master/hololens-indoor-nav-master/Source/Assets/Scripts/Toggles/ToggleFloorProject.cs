using UnityEngine;
using System.Collections;

public class ToggleFloorProject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnSelect()
    {
        Toggle();
    }

    public static void Toggle()
    {
        if (MapContainer.Instance != null)
        {
            MapContainer.Instance.SetFloorProjection();
        }
    }
}
