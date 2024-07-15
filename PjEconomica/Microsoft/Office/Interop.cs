namespace Microsoft.Office
{
    internal class Interop
    {
        internal class Excel
        {
            internal class Application
            {
                public bool Visible { get; set; }
                public object? Workbooks { get; internal set; }
            }
        }
    }
}