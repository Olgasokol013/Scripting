using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� NPC
    public int health = 5;
    //������� NPC
    public int level = 1;
    //�������� NPC
    public float speed = 1.2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health += level;
        print("�������� " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
