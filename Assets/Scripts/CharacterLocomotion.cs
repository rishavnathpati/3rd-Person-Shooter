using UnityEngine;

public class CharacterLocomotion : MonoBehaviour
{
    private static readonly int InputX = Animator.StringToHash("InputX");
    private static readonly int InputY = Animator.StringToHash("InputY");
    private Animator animator;
    private Vector2 input;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        animator.SetFloat(InputX, input.x);
        animator.SetFloat(InputY, input.y);
    }
}