using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public GameObject tether;
    public float force;

    private bool m_Dragging = false;
    private bool m_Released = false;

    void OnMouseDown()
    {
        m_Dragging = true;
    }

    private void OnMouseUp()
    {
        m_Released = true;
        m_Dragging = false;

        Vector2 dir = tether.transform.position - transform.position;

        GetComponent<Rigidbody2D>().AddForce(dir * force);
    }

    void OnMouseDrag()
    {
        Vector3 mouse = Input.mousePosition;

        Vector3 world = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, -Camera.main.transform.position.z));

        transform.position = world;
    }

    // Update is called once per frame
    void Update ()
    {
        if (m_Released)
            return;

        if(!m_Dragging)
            transform.position = tether.transform.position;
    }
}
