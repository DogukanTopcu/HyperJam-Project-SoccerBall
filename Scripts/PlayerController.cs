using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public static float movementSpeed;
    [SerializeField] public static float horizontalSpeed;

    public Transform rightLimit;
    public Transform leftLimit;


    float horizontal;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (this.gameObject.transform.position.x > leftLimit.position.x && this.gameObject.transform.position.x < rightLimit.position.x)
        {
            transform.Translate(new Vector3(horizontal * horizontalSpeed * Time.deltaTime, 0, movementSpeed * Time.deltaTime));
        }
        else
        {
            if (rightLimit.position.x - this.gameObject.transform.position.x <= this.gameObject.transform.position.x - leftLimit.position.x)
            {
                gameObject.transform.position = new Vector3(rightLimit.position.x - 0.4f, gameObject.transform.position.y, gameObject.transform.position.z);
            }
            else if (rightLimit.position.x - this.gameObject.transform.position.x >= this.gameObject.transform.position.x - leftLimit.position.x)
            {
                gameObject.transform.position = new Vector3(leftLimit.position.x + 0.4f, gameObject.transform.position.y, gameObject.transform.position.z);
            }
        }
    }


    private void OnMouseDrag()
    {
        float h = Input.GetAxis("Mouse X");
        if (this.gameObject.transform.position.x > leftLimit.position.x && this.gameObject.transform.position.x < rightLimit.position.x)
        {
            transform.Translate(new Vector3(h * horizontalSpeed * Time.deltaTime, 0, movementSpeed / 5 * Time.deltaTime));
        }
        else
        {
            if (rightLimit.position.x - this.gameObject.transform.position.x <= this.gameObject.transform.position.x - leftLimit.position.x)
            {
                gameObject.transform.position = new Vector3(rightLimit.position.x - 0.4f, gameObject.transform.position.y, gameObject.transform.position.z);
            }
            else if (rightLimit.position.x - this.gameObject.transform.position.x >= this.gameObject.transform.position.x - leftLimit.position.x)
            {
                gameObject.transform.position = new Vector3(leftLimit.position.x + 0.4f, gameObject.transform.position.y, gameObject.transform.position.z);
            }
        }

    }

}
