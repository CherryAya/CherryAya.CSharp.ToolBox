namespace CherryAya.CSharp.ToolBox.Http.Entities
{
    /// <summary>
    /// HTTP协议报头 简单模型
    /// </summary>
    public class Headers
    {
        /// <summary>
        /// 头
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// 无参构造方法
        /// </summary>
        public Headers() { }

        /// <summary>
        /// 有参构造方法
        /// </summary>
        /// <param name="Header">头</param>
        /// <param name="Value">值</param>
        public Headers(string Header, object Value)
        {
            this.Header = Header;
            this.Value = Value;
        }

        /// <summary>
        /// ToString方法
        /// </summary>
        /// <returns>Header:Value</returns>
        public override string ToString()
        {
            return Header + ":" + Value.ToString();
        }
    }
}
