﻿using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine.UI;
using UnityEngine;

public class PrintNames : MonoBehaviour {

	private Text _namesTextBox;

	// Please add your full name to the array under this comment. Remember to have a comma before your name and put your name in double quotes. 
	private string [] names = {"Ray Millares"};

	// Use this for initialization
	void Start () {

		_namesTextBox = GameObject.Find ("Names").GetComponent<Text>();
		_namesTextBox.text = "";

		foreach (string name in names)
		{
			_namesTextBox.text += name + ", ";
		}
		
	}
}
