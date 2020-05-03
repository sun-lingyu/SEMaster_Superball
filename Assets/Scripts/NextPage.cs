using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPage : MonoBehaviour
{
	public GameObject Pre;
	public GameObject Next;
 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ClickButtonWithEvent() {
		Pre.SetActive(false);
		Next.SetActive(true);
		
	}
}
