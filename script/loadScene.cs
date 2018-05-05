using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadScene : MonoBehaviour {
public void load_pirate()
    {
        Application.LoadLevel("boat3D");
    }
 public void load_direction1()
 {
    Application.LoadLevel("direction1");
 }
	public void load_scene(string scene) {
		Application.LoadLevel(scene);
	}
	public void load_direction2() {
		Application.LoadLevel("direction2");
	}
	public void load_direction3() {
		Application.LoadLevel("direction3");
	}
	public void load_direction4() {
		Application.LoadLevel("direction4");
	}
	public void quit()
    {
        Application.Quit();
    }
    public void load_menu()
    {
        Application.LoadLevel("menu");
    }
    public void load_Academie()
    {
        Application.LoadLevel("academie");
    }

	public loadScene() {
	}
}
