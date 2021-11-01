namespace Users
{
    public class User
    {
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        private int LegalAge = 18;
        public bool IsOfLegalAge()
        {
            if (Age < LegalAge)
                return false;

            return true;

        }
    }
}