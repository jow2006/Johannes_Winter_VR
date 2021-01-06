using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashLight : MonoBehaviour
{
	Light testLight;
	public float maxWaitTime = 4.0f;

	void Start()
	{
		testLight = GetComponent<Light>();
		StartCoroutine(Flashing());
	}

	IEnumerator Flashing()
	{
		while (true)
		{
			yield return new WaitForSeconds(maxWaitTime);
			testLight.enabled = !testLight.enabled;

		}
	}
}
