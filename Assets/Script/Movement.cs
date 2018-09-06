using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private InputBehaviour _input;

	// Use this for initialization
	void Start ()
    {
        _input = GetComponent<InputBehaviour>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (_input.Tap())
        {
            Debug.Log("Move!");
        }

        if (_input.DoubleTap())
        {
            Debug.Log("Dash!");
        }



/*Dash code here*/

    }
}
