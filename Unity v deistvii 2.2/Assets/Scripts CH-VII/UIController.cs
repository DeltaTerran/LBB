using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	[SerializeField] private Text scoreLabel;
	[SerializeField] private SettingsPopup settingsPopup;

	// Use this for initialization
	void Start () {
		// Закрываем всплывающее окно в момент начала игры
		settingsPopup.Close();
	}

	public void OnOpenSettings()
    {
		// Заменяем отладочный текст методом всплывающего окна. 
		settingsPopup.Open();

	}
	// Update is called once per frame
	void Update () {
		scoreLabel.text = Time.realtimeSinceStartup.ToString();
	}
}
