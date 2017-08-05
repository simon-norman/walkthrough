using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lefteye_skybox_controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Skybox skybox = gameObject.GetComponent<Skybox>();
        skybox.material = Resources.Load("nikontest") as Material;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
