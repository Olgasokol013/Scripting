using UnityEngine;

public class NPC : MonoBehaviour
{
    //здоровье NPC
    public int health = 5;
    //уровень NPC
    public int level = 1;
    //скорость NPC
    public float speed = 1.2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health += level;
        print("здоровье " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
