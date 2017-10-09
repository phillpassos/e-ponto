namespace e_ponto.Classes
{
    class Credentials
    {
        public string User { get; set; }
        public string Pass { get; set; }

        public bool IsValid()
        {
            return (!string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(Pass));
        }
    }
}
