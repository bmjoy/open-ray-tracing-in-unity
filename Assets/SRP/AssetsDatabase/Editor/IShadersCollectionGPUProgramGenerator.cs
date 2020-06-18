using System.Collections.Generic;

namespace OpenRT {
    using GUID = System.String;
    public interface IShaderCollectionGPUProgramGenerator {

        /// <summary>
        /// Short-hand for GenerateShaderCollectionFileContent then WriteToCustomShaderCollection
        /// </summary>
        bool ExportShaderCollection(SortedList<GUID, CustomShaderMeta> shadersImportMetaList);

        string GenerateShaderCollectionFileContent(SortedList<GUID, CustomShaderMeta> shadersImportMetaList);

        bool WriteToCustomShaderCollection(string content);
    }
}