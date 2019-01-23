namespace exxcellentSolution
{
    class FootballModel
    {
        public string Team { get; set; }
        public float Goals { get; set; }
        public float GoalsAllowed { get; set; }
        public float DifferenzG
        {
            get
            {
                if (Goals > GoalsAllowed)
                {
                    return Goals - GoalsAllowed;
                }

                return GoalsAllowed - Goals;
            }
        }
    }
}
