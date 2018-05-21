using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulleteController : MonoBehaviour {

    float rotSpeed = 5;



    int gennsoku = 0;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }
        //if(this.gennsoku == 0)
        //{
        //    this.rotSpeed *= 1.1f;

        //    if (this.rotSpeed >= 15)
        //    {
        //        gennsoku = 1;
        //    }
        //}

        //if(gennsoku == 1)
        //{
        this.rotSpeed *= 0.98f;

        //    if(this.rotSpeed < 0)
        //    {
        //        gennsoku = 2;
        //        this.rotSpeed = 5;
        //    }
        //}
        transform.Rotate(0, 0, this.rotSpeed);

        //this.rotSpeed *= 0.96f;
    }
}
