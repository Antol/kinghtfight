﻿using UnityEngine;
using System.Collections;

public class Offence : MonoBehaviour {

	private GameObject _selectedBodyPart;
	public GameObject selectedBodyPart {
		set {
			if (_selectedBodyPart) {
				SpriteRenderer selectedRender = _selectedBodyPart.GetComponent("SpriteRenderer") as SpriteRenderer;
                if (selectedRender != null)
                    selectedRender.color = Color.white;
			}
			this._selectedBodyPart = value;

			if (this._selectedBodyPart) {
				SpriteRenderer render = this._selectedBodyPart.gameObject.GetComponent("SpriteRenderer") as SpriteRenderer;
				if (render != null){
					if (render.color == Color.white)
					{
						render.color = Color.red;
					}
					else {
						render.color = Color.blue;
					}
				}
			}

		}
		get {
			return this._selectedBodyPart;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
