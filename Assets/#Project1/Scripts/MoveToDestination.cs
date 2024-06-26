using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToDestination : MonoBehaviour
{
    private Vector3 start;

    [SerializeField] private Vector3 end;

    [SerializeField] private float speed;
    private Color color;
    [SerializeField] Color startColor = Color.cyan;
    [SerializeField] Color endColor = Color.magenta;
    Renderer renderers;
    private bool movingForward = true;
    

    private float time;
    private float chrono = 0f;

    // Start is called before the first frame update
    void Start()
    {

        start = transform.position;
        time = Vector3.Distance(start, end) / speed;
    }

    // Update is called once per frame
    void Update()
    {
        chrono += Time.deltaTime;
        float ratio = chrono / time;
        renderers = GetComponent<Renderer>();

        if (ratio >= 1f)
        {
            movingForward = !movingForward;
            chrono = 0f;
            
        }

        if(movingForward)
        {
            transform.position = Vector3.Lerp(start, end, ratio);
            color = Color.Lerp(startColor, endColor, ratio);
            renderers.material.color = color;

        }
        else
        {
            transform.position = Vector3.Lerp(end, start, ratio);
            color = Color.Lerp(endColor, startColor, ratio);
            renderers.material.color = color;
        }
    }
}
