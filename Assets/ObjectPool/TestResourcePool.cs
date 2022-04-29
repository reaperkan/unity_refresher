using UnityEngine;

public class TestResourcePool : MonoBehaviour{
    private ResourcePool<GameObject> objectPool;
    
    [SerializeField]
    public GameObject enemyPrefab;
    void Start(){
        this.objectPool = new ResourcePool<GameObject>(Destroy,
            ()=> Instantiate(this.enemyPrefab));
    }

    private void Update() {
        var newPrefab = this.objectPool.Rent();

        this.objectPool.Return(newPrefab);
    }
}