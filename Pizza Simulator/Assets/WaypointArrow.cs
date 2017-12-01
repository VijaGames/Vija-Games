 using UnityEngine;
 using System.Collections;

 public class WaypointArrow : MonoBehaviour
 {
     private GameObject target;
     private Vector3 targetPoint;
     private Quaternion targetRotation;

     void Start ()
     {
         target = GameObject.FindWithTag("CurrHouse");
     }

     void Update()
     {
         targetPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z) - transform.position;
         targetRotation = Quaternion.LookRotation (-targetPoint, Vector3.up);
         transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.0f);
     }
 }
