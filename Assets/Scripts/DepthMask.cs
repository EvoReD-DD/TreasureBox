
/*
SetRenderQueue.cs

”станавливает RenderQueue материалов объекта в режиме пробуждени€. Ёто приведет к экземпл€ру
материалов, поэтому сценарий не будет мешать другим визуализаторам, которые
ссылаютс€ на те же материалы.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Rendering/DepthMask")]

public class DepthMask : MonoBehaviour
{
	Renderer sceneMaterials;
	[SerializeField]
	protected int[] m_queues = new int[] { 3000 };

	protected void Awake()
	{
		Material[] materials = Renderer.materials;
		for (int i = 0; i < materials.Length && i < m_queues.Length; ++i)
		{
			materials[i].renderQueue = m_queues[i];
		}
	}
}
*/