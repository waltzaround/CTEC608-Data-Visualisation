﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System; //This allows the IComparable Interface

public class Spawner : MonoBehaviour {
    public GameObject cube;
    public data dataMManager;
	// Use this for initialization
	void Start () {







	}

   public void Spawn(List<CurrencyData> data)
    {

    }
	
	// Update is called once per frame
	void Update () {
           
 
	}




void CreateCube(string name, string price, string volume) {
        GameObject spawnedCube;
        spawnedCube = Instantiate(cube, transform.position, transform.rotation) as GameObject;
        spawnedCube.GetComponent<cubeBehaviour>().SetVariables();
    }
}







