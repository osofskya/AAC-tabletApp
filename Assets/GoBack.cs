using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBack : MonoBehaviour {

    public GameObject[] panel;
    public List<GameObject> allPanels;

    public void KeepingTrack()
    {
        allPanels.Add(panel[0]);
        Debug.Log(allPanels);
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        panel = GameObject.FindGameObjectsWithTag("Panel");
    }
}
