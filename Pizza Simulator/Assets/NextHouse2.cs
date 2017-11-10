using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextHouse2 : MonoBehaviour {

	public GameObject obj1;
	public GameObject obj2;
	public bool isCurrentWaypoint;
	public NextHouse3 next;
	public Collider coll;
	public GameObject House;

   void Start()
   {
	   obj1.SetActive (false);
           obj2.SetActive (false);
   }

   // Toggle the Object's visibility if this house is the current waypoint.
   void Update()
   {
	   if (isCurrentWaypoint == true)
   	{
   		obj1.SetActive (true);
                   obj2.SetActive (true);
   	} else {
   		obj1.SetActive (false);
                   obj2.SetActive (false);
   	}
        if(Input.GetKeyDown(KeyCode.Escape) == true)
	{
	   	Application.Quit();
	}
   }

   void OnTriggerEnter(Collider coll) {
	   isCurrentWaypoint = false;
	   next.isCurrentWaypoint = true;
   }

}
