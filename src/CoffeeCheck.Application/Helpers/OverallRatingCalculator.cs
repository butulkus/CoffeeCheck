namespace CoffeeCheck.Application.Helpers
{
    public static class OverallRatingCalculator
    {
        public static double? CalculateRating(params double?[] ratings)
        {
            ratings = ratings.Except(new double?[] { null }).ToArray();
            var result = ratings.Sum() / ratings.Length;

            return result;
        }
    }
}
