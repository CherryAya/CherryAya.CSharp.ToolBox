namespace CherryAya.CSharp.ToolBox.netfw.Http.Entities
{
    /// <summary>
    /// 请求参数 简单模型
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// 参数
        /// </summary>
        public string Param { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// 无参构造方法
        /// </summary>
        public Parameters() { }

        /// <summary>
        /// 有参构造方法
        /// </summary>
        /// <param name="Param">参数</param>
        /// <param name="Value">值</param>
        public Parameters(string Param, object Value)
        {
            this.Param = Param;
            this.Value = Value;
        }

        /// <summary>
        /// ToString方法
        /// </summary>
        /// <returns>Param=Value</returns>
        public override string ToString()
        {
            return Param + "=" + Value.ToString();
        }
    }
}
