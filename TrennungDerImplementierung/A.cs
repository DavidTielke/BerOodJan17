namespace TrennungDerImplementierung
{
    class A
    {
        private IB _ib;

        public A(IB ib)
        {
            _ib = ib;
        }

        public string DoA()
        {
            var input = _ib.DoB();
            var result = input.ToUpper();
            return result;
        }
    }
}