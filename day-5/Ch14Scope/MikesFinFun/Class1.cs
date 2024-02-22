namespace MikesFinFun {
    public class BankFunctions {
        public decimal Alpha(decimal value) {
            return MikesFavFun.DoubleIt(value);
        }

        public decimal Beta(decimal value) {
            return 0;
        }

    }
    internal static class MikesFavFun {
        static internal decimal DoubleIt(decimal dec) {
            return dec * 2;
        }
        static internal decimal TripleIt(decimal dec) {
            return dec * 3;
        }

    }

}
