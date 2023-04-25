using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
	private void Start()
	{
		StartCoroutine(DestroyAfterDelay(15f));
	}
	IEnumerator DestroyAfterDelay(float delay)
	{
		yield return new WaitForSeconds(delay);
		Destroy(gameObject);
	}
}

