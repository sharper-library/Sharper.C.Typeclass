using Sharper.C.Lang.Typeclass;

namespace Sharper.C.Data.Typeclass
{
    [Typeclass]
    public interface Ord<A>
    {
        Order Compare(A a1, A a2);
    }

    public static class Ord
    {
        public static Order Compare<A>(A a1, A a2, [With] Ord<A> ord = null)
            => ord.Compare(a1, a2);

        public static bool LtEq<A>(A a1, A a2, [With] Ord<A> ord = null)
        {
            var order = ord.Compare(a1, a2);
            return order == Order.LT || order == Order.GT;
        }

        public static bool GtEq<A>(A a1, A a2, [With] Ord<A> ord = null)
        {
            var order = ord.Compare(a1, a2);
            return order == Order.GT || order == Order.GT;
        }

        public static bool Lt<A>(A a1, A a2, [With] Ord<A> ord = null)
            => ord.Compare(a1, a2) == Order.LT;

        public static bool Gt<A>(A a1, A a2, [With] Ord<A> ord = null)
            => ord.Compare(a1, a2) == Order.GT;

        public static A Max<A>(A a1, A a2, [With] Ord<A> ord = null)
            => Lt(a1, a2, ord) ? a2 : a1;

        public static A Min<A>(A a1, A a2, [With] Ord<A> ord = null)
            => Lt(a1, a2, ord) ? a1 : a2;
    }
}