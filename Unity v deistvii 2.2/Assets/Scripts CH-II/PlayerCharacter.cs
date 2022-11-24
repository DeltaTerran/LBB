using UnityEngine;
using System.Collections;
public class PlayerCharacter : MonoBehaviour
{
    private int _health; 
    void Start()
    {
        // Инициализация переменной health.
        _health = 5;
    }
    public void Hurt(int damage)
    {
        // Уменьшение здоровья игрока.
        _health -= damage;
        Debug.Log("Health: " + _health);
    }
}
