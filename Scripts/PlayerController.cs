using System.ComponentModel;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 6f;

   private void Update()
    {
        Movement();
    }


    private void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector3 direction = new Vector3(horizontal, 0f, 0f);

        transform.Translate(direction * (MoveSpeed * Time.deltaTime), Space.World);
    }
    





}
