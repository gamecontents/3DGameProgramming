using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public Text txtScore;
    private int totScore = 0;

	// Use this for initialization
	void Start () {
        DispScore(0);
	}
	
	// Update is called once per frame
	public void DispScore(int score) {
        totScore += score;
        txtScore.text = "score <color=#ff0000>" + totScore.ToString() + "</color>";
    }
}
