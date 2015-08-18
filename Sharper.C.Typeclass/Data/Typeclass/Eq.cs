using Sharper.C.Lang.Typeclass;

namespace Sharper.C.Data.Typeclass
{
    [Typeclass]
    public interface Eq<A>
    {
        bool Equal(A a1, A a2);
    }

    public static class Eq
    {
        public static bool Equal<A>(A a1, A a2, [With] Eq<A> eq = null)
            => eq.Equal(a1, a2);

        public static bool NotEqual<A>(A a1, A a2, [With] Eq<A> eq = null)
            => !eq.Equal(a1, a2);
    }

    public enum Order
    {
        LT,
        EQ,
        GT
    }
}