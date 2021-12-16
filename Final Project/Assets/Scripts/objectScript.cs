using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectScript : MonoBehaviour
{
    Renderer objRenderer;
    float timer = 0f;
    [SerializeField]
    private float colorChangeTime;
    float yPos;
    [SerializeField]
    [Range(0, 5)]
    float yRange;
    
    public float floatSpeed;
    public bool isCorrect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objRenderer = GetComponent<Renderer>();
        timer += Time.deltaTime;

        if (timer >= colorChangeTime)
        {
            //Debug.Log("interval: " + colorChangeTime);
            Color newColor = Random.ColorHSV();
            objRenderer.material.color = newColor;
            timer = 0;
        }
        yPos = Mathf.PingPong(Time.time * floatSpeed, 1) * yRange;
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
    private void OnMouseDown()
    {
        if (isCorrect)
        {
            Destroy(this.gameObject);
        }
    }
}
