using UnityEngine;
using System.Collections;

public class clickselect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool isSelected;

    private void OnSelected()
    {
        isSelected = true;
        GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnUnselected()
    {
        isSelected = false;
        GetComponent<Renderer>().material.color = Color.white;
    }
}
