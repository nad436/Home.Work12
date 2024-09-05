namespace HomeWork
{
    public class DocumentationAttribute : Attribute
    {
        public string Author { get;  }
        public int Version { get; set; }

        public string Description { get; set; }
        

        public DocumentationAttribute(string author, string description = "")
        {
            Author = author;
           
        }
    }
}