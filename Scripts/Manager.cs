using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private GameObject go1;
    [SerializeField]
    private GameObject go2;
    public void button1()
    {
        go1.SetActive(true);
    }
    public void button2()
    {
        go2.SetActive(true);
        go1.SetActive(false);
    }
}
