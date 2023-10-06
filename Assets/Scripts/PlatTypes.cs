using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatTypes : MonoBehaviour
{
    public Material type1;
    public Material type2;
    public Material type3;
    public Material type4;
    public Material type5;

    private PlayerController player;

    

    int type;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        var _Rdr = GetComponent<Renderer>();
        type = Random.Range(1,5);
        
        
        if(type == 1){
            _Rdr.material = type1;
        }
        if(type == 2){
            _Rdr.material = type2;
        }
        if(type == 3){
            _Rdr.material = type3;
        }
        if(type == 4){
            _Rdr.material = type4;
        }
        if(type == 5){
            _Rdr.material = type5;
        }
    }
    
    void OnCollisionEnter(Collision other){
        Collider collider = other.collider;
        print(type);
        if(other.gameObject.CompareTag("Player")){
            if(type == 1){
                print("hit");
            }
            if(type == 2){
                print("ReverseGrav");
                StartCoroutine(RevGrav());
            }
            if(type == 3){
                print("SpawnEnemy");
            }
            if(type == 4){
                print("PrintRefuel");
            }
            if(type == 5){
                print("Bounce");
            }
            
        }
        }
    
    IEnumerator RevGrav(){
        float grav = player.gravity;
        player.gravity *= -1;
        yield return new WaitForSeconds(5);
        player.gravity *= -1;
        Destroy(gameObject);
    }
    
}
