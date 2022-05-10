using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int  damage = 20;
    public float range = 100f;

    public Camera fpsCam;
    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            anim.SetBool("shot",true);
        }

    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            
            Enemy target = hit.transform.GetComponent<Enemy>();
            Debug.Log(target.currentHealth);
            if (target!=null)
            {
                target.TakeDamage(damage);

            }
        }

    }
}
