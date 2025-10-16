using UnityEngine;


    public class ItemTypeComponent : MonoBehaviour
    {
        [SerializeField]
        protected ItemType m_ItemType;

        public ItemType Type
        {
            get { return m_ItemType; }
            set { m_ItemType = value; }
        }
    }
