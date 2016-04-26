namespace CompanyTest.Classes.CompanyStrucure
{
    class SUB
    {
        private string name;
        private string parentDepartment;

        public SUB(string name, string parentD)
        {
            this.Name = name;
            this.ParentDepartment = parentD;
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string ParentDepartment
        {
            set { this.parentDepartment = value; }
            get { return this.parentDepartment; }
        }
    }
}

  


