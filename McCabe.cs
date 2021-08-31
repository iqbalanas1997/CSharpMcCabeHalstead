using System.Text.RegularExpressions;

namespace CSharpMcCabeHalstead
{
    class McCabe
    {
        private readonly string _sourceCode;

        public McCabe(string sourceCode)
        {
            this._sourceCode = sourceCode;
        }

        public int CalculateCyclomaticComplexity()
        {
            const int numberOfConnectedComponentsCoefficient = 2;

            var numberOfGraphVertices = 0;
            var numberOfGraphArcs = 0;

            var loopsPattern = @"(\bswitch\b)";
            var loopsMatches = Regex.Matches(this._sourceCode, loopsPattern);
            numberOfGraphVertices += loopsMatches.Count;

            loopsPattern = @"(\bcase\b)|(\bdefault\b)|(\bfor\b)|(\bforeach\b)|(\bwhile\b)";
            loopsMatches = Regex.Matches(this._sourceCode, loopsPattern);
            numberOfGraphArcs += loopsMatches.Count;

            loopsPattern = @"(\bif\b)";
            loopsMatches = Regex.Matches(this._sourceCode, loopsPattern);
            numberOfGraphVertices += loopsMatches.Count;
            numberOfGraphArcs += 2 * loopsMatches.Count;

            numberOfGraphVertices++;
            return numberOfGraphArcs - numberOfGraphVertices + numberOfConnectedComponentsCoefficient;
        }

    }
}
