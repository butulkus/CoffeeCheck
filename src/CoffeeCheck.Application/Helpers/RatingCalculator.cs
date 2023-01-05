namespace CoffeeCheck.Application.Helpers
{
    public static class RatingCalculator
    {
        public static double CalculateRating(double oldRating, double newRating, int votesQuantity)
        {
            var result = (oldRating + newRating) / votesQuantity;

            return result;
        }
    }
}
