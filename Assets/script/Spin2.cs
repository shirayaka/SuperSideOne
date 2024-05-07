public class Spin2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 10f * Time.deltaTime, 0f, Space.Self);
    }
}
