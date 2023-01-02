using UnityEngine;
using System.Collections;
public class SettingsPopup : MonoBehaviour
{
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
        Debug.Log("Speed:" + speed);
    }
}
