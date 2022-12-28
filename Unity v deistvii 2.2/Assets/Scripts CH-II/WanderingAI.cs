using UnityEngine;
using System.Collections;
public class WanderingAI : MonoBehaviour
{
    //Значения для скорости движения и расстояния, с которого начинается реакция на препятствие.
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;
    private bool _alive;
    [SerializeField] private GameObject fireballPrefab;
    private GameObject _fireball;
    void Start()
    {
        _alive = true;
    }
    void Update()
    {
        //Непрерывно движемся вперед в каждом кадре, несмотря на повороты.
        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
    //Луч находится в том же положении и нацеливается в том же направлении, что и персонаж.
    Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        //Бросаем луч с описанной вокруг него окружностью.
        if (Physics.SphereCast(ray, 0.75f, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;
            if (hitObject.GetComponent<PlayerCharacter>())
            {
                if (_fireball == null)
                {
                    _fireball = Instantiate(fireballPrefab) as GameObject;
                    _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                    _fireball.transform.rotation = transform.rotation;
                }
            }
            else if (hit.distance < obstacleRange)
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }

    }
    public void SetAlive(bool alive)
    {
        _alive = alive;
    }

}
