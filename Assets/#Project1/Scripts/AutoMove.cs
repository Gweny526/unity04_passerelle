using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    
    private enum Direction
    {
        right, up, forward
    }
    
    [SerializeField]private Direction direction = Direction.forward; 
    [SerializeField]private float speed = 1f;

    [SerializeField] private Color color = Color.red;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = color;
        //Debug.Log("Start!");
    }

    // Update is called once per frame
    void Update()
    {
        //declare un nouveau vecteur pour aller chercher la position
        //Vector3 pos = transform.position;
        //Vector3 pos = new(0, 0, 1);

        Vector3 dir;

        switch (direction)
        {
            case Direction.forward:
                dir = transform.forward; break;
            case Direction.up:
                dir = transform.up; break;
            case Direction.right: 
                dir = transform.right; break;
            default:
                dir = Vector3.zero;
                Debug.LogWarning($"{dir} is not handled.");
                break;
        }

        //transform.position += transform.forward * Time.deltaTime;
        //ici c'est la même chose mais on utilise le vecter3 dir qu'on a crée
        transform.position += dir * Time.deltaTime * speed;


    }
}
