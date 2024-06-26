using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflateItem : MonoBehaviour
{
    private Vector3 startScale;
    private Vector3 endScale;

    [SerializeField] private float scale = 2f;
    [SerializeField] private float timeToInflate = 2f;
    private float chrono = 0f;
    private bool isInflating = false;
    private bool isDeflating = false;
    // Start is called before the first frame update
    void Start()
    {
        startScale = transform.localScale;
        endScale = transform.localScale * scale;
    }

    // Update is called once per frame
    void Update()
    {
        chrono += Time.deltaTime;
        float ratio = chrono / timeToInflate;

        if (isInflating)
        {
            transform.localScale = Vector3.Lerp(
                startScale, endScale, ratio);
        }
        else if (isDeflating)
        {
            transform.localScale = Vector3.Lerp(
                endScale, startScale, ratio);
        }
    }

    public void Inflate()
    {
        chrono = 0f;
        isInflating = true;
        isDeflating = false;
    }

    public void Deflate()
    {
        chrono = 0f;
        isInflating = false;
        isDeflating = true;
    }
}
