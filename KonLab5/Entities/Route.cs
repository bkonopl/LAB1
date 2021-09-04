namespace KonLab5.Entities
{
    public struct Route
    {
        public string targetA;
        public string targetB;

        public Route(string from, string to)
        {
            targetA = from;
            targetB = to;
        }
    }
}