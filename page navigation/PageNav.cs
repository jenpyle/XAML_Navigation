namespace page_navigation
{
    public class PageNav
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public PageNav(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
