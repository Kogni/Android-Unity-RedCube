using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour
{

    public Mesh mesh;
    public Material material;
    public int maxDepth;
    private int depth;
    public float childScale;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        //print("OnCollisionEnter, " + transform.name + " meets " + col.gameObject.name);
        if (depth < maxDepth)
        {
            new GameObject("Fractal Child").
                AddComponent<collision>().Initialize(this);
        }
        /*
        if (transform.name.Equals("Sphere"))
        {
            print("A1");
            if (col.gameObject.name.Equals("Cube"))
            {
                print("Populate 1");
                new GameObject("Fractal Child").AddComponent<collision>().Initialize(this);
            }
        }
        else if (transform.name.Equals("Cube"))
        {
            print("A2");
            if (col.gameObject.name.Equals("Sphere"))
            {
                print("Populate 2");
                new GameObject("Fractal Child").AddComponent<collision>().Initialize(this);
            }
        }
        else
        {
            print("B unknown=" + transform.name);
        }*/
    }

    private void Initialize(collision parent)
    {

        print("Initialize");
        mesh = parent.mesh;
        material = parent.material;
        maxDepth = parent.maxDepth;
        depth = parent.depth + 1;

        childScale = parent.childScale;
        transform.parent = parent.transform;
        transform.localScale = Vector3.one * childScale;
        transform.localPosition = Vector3.up * (0.5f + 0.5f * childScale);
        transform.position = Vector3.up * (0.5f + 0.5f * childScale);
    }
}
