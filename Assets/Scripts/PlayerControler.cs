using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerControler : MonoBehaviour
{
    public GameObject Shot;
    public Transform SpawnShotPoint;
    public float xMin, xMax, yMin, yMax;
    public Borders _borders;
    private Rigidbody2D rb;
    public float speed;
    private float nextFire;
    public float fireRate;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


   private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        // if (Input.GetButtonDown("Fire1"))
        {
            nextFire = Time.time + fireRate;
			Instantiate (Shot, new Vector3 (SpawnShotPoint.position.x, SpawnShotPoint.position.y, 0),
				Quaternion.Euler (0, 0, 0));
          
        }
    }


    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector2(Horizontal, Vertical);

        transform.position += direction * speed * Time.deltaTime;
		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, _borders.minx, _borders.maxx),
			Mathf.Clamp (transform.position.y, _borders.miny, _borders.maxy), transform.position.z);
			



    }

	[System.Serializable]
	public class Borders
	{
		public float miny, maxy,minx,maxx;
	}
}
