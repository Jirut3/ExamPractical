using UnityEngine;



    public class ItemTriggerWithPlayerHandler : MonoBehaviour
    {
        private int score = 0;
        public GameManager gameManager;
        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (gameObject.CompareTag("Diamond"))
                {
                    ProcessTriggerWithDiamond();
                }else if (gameObject.CompareTag("Coin"))
                {
                    ProcessTriggerWithCoin();
                    score += 10;
                    gameManager.UpdateScore(score);
                }
                //Get the Inventory component from the player
                var inventory = other.GetComponent<Inventory>();
                //Add the collected item’s tag name to the inventory
                inventory.AddItem(gameObject.tag,1);
                //Destroy itself
                Destroy(gameObject);
            }
        }
        
        protected virtual void ProcessTriggerWithDiamond(){}
        protected virtual void ProcessTriggerWithCoin(){}
    }
