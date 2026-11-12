using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplatesLoader : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("Loaded templates.")]
    [SerializeField] private List<GameObject> loadedTemplates = new List<GameObject>();

    [Tooltip("Templates folder name in resources.")]
    [SerializeField] private string templatesFolderName;

    [Tooltip("Template name prefix.")]
    [SerializeField] private string templatePrefix;

    [Tooltip("Templates count in resources folder.")]
    [SerializeField] private int templatesCount;

    public GameObject GetRandomTemplate()
    {

        int templateID = Random.Range(0, this.templatesCount);
        string templateName = this.templatePrefix + templateID;

        GameObject existingTemplate = this.loadedTemplates.Find(t => t != null && t.name == templateName);
        if (existingTemplate != null)
        {
            return existingTemplate;
        }

        string templateResourcePath = this.templatesFolderName + "/" + templateName;
        GameObject loadedTemplate = Resources.Load<GameObject>(templateResourcePath);

        if (loadedTemplate == null)
        {
            Debug.LogError($"Не удалось загрузить шаблон");
            return null;
        }

        this.loadedTemplates.Add(loadedTemplate);
        return loadedTemplate;
    }
}