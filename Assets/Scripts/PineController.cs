using UnityEngine;
using System.Collections;

public class PineController : MonoBehaviour {

	public Sprite color0;
	public Sprite color1;
	public Sprite color2;

	private const float halfScreenWidth = 7.5f;
	private const float belowBottomOfThScreenPosition = -9.0f;

	void Start () {
		rigidbody2D.velocity = new Vector2 (0.0f, 2.0f);

		SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
		int variant = Random.Range (0, 3);

		if(variant == 0)
			spriteRenderer.sprite = color0;
		else if (variant == 1)
			spriteRenderer.sprite = color1;
		else if (variant == 2)
			spriteRenderer.sprite = color2;
	}


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
