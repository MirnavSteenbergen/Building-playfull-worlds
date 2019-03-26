using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float RotateSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        Vector3 Movevalues = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Movevalues *= MoveSpeed;
        controller.Move(Movevalues * Time.deltaTime);
    }
}
