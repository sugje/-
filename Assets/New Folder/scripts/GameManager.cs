using UnityEngine;
using System;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public enum EntityType
    {
        Player,
        Platform,
        Spike,
        Portal,
        None
    }

    [Serializable]
    public class EntityDictEntry
    {
        public EntityType EntityType;
        public GameObject GameObject;

        public EntityDictEntry(EntityType entityType, GameObject gameObject)
        {
            EntityType = entityType;
            GameObject = gameObject;
        }
       
    }[SerializeField] private List<EntityDictEntry> _entityList = new List<EntityDictEntry>();
             private Dictionary<EntityType, GameObject> _entityDict = new Dictionary<EntityType, GameObject>();

             [SerializeField] private List<MapData> _mapDatas = new List<MapData>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (EntityDictEntry entitydictEntry in _entityList)
        {
            _entityDict[entitydictEntry.EntityType] = entitydictEntry.GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
