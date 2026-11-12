using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private TemplatesLoader templatesLoader;

    [Header("Settings")]
    [Tooltip("Map parent transform.")]
    [SerializeField] private Transform templatesParentTransform;

    [Tooltip("Templates count on scene in one moment.")]
    [SerializeField] private int templatesPoolSize;

    [Tooltip("Tempalte size.")]
    [SerializeField] private Vector3 templateSize;

    [Tooltip("Template on scene.")]
    [SerializeField] private List<GameObject> spawnedTemplates;

    private void Awake()
    {
        if (this.templatesLoader == null) this.templatesLoader = GetComponent<TemplatesLoader>();
    }

    private void Update()
    {
        if (this.spawnedTemplates.Count < this.templatesPoolSize) 
        {
            SpawnTemplate();
        }
    }


    private void SpawnTemplate()
    {
        GameObject tamplate = this.templatesLoader.GetRandomTemplate();
        GameObject spawnedTemplate = Instantiate(tamplate, this.templatesParentTransform);

        GameObject lastSpawnedTemlate = this.spawnedTemplates.Last();
        Vector3 lastSpawnedTemplatePosition = lastSpawnedTemlate.transform.localPosition;
        Vector3 templatePosition = lastSpawnedTemplatePosition + this.templateSize;

        spawnedTemplate.transform.localPosition = templatePosition;
        this.spawnedTemplates.Add(spawnedTemplate);

    }

    public void DeleteTemplate(GameObject template) 
    {
        this.spawnedTemplates.Remove(template);
        Destroy(template);
    }
}
