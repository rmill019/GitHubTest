using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine.UI;
using UnityEngine;

public class PrintNames : MonoBehaviour {

	private Text _namesTextBox;

	// Please add your full name to the array under this comment. Remember to have a comma before your name and put your name in double quotes. 
	private string [] names = {"Ray Millares"};

	private StringBuilder allNames = new StringBuilder();

	// Use this for initialization
	void Start () {

		_namesTextBox = GameObject.Find ("Names").GetComponent<Text>();

		for (int i = 0; i < names.Length; i++)
		{
			allNames.Append(names[i] + ", ");
		}

		foreach (string name in names)
		{
			_namesTextBox.text = allNames.ToString();
		}
		
	}
}
