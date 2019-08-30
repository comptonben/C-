namespace diffTypeArrays
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // override ToString so that the name is printed instead of the class
        public override string ToString()
        {
            return this.Name;
        }

    }
}
