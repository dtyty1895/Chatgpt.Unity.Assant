﻿using System.Collections.Generic;
using UnityEngine;


namespace UniGLTF
{
    public class MeshWithMaterials
    {
        public Mesh Mesh;
        public Material[] Materials;

        /// <summary>
        /// SkinningInfo.ShouldSetRendererNodeAsBone を伝播させる。
        /// </summary>
        public bool ShouldSetRendererNodeAsBone = false;

        // 複数のノードから参照されうる
        public List<Renderer> Renderers = new List<Renderer>(); // SkinnedMeshRenderer or MeshRenderer
    }
}
