using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    [SerializeField]
    private float m_MovementSpeed;

    [SerializeField]
    private float m_YawSpeed;

    private float m_Yaw;

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            m_Yaw -= m_YawSpeed; 
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            m_Yaw += m_YawSpeed;
        }
        else
        {
            m_Yaw = 0;
        }

        transform.Rotate(Vector3.up, m_Yaw * Time.deltaTime);

        transform.Translate(Vector3.forward * m_MovementSpeed * Time.deltaTime);
    }
}
