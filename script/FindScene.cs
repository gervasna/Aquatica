using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindScene : MonoBehaviour {
	public UnityEngine.UI.Text m_replay;
	public UnityEngine.UI.Text m_nextLevel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void replay() {
		Application.LoadLevel(m_replay.text);
	}
	public void next_level() {
		Application.LoadLevel(m_replay.text);
	}
	public void load_menu() {
		Application.LoadLevel("menu");
	}
}
