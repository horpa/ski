using UnityEngine;
using System.Collections;

public class Foo : MonoBehaviour {
	private const float halfScreenWidth = 7.5f;
	private const float belowBottomOfThScreenPosition = -9.0f;

	public static IEnumerator creartePines(GameObject pineObject)
	{
		while (true)
		{
			for (int i = 0; i < 50; i++)
			{
				Vector3 position = new Vector3 (Random.Range (-halfScreenWidth, halfScreenWidth), belowBottomOfThScreenPosition, 0.0f);
				Quaternion rotation = Quaternion.identity;
				Instantiate (pineObject, position, rotation);
				
				yield return new WaitForSeconds (0.1f);
			}
		}
	}
}
