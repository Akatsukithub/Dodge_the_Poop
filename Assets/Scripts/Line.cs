using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public GameObject linePrefab;
    private float lineLength = 0.5f;
    private float lineWidth = 0.2f;
    private Vector2 startPosition;
    private Vector2 endPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isOver != true)
        {
            Draw();
        }
    }

    private void Draw()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            endPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if ((endPosition - startPosition).magnitude > lineLength)
        {
            GameObject pass = Instantiate(linePrefab, transform.position, Quaternion.identity) as GameObject;
            pass.transform.position = (startPosition + endPosition) / 2;
            pass.transform.right = (endPosition - startPosition).normalized;
            pass.transform.localScale = new Vector2((endPosition - startPosition).magnitude, lineWidth);

            startPosition = endPosition;
            Destroy(pass, 2f);
        }
    }
}
