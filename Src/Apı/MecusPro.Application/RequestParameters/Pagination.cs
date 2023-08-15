namespace MecusPro.Application.RequestParameters
{
    public class Pagination
    {
        private int _page = 1;
        public int Page { get { return _page; } set { _page = value > 0 ? value : _page; } }

        private int _size = 5;
        public int Size { get { return _size; } set { _size = value > 0 ? value : _size; } }
    }
}
