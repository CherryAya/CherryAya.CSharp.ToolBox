namespace CherryAya.CSharp.ToolBox.Http.Entities
{
    public class Headers
    {
        public string Header { get; set; }
        public object Value { get; set; }

        public Headers() { }

        public Headers(string Header, object Value)
        {
            this.Header = Header;
            this.Value = Value;
        }

        public override string ToString()
        {
            return Header + ":" + Value.ToString();
        }
    }
}
