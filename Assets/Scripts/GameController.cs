using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject pineObject;
	private bool paused = false;
		
	void Start ()
	{
		StartCoroutine (PineController.creartePines(pineObject));
	}
	
	void Update() {
		if (Input.GetKeyDown (KeyCode.Return)) {  
			Application.LoadLevel (0);  
		}  

		Pause ();
	}


	private void Pause() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(paused == false) {
				paused = true;
				print(paused);
				Time.timeScale = 0.0f;
			}
			else
			{
				paused = false;
				print(paused);
				Time.timeScale = 1.0f;
			}
		}
	}
}
