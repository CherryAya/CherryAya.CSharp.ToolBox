namespace CherryAya.CSharp.ToolBox.netfw.Http.Entities
{
    /// <summary>
    /// 文件 简单模型
    /// </summary>
    public class Files
    {
        /// <summary>
        /// 文件上传方法
        /// </summary>
        public UploadType Type { get; set; }
        /// <summary>
        /// 参数名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Byte数组
        /// </summary>
        public byte[] Bytes { get; set; }
        /// <summary>
        /// 文件名字
        /// </summary>
        public string FileName { get; set; }
    }

    /// <summary>
    /// 上传方法 枚举
    /// </summary>
    public enum UploadType
    {
        /// <summary>
        /// 本地路径上传
        /// </summary>
        byPath,
        /// <summary>
        /// Byte数组上传
        /// </summary>
        byBytes
    }
}
