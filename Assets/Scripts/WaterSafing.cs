using UnityEngine;
using System.Collections;

public class WaterSafing : MonoBehaviour {
	public float power;

	void OnTriggerStay(Collider collider)
	{
		if (collider.tag == "physical") {
			collider.GetComponent<Rigidbody>().AddForce (transform.up * power);
			
		}

	}
}