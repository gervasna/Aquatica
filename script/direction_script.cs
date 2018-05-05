using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction_script : MonoBehaviour {
	public float a;
	public float b;
	int x_limite;//défini un point de direction sur l'axe x
	int speed = 20;
	//vector
	Vector3 dir;
	Vector3 pos;
	Vector3 Orig;
	Vector3 RotOr = new Vector3(-90, 90, -90);

	//angle
	float angle;
	float pi = 3.14f;
	float coeff;
	private float step;
	//booleans
	bool m_start;
	bool init;
	bool setBack;
	bool startdep;
	bool rotationEff;
	bool rot;
	bool GO;
	bool dep;
	//texts
	public UnityEngine.UI.Text a_value = null;
	public UnityEngine.UI.Text b_value = null;
	public UnityEngine.UI.Text a2_value = null;
	public UnityEngine.UI.Text b2_value = null;
	public GameObject boat;
	Rigidbody rb;
	LineRenderer li;
	IEnumerator coroutine;


	// Use this for initialization


	// Update is called once per frame
	public void Start() {
		//    Debug.Log("boat.transform.position.x =" + boat.transform.position.x);
		step = 20f * Time.deltaTime;
		init = true;
		GO = false;
		setBack = true;
		startdep = false;
		rotationEff = false;
		dep = false;
		rot = false;
		Orig = boat.transform.position;
		
	}
	public void OnMessage<T>(T value) {
		Debug.LogFormat("message Value :", value);
	}
	private void FixedUpdate() {

	}
	void Update() {
		int i = 0;
		li = GetComponent<LineRenderer>();
		rb = boat.GetComponent<Rigidbody>();

		a = float.Parse(a_value.text);
		b = float.Parse(b_value.text);
		//update de la valeur de l'équation
		incValue();
		if(a != 0) {
			x_limite = 20;
		} else
			x_limite = 0;
		if(a > 0) {
			dir.x = x_limite;
			dir.y = a * dir.x + b;

		} else {
			dir.x = -x_limite;
			dir.y = a * dir.x + b;
		}
		li.SetPosition(0, new Vector3(Orig.x, Orig.y + 5 * b, -10));
		li.SetPosition(1, new Vector3(Orig.x + (dir.x * 20), Orig.y + (dir.y * 20) + b, -10));
		//traces

		//calcul de l'angle
		CalculAngle();
		if(GO && init)
		//appelé quand appuie z
		{
			CalculDeplacement();
			startdep = true;
			GO = false;
		}
		if(dep) {

			CalculRotation();
			dep = false;
		}

		if(Input.GetKey(KeyCode.Backspace) && setBack) {
			Application.LoadLevel("direction1");
		}


		//rb.angularVelocity = new Vector3(0, 0, -1);
		Debug.Log("rot"+boat.transform.rotation.eulerAngles.x+"angle"+angle);

	}
	public void LateUpdate() {
		//Debug.Log(boat.transform.rotation.y);
		if(boat.transform.position.y >= Orig.y + 5 * b && boat.transform.position != Vector3.zero && startdep) {
			rb.velocity = new Vector3(0, 0, 0);
			dep = true;
			startdep = false;
		}
		if(rot) {
			calculRotationeff();
		}
		if(GO) {
		}
		if(rotationEff) {

			if(a != Mathf.Infinity) {
				if(dir.x != 0) {
					rb.velocity = new Vector3(dir.x, dir.y, 0);
				}

			}
			if(a == Mathf.Infinity) {
				rb.velocity = new Vector3(0, dir.y, 0);
				//   Debug.Log("a infini !");
			}
			rotationEff = false;
			m_start = false;
			x_limite = 20;

		}
	}
	IEnumerator Exemple() {
		yield return new WaitForSeconds(2);

	}
	public void getMessage(bool start) {
		rb.velocity = new Vector3(0, 0, 0);
		boat.transform.eulerAngles = RotOr;
		init = start;
		Orig = boat.transform.position;
	}
	public void outLimit(bool start) {
		Application.LoadLevel("lose");
	
	}
	public void rocher() {
		Application.LoadLevel("lose");

	}
	public void diplome() {
		Application.LoadLevel("diplome");
	}
	public void exercice2() {
		Application.LoadLevel("direction2");
	}
	public void exercice3() {
		Application.LoadLevel("direction3");
	}
	public void win() {
		Application.LoadLevel("menu");
	}
	private void CalculAngle() {
		if(dir.x != 0 || dir.y == 0)
			angle = Mathf.Atan(dir.y / dir.x);
		if(dir.x < 0) {
			if(angle == 0) {
				angle = 180;
			} else {
				angle = angle * 180 / pi;
			}
		} else if(dir.x > 0)
			if(angle == 0) {
				angle = -180;
			} else {
				angle = angle * 180 / pi;
			} else if(dir.x == 0 && dir.y == 0) {
			angle = 90;
		}

	}
	private void CalculRotation() {
		//Debug.Log("angle" + angle + "rot" + boat.transform.rotation.eulerAngles.x);

		if(angle>0) {
			rb.angularVelocity = new Vector3(0, 0, -1);
			rot = true;

		} else if(angle<0) {
			rb.angularVelocity = new Vector3(0, 0, 1);
			rot = true;
		}
	}
	public void go() {
		GO = true;
		//Debug.Log("go "+GO);
		//Debug.Log("init " + init);

	}
	private void calculRotationeff() {
		Debug.Log((angle < 0 && (boat.transform.rotation.eulerAngles.x <= 360 - angle)) && (boat.transform.rotation.eulerAngles.x >= 360));
		if((angle > 0 && boat.transform.rotation.eulerAngles.x > 360-angle )  || 
			((angle < 0 && (boat.transform.rotation.eulerAngles.x >=360+angle)) && (boat.transform.rotation.eulerAngles.x >= 270)) ) {
			rb.angularVelocity = new Vector3(0, 0, 0);
			rotationEff = true;
		}
	}
	private void CalculDeplacement() {
		if(boat.transform.position.y <= Orig.y +5 *b) {
			rb.velocity = new Vector3(0, 10, 0);
		} 
	}
	public void incValue() {
		a2_value.text = a_value.text;
		b2_value.text = b_value.text;
	}

}
