using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	[SerializeField] private Text scoreLabel;
	[SerializeField] private SettingsPopup settingsPopup;
	private int _score;
	////Объявляем, какой метод отвечает на событие ENEMY_HIT.
	void Awake()
    {
		Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }
	////При разрушении объекта удаляем подписчика, чтобы избежать ошибок.
	void OnDestroy()
    {
		Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void OnEnemyHit()
    {
		_score += 1;
		scoreLabel.text = _score.ToString();
    }

    // Use this for initialization
    void Start () {
		_score = 0;
		scoreLabel.text = _score.ToString();
		// Закрываем всплывающее окно в момент начала игры
		settingsPopup.Close();
	}

	public void OnOpenSettings()
    {
		// Заменяем отладочный текст методом всплывающего окна. 
		settingsPopup.Open();

	}
	// Update is called once per frame
	
}
