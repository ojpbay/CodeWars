using NUnit.Framework;
using System.Linq;

namespace CodeWars
{
    public static class ElectronicsShopResult
    {
        /*
         * Complete the getMoneySpent function below.
         */
        public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            // get the most expensive keyboard
            var maxKeyboard = keyboards.Where(k => k < b).OrderByDescending(x => x).FirstOrDefault();

            // get the most expensive drive you can afford
            var maxAffordableDrive = drives.Where(d => d <= b - maxKeyboard).OrderByDescending(x => x).FirstOrDefault();

            // get the most expensive drive
            var maxDrive = drives.Where(d => d < b).OrderByDescending(x => x).FirstOrDefault();

            // get the most expensive keyboard you can afford
            var maxAffordableKeyboard = keyboards.Where(k => k <= b - maxDrive).OrderByDescending(x => x).FirstOrDefault();

            var maxKeyboardTotal = maxKeyboard + maxAffordableDrive;
            var maxDriveTotal = maxDrive + maxAffordableKeyboard;

            if (maxAffordableDrive == 0 || maxAffordableKeyboard == 0)
            {
                return -1;
            }


            return maxKeyboardTotal > maxDriveTotal ? maxKeyboardTotal : maxDriveTotal;
        }
    }

    [TestFixture]
    public class ElectronicsShopSolution
    {
        [Test]
        public void CheaperKeyboardDriveAndExpensiveDrive()
        {
            var keyboards = new int[] { 3, 1 };
            var drives = new int[] { 5, 2, 8 };
            var budget = 10;

            var result = ElectronicsShopResult.getMoneySpent(keyboards, drives, budget);

            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void CannotAffordBothKeyboardAndDrive()
        {
            var keyboards = new int[] { 4 };
            var drives = new int[] { 5 };
            var budget = 5;

            var result = ElectronicsShopResult.getMoneySpent(keyboards, drives, budget);

            Assert.That(result, Is.EqualTo(-1));
        }
    }
}
