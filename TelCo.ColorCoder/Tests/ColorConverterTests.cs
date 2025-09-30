using System.Drawing;
using TelCo.ColorCoder.Domain;
using Xunit;
using ColorConverter = TelCo.ColorCoder.Converters.ColorConverter;

namespace TelCo.ColorCoder.Tests
{
    public class ColorConverterTests
    {
        [Fact]
        public void GetColorFromPairNumber_PairNumber4_ReturnsWhiteAndBrown()
        {
            // Arrange
            int pairNumber = 4;

            // Act
            ColorPair result = ColorConverter.GetColorFromPairNumber(pairNumber);

            // Assert
            Assert.Equal(Color.White, result.majorColor);
            Assert.Equal(Color.Brown, result.minorColor);
        }

        [Fact]
        public void GetColorFromPairNumber_PairNumber5_ReturnsWhiteAndSlateGray()
        {
            // Arrange
            int pairNumber = 5;

            // Act
            ColorPair result = ColorConverter.GetColorFromPairNumber(pairNumber);

            // Assert
            Assert.Equal(Color.White, result.majorColor);
            Assert.Equal(Color.SlateGray, result.minorColor);
        }

        [Fact]
        public void GetColorFromPairNumber_PairNumber23_ReturnsVioletAndGreen()
        {
            // Arrange
            int pairNumber = 23;

            // Act
            ColorPair result = ColorConverter.GetColorFromPairNumber(pairNumber);

            // Assert
            Assert.Equal(Color.Violet, result.majorColor);
            Assert.Equal(Color.Green, result.minorColor);
        }

        [Fact]
        public void GetPairNumberFromColor_YellowAndGreen_Returns18()
        {
            // Arrange
            ColorPair colorPair = new ColorPair()
            {
                majorColor = Color.Yellow,
                minorColor = Color.Green
            };

            // Act
            int result = ColorConverter.GetPairNumberFromColor(colorPair);

            // Assert
            Assert.Equal(18, result);
        }

        [Fact]
        public void GetPairNumberFromColor_RedAndBlue_Returns6()
        {
            // Arrange
            ColorPair colorPair = new ColorPair()
            {
                majorColor = Color.Red,
                minorColor = Color.Blue
            };

            // Act
            int result = ColorConverter.GetPairNumberFromColor(colorPair);

            // Assert
            Assert.Equal(6, result);
        }
    }
}