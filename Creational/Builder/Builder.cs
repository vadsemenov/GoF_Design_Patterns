namespace Builder
{
    public class Builder
    {
        public string Specialization { get; set; }
        public int Experience { get; set; }
        public string Sex { get; set; }


        public Builder()
        {
            Specialization = "-";
            Experience = 0;
            Sex = "-";
        }

        public Builder SetSpecialization(string specialization)
        {
            Specialization = specialization;
            return this;
        }

        public Builder SetExperience(int expirience)
        {
            Experience = expirience;
            return this;
        }


        public Builder SetSex(string sex)
        {
            Sex = sex;
            return this;
        }
    }
}