namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public static class CollectionHelper
    {
        public static CollectionResult<T> GetCompareResult<T>(
            IEnumerable<T> left, IEnumerable<T> right, IEqualityComparer<T> comparer)
            where T : notnull
        {

            return new CollectionResult<T>(left.InnerIntersect(right, comparer), 
                left.Except(right, comparer), right.Except(left, comparer));
        }

        private static IEnumerable<(T LeftItem, T RightItem)> InnerIntersect<T>(
            this IEnumerable<T> left, IEnumerable<T> right, IEqualityComparer<T> comparer)
            where T : notnull
        {
            var set = new HashSet<T>(right, comparer);

            foreach (T left_element in left)
            {
#pragma warning disable CS8600
                if (set.TryGetValue(left_element, out T right_element))
#pragma warning restore CS8600
                {
                    yield return (left_element, right_element);
                    set.Remove(right_element);
                }
            }
        }
    }

    public class CollectionResult<T> where T : notnull
    {
        public readonly IEnumerable<(T LeftItem, T RightItem)> IntersectItems;
        public readonly IEnumerable<T> LeftOnlys, RightOnlys;

        public CollectionResult(IEnumerable<(T LeftItem, T RightItem)> intersectItems, IEnumerable<T> leftOnlys, IEnumerable<T> rightOnlys)
        {
            IntersectItems = intersectItems;
            LeftOnlys = leftOnlys;
            RightOnlys = rightOnlys;
        }
    }
}