using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageUI : MonoBehaviour {

	public List<float> mechHealths;
	public List<Image> mechImages;
	public List<GameObject> Limbs;

	public Color noDamage;
	public Color mediumDamage;
	public Color badDamage;

	// Use this for initialization
	void Start () {

	}

	void Update () {

		for (int i = 0; i < mechHealths.Count; i++) {

			if(mechHealths[i] == 3) {

				mechImages[i].color = noDamage;

			} else if(mechHealths[i] == 2) {

				mechImages[i].color = mediumDamage;

			} else if(mechHealths[i] == 1) {

				mechImages[i].color = badDamage;

			}

		}

	}


	public void HitMechPart (string part) {

		if(part == "Torso") {

			mechHealths[0] -= 1;

		} else if(part == "Right Leg") {

			mechHealths[1] -= 1;

		} else if(part == "Right Arm") {

			mechHealths[2] -= 1;

		} else if(part == "Left Leg") {

			mechHealths[3] -= 1;

		} else if(part == "Left Arm") {

			mechHealths[4] -= 1;

		}

	}


}
