using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Personnages : MonoBehaviour {

	public GameObject[] personnages;
	public GameObject[] names;
	public int Max;
	public GameObject Unlock;
	public GameObject OK;
	public int Money;

	public AudioClip[] Sounds;
	AudioSource Source;

	void Start(){

		Source = GetComponent<AudioSource> ();

		//PlayerPrefs.SetInt ("Feuilles", 0);


		Max = 11;

		personnages [0].SetActive (false);
		personnages [1].SetActive (false);
		personnages [2].SetActive (false);
		personnages [3].SetActive (false);
		personnages [4].SetActive (false);
		personnages [5].SetActive (false);
		personnages [6].SetActive (false);
		personnages [7].SetActive (false);
		personnages [8].SetActive (false);
		personnages [9].SetActive (false);
		personnages [10].SetActive (false);

		personnages [PlayerPrefs.GetInt ("RealChoice")].SetActive (true);

		PlayerPrefs.GetInt ("Robert");
		PlayerPrefs.GetInt ("Chris");
		PlayerPrefs.GetInt ("Minol");
		PlayerPrefs.GetInt ("Malaron");
		PlayerPrefs.GetInt ("Didier");
		PlayerPrefs.GetInt ("Malouf");
		PlayerPrefs.GetInt ("Ben");
		PlayerPrefs.GetInt ("Rolland");
		PlayerPrefs.GetInt ("Francis");
		PlayerPrefs.GetInt ("Treport");
		PlayerPrefs.GetInt ("Hoarau");


		/*PlayerPrefs.SetInt ("Chris",2);
		PlayerPrefs.SetInt ("Minol",2);
		PlayerPrefs.SetInt ("Malaron",2);
		PlayerPrefs.SetInt ("Didier",2);
		PlayerPrefs.SetInt ("Malouf",2);
		PlayerPrefs.SetInt ("Ben",2);
		PlayerPrefs.SetInt ("Rolland",2);
		PlayerPrefs.SetInt ("Francis",2);
		PlayerPrefs.SetInt ("Treport",2);
		PlayerPrefs.SetInt ("Hoarau",2);*/




		Money = PlayerPrefs.GetInt ("Feuilles");

		PlayerPrefs.GetInt ("Choice");

		PlayerPrefs.SetInt ("RealChoice", 0);

		Unlock.SetActive (false);
		OK.SetActive (true);
	}

	public void Valider(){

		if(PlayerPrefs.GetInt("Choice") == 0){
			PlayerPrefs.SetInt("RealChoice", 0);
		}
		if(PlayerPrefs.GetInt("Choice") == 1){
			PlayerPrefs.SetInt("RealChoice", 1);
		}
		if(PlayerPrefs.GetInt("Choice") == 2){
			PlayerPrefs.SetInt("RealChoice", 2);
		}
		if(PlayerPrefs.GetInt("Choice") == 3){
			PlayerPrefs.SetInt("RealChoice", 3);
		}
		if(PlayerPrefs.GetInt("Choice") == 4){
			PlayerPrefs.SetInt("RealChoice", 4);
		}
		if(PlayerPrefs.GetInt("Choice") == 5){
			PlayerPrefs.SetInt("RealChoice", 5);
		}
		if(PlayerPrefs.GetInt("Choice") == 6){
			PlayerPrefs.SetInt("RealChoice", 6);
		}
		if(PlayerPrefs.GetInt("Choice") == 7){
			PlayerPrefs.SetInt("RealChoice", 7);
		}
		if(PlayerPrefs.GetInt("Choice") == 8){
			PlayerPrefs.SetInt("RealChoice", 8);
		}
		if (PlayerPrefs.GetInt ("Choice") == 9) {
			PlayerPrefs.SetInt ("RealChoice", 9);
		}
		if (PlayerPrefs.GetInt ("Choice") == 10) {
			PlayerPrefs.SetInt ("RealChoice", 10);
		}

		SceneManager.LoadScene (0, LoadSceneMode.Single);
	}

	public void Robert(){
		PlayerPrefs.SetInt ("Choice", 0);
		Source.PlayOneShot (Sounds[0], 0.5f);
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}
		personnages [0].SetActive (true);
		Unlock.SetActive (false);
		OK.SetActive (true);
	}

	public void Chris(){
		PlayerPrefs.SetInt ("Choice", 1);
		if (PlayerPrefs.GetInt ("Chris") == 1) {
			Source.PlayOneShot (Sounds [1], 0.5f);
		}
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}

		if (PlayerPrefs.GetInt ("Chris") == 1) {
			Unlock.SetActive (false);
			OK.SetActive (true);
			personnages [1].SetActive (true);
			names [1].SetActive (false);

		} else {
			Unlock.SetActive (true);
			OK.SetActive (false);
			names [1].SetActive (true);
		}
	}

	public void Minol(){
		PlayerPrefs.SetInt ("Choice", 2);
		if (PlayerPrefs.GetInt ("Minol") == 1) {
			Source.PlayOneShot (Sounds [2], 0.5f);
		}
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Minol") == 1) {
			Unlock.SetActive (false);
			OK.SetActive (true);
			personnages [2].SetActive (true);
			names [2].SetActive (false);
		} else {
			Unlock.SetActive (true);
			OK.SetActive (false);
			names [2].SetActive (true);
		}
	}

	public void Malaron(){
		PlayerPrefs.SetInt ("Choice", 3);
		if (PlayerPrefs.GetInt ("Malaron") == 1) {
			Source.PlayOneShot (Sounds [3], 0.5f);
		}
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Malaron") == 1) {
			Unlock.SetActive (false);
			OK.SetActive (true);
			personnages [3].SetActive (true);
			names [3].SetActive (false);
		} else {
			Unlock.SetActive (true);
			OK.SetActive (false);
			names [3].SetActive (true);
		}
	}

	public void Didier(){
		PlayerPrefs.SetInt ("Choice", 4);
		if (PlayerPrefs.GetInt ("Didier") == 1) {
			Source.PlayOneShot (Sounds [4], 0.7f);
		}
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Didier") == 1) {
			Unlock.SetActive (false);
			OK.SetActive (true);
			personnages [4].SetActive (true);
			names [4].SetActive (false);
		} else {
			Unlock.SetActive (true);
			OK.SetActive (false);
			names [4].SetActive (true);
		}
	}

	public void Malouf(){
		PlayerPrefs.SetInt ("Choice", 5);
		if (PlayerPrefs.GetInt ("Malouf") == 1) {
			Source.PlayOneShot (Sounds [5], 0.5f);
		}
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Malouf") == 1) {
			Unlock.SetActive (false);
			OK.SetActive (true);
			personnages [5].SetActive (true);
			names [5].SetActive (false);
		} else {
			Unlock.SetActive (true);
			OK.SetActive (false);
			names [5].SetActive (true);
		}
	}

	public void Ben(){
		PlayerPrefs.SetInt ("Choice", 6);
		if (PlayerPrefs.GetInt ("Ben") == 1) {
			Source.PlayOneShot (Sounds [6], 0.5f);
		}
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Ben") == 1) {
			Unlock.SetActive (false);
			OK.SetActive (true);
			personnages [6].SetActive (true);
			names [6].SetActive (false);

		} else {
			Unlock.SetActive (true);
			OK.SetActive (false);
			names [6].SetActive (true);
		}
	}

	public void Rolland(){
		PlayerPrefs.SetInt ("Choice", 7);
		if (PlayerPrefs.GetInt ("Rolland") == 1) {
			Source.PlayOneShot (Sounds [7], 0.5f);
		}
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Rolland") == 1) {
			Unlock.SetActive (false);
			OK.SetActive (true);
			personnages [7].SetActive (true);
			names [7].SetActive (false);
		} else {
			Unlock.SetActive (true);
			OK.SetActive (false);
			names [7].SetActive (true);
		}
	}

	public void Francis(){
		PlayerPrefs.SetInt ("Choice", 8);
		if (PlayerPrefs.GetInt ("Francis") == 1) {
			Source.PlayOneShot (Sounds [8], 0.5f);
		}
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Francis") == 1) {
			Unlock.SetActive (false);
			OK.SetActive (true);
			personnages [8].SetActive (true);
			names [8].SetActive (false);
		} else {
			Unlock.SetActive (true);
			OK.SetActive (false);
			names [8].SetActive (true);
		}
	}

	public void Treport(){
		PlayerPrefs.SetInt ("Choice", 9);
		if (PlayerPrefs.GetInt ("Treport") == 1) {
			Source.PlayOneShot (Sounds [9], 0.7f);
		}
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Treport") == 1) {
			Unlock.SetActive (false);
			OK.SetActive (true);
			personnages [9].SetActive (true);
			names [9].SetActive (false);
		} else {
		Unlock.SetActive (true);
		OK.SetActive (false);
		names [9].SetActive (true);
	}
	}

		public void Hoarau(){
		PlayerPrefs.SetInt ("Choice", 10);
		if (PlayerPrefs.GetInt ("Hoarau") == 1) {
			Source.PlayOneShot (Sounds [10], 0.5f);
		}
		for (int i = 0; i < Max; i++) {
			personnages [i].SetActive (false);
			names [i].SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Hoarau") == 1) {
			Unlock.SetActive (false);
			OK.SetActive (true);
			personnages [10].SetActive (true);
			names [10].SetActive (false);
		} else {
			Unlock.SetActive (true);
			OK.SetActive (false);
			names [10].SetActive (true);
		}
	}


	public void UnlockButton(){
		if (Money > 20) {
			Unlock.SetActive (false);
			OK.SetActive (true);
		}

		if (PlayerPrefs.GetInt ("Choice") == 1 && Money >= 20) {
			PlayerPrefs.SetInt ("Chris", 1);
			personnages [1].SetActive (true);
			Money = Money - 20;
			PlayerPrefs.SetInt ("Feuilles", Money);
			names [1].SetActive (false);
			Source.PlayOneShot (Sounds [1], 0.5f);
		}
		if (PlayerPrefs.GetInt ("Choice") == 2 && Money >= 20) {
			PlayerPrefs.SetInt ("Minol", 1);
			personnages [2].SetActive (true);
			Money = Money - 20;
			PlayerPrefs.SetInt ("Feuilles", Money);
			names [2].SetActive (false);
			Source.PlayOneShot (Sounds [2], 0.5f);
		}
		if (PlayerPrefs.GetInt ("Choice") == 3 && Money >= 20) {
			PlayerPrefs.SetInt ("Malaron", 1);
			personnages [3].SetActive (true);
			Money = Money - 20;
			PlayerPrefs.SetInt ("Feuilles", Money);
			names [3].SetActive (false);
			Source.PlayOneShot (Sounds [3], 0.7f);
		}
		if (PlayerPrefs.GetInt ("Choice") == 4 && Money >= 20) {
			PlayerPrefs.SetInt ("Didier", 1);
			personnages [4].SetActive (true);
			Money = Money - 20;
			PlayerPrefs.SetInt ("Feuilles", Money);
			names [4].SetActive (false);
			Source.PlayOneShot (Sounds [4], 0.7f);
		}
		if (PlayerPrefs.GetInt ("Choice") == 5 && Money >= 20) {
			PlayerPrefs.SetInt ("Malouf", 1);
			personnages [5].SetActive (true);
			Money = Money - 20;
			PlayerPrefs.SetInt ("Feuilles", Money);
			names [5].SetActive (false);
			Source.PlayOneShot (Sounds [5], 0.7f);
		}
		if (PlayerPrefs.GetInt ("Choice") == 6 && Money >= 20) {
			PlayerPrefs.SetInt ("Ben", 1);
			personnages [6].SetActive (true);
			Money = Money - 20;
			PlayerPrefs.SetInt ("Feuilles", Money);
			names [6].SetActive (false);
			Source.PlayOneShot (Sounds [6], 0.5f);
		}
		if (PlayerPrefs.GetInt ("Choice") == 7 && Money >= 20) {
			PlayerPrefs.SetInt ("Rolland", 1);
			personnages [7].SetActive (true);
			Money = Money - 20;
			PlayerPrefs.SetInt ("Feuilles", Money);
			names [7].SetActive (false);
			Source.PlayOneShot (Sounds [7], 0.5f);
		}
		if (PlayerPrefs.GetInt ("Choice") == 8 && Money >= 20) {
			PlayerPrefs.SetInt ("Francis", 1);
			personnages [8].SetActive (true);
			Money = Money - 20;
			PlayerPrefs.SetInt ("Feuilles", Money);
			names [8].SetActive (false);
			Source.PlayOneShot (Sounds [8], 0.5f);
		}
		if (PlayerPrefs.GetInt ("Choice") == 9 && Money >= 20) {
			PlayerPrefs.SetInt ("Treport", 1);
			personnages [9].SetActive (true);
			Money = Money - 20;
			PlayerPrefs.SetInt ("Feuilles", Money);
			names [9].SetActive (false);
			Source.PlayOneShot (Sounds [9], 0.7f);
		}
			if (PlayerPrefs.GetInt ("Choice") == 10 && Money >= 20) {
				PlayerPrefs.SetInt ("Hoarau", 1);
				personnages [10].SetActive (true);
				Money = Money - 20;
				PlayerPrefs.SetInt ("Feuilles", Money);
				names [10].SetActive (false);
			Source.PlayOneShot (Sounds [10], 0.7f);
			}
	}

	void Update(){
		PlayerPrefs.SetInt ("Feuilles", Money);
	}
}
