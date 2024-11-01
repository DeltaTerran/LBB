﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour
{
    [SerializeField] private Slider speedSlider;
    void Start()
    {
        speedSlider.value = PlayerPrefs.GetFloat("speed", 1);
    }
    public void Open()
    {
        // Активируем этот объект, чтобы открыть окно.
        gameObject.SetActive(true);
    }
    public void Close()
    {
        // Деактивируем объект, чтобы закрыть окно.
        gameObject.SetActive(false);
    }
    public void OnSubmitName(string name)
    {
        Debug.Log(name);
    }
    public void OnSpeedValue(float speed)
    {
        Messenger<float>.Broadcast(GameEvent.SPEED_CHANGED, speed);
        PlayerPrefs.SetFloat("speed", speed);
        Debug.Log(speed);
    }
}
