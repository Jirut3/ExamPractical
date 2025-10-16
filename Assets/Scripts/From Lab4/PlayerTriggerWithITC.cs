using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using UnityEngine;
    public class PlayerTriggerWithITC : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            //Get components from item object
            //Get the ItemTypeComponent component from the triggered object
            ItemTypeComponent itc = other.GetComponent<ItemTypeComponent>();
            
            //Get components from the player
            //Inventory
            var inventory = GetComponent<Inventory>();
            
            

            if (itc != null)
            {
                switch (itc.Type)
                {
                    case ItemType.COIN:
                        inventory.AddItem("COIN", 1);
                        break;
                    
                }
            }
            Destroy(other.gameObject,0);
        }
    }
