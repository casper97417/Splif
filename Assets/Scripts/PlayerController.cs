using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int JumpPower = 350;
	public static bool CanJump = false;
	public static bool Score = true;
	public static float HightScore;
	public static bool IsDead = false;
	private int Feuilles;
	private int FeuillesGame;

	private int posx = Screen.width - Screen.width + 10;

	public Vector3 p;

	public AudioClip[] Sounds;
	AudioSource Source;


	// Use this for initialization
	void Start () {

		Camera camera = GetComponent<Camera> ();

		Source = GetComponent<AudioSource> ();

		HightScore = PlayerPrefs.GetFloat ("HS");

		Feuilles = PlayerPrefs.GetInt ("Feuilles");

		IsDead = false;


	}
	
	// Update is called once per frame
	void FixedUpdate () {



		if (Score == true) {
			ScoreManager.score = ScoreManager.score + 0.05f;
		}

		if(AndroidControls.jump == true && CanJump == true || Input.GetKey(KeyCode.Space) && CanJump){
				GetComponent<Rigidbody2D> ().AddForce (Vector3.up * JumpPower);
			Source.PlayOneShot (Sounds[0], 0.2f);



		}
		if (Input.GetAxis ("Horizontal") < 0 && transform.position.x > PauseButton.posx.x || AndroidControls.right == true) {
			transform.Translate (Vector3.left * Time.deltaTime * 4);
			ScoreManager.score = ScoreManager.score - 0.05f;

		}

		if (Input.GetAxis ("Horizontal") > 0 && transform.position.x < PauseButton.posx2.x || AndroidControls.left == true) {
			transform.Translate (Vector3.right * Time.deltaTime * 2);
			ScoreManager.score = ScoreManager.score + 0.05f;
		}

		/*if(Input.GetButton("Fire1")){
			this.transform.position = PauseButton.posx2;
		}*/




	}

	void OnCollisionEnter2D(Collision2D col){


		if (col.gameObject.tag == "Floor") {
			CanJump = true;

		}

		if (col.gameObject.tag == "Ennemy") {
			Source.PlayOneShot (Sounds[1], 0.3f);
			IsDead = true;
			Time.timeScale = 0;
			PlayerController.Score = false;
			PlayerPrefs.SetInt ("Feuilles", Feuilles +FeuillesGame);


			if (ScoreManager.score > HightScore) {
				
				PlayerPrefs.SetFloat ("HS", ScoreManager.score);
			}
		}
			
	}

	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Floor")
			CanJump = false;
		
	}

	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "Floor")
			CanJump = true;
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Drop")
			CanabisScore.Feuilles++;
		Source.PlayOneShot (Sounds[2], 0.1f);
		FeuillesGame++;
	}


}
