class Person
{
    private string name; // field
    public Person(string name)
    { this.name = name; }
    public string Name   // property
    {
        get { return name; } // get method
        set { name = value; }// set method
                             // or simply use { get; set; } to
                             // replace the above two lines
    }
}
