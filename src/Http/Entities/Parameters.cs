namespace CherryAya.CSharp.ToolBox.Http.Entities
{
    public class Parameters
    {
        public string Param { get; set; }
        public object Value { get; set; }

        public Parameters() { }

        public Parameters(string Param, object Value)
        {
            this.Param = Param;
            this.Value = Value;
        }

        public override string ToString()
        {
            return Param + "=" + Value.ToString();
        }
    }
}
