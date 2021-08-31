using System;
using System.Text.RegularExpressions;

namespace CSharpMcCabeHalstead
{
    class Halstead
    {
        private string _sourceCode;
        private string _operators;
        private string _notOperators;
        private int _totalNumberOfOperators;
        private int _totalNumberOfOperands;
        private int _numberOfDistinctOperators;
        private int _numberOfDistinctOperands;

        public Halstead(string sourceCode)
        {
            this._sourceCode = sourceCode;
        }

        public int CountNumberOfDistinctOperators()
        {
            var operatorsPattern = this._operators;
            var operatorsMatches = Regex.Matches(this._sourceCode, operatorsPattern);

            this._numberOfDistinctOperators = 0;
            for (var currentMatchCount = 0; currentMatchCount < operatorsMatches.Count; currentMatchCount++)
            {
                var countRepetitiveOperators = 0;
                for (var nextMatchCount = currentMatchCount + 1; nextMatchCount < operatorsMatches.Count; nextMatchCount++)
                {
                    if (operatorsMatches[currentMatchCount].Value != operatorsMatches[nextMatchCount].Value)
                    {
                        continue;
                    }

                    countRepetitiveOperators++;
                }

                if (countRepetitiveOperators == 0)
                {
                    this._numberOfDistinctOperators++;
                }
            }

            return this._numberOfDistinctOperators;
        }

        public int CountNumberOfDistinctOperands()
        {
            const string replacementCode = " ";

            var operandsPattern = this._notOperators;
            var operandsRegex = new Regex(operandsPattern);
            this._sourceCode = operandsRegex.Replace(this._sourceCode, replacementCode);

            operandsPattern = @"(\b\w+\b)";
            var operandsMatches = Regex.Matches(this._sourceCode, operandsPattern);

            this._numberOfDistinctOperands = 0;
            for (var currentMatchCount = 0; currentMatchCount < operandsMatches.Count; currentMatchCount++)
            {
                var countReapeatOperands = 0;
                for (var nextMatchCount = currentMatchCount + 1; nextMatchCount < operandsMatches.Count; nextMatchCount++)
                {
                    if (operandsMatches[currentMatchCount].Value != operandsMatches[nextMatchCount].Value)
                    {
                        continue;
                    }

                    countReapeatOperands++;
                }

                if (countReapeatOperands == 0)
                {
                    this._numberOfDistinctOperands++;
                }
            }

            return this._numberOfDistinctOperands;
        }

        public int CountTotalNumberOfOperators()
        {
            var operatorsPattern = @"(\b.*\s\?\s.*\s\:\s.*)";
            var operatorsMatches = Regex.Matches(this._sourceCode, operatorsPattern);
            this._totalNumberOfOperators = operatorsMatches.Count;
            this._operators = operatorsPattern + "|";

            operatorsPattern = @"(~)|(\(int\))|(\(float\))|(\(string\))|(\(array\))|(\(object\))|(\(bool\))";
            operatorsMatches = Regex.Matches(this._sourceCode, operatorsPattern);
            this._totalNumberOfOperators += operatorsMatches.Count;
            this._operators += operatorsPattern + "|";

            operatorsPattern = @"(\+{1,2})|(\-{1,2})|(\*{1,2})|(\/)|(%)|(\={1,3})|(!=)|(>{1,2})|(<{1,2})|(>=)|(<=)|(<=>)|(\+=)|(\-=)|(\*=)|(\/=)|(%=)|(\*{2}=)|(&{1,2})|(\&{2}=)|(\|{1,2})|(\|{2}=)|(\^)|(~)|(=~)|(\.{1,3})|([\s\S]\,[\s])|(!)|(!~)|({)";
            operatorsMatches = Regex.Matches(this._sourceCode, operatorsPattern);
            this._totalNumberOfOperators += operatorsMatches.Count;
            this._operators += operatorsPattern + "|";

            operatorsPattern = @"(\bdelete\b)|(\bin\b)|(\binctanceof\b)|(\bnew\b)|(\bthis\b)|(\btypeof\b)|(\bvoid\b)|(\bgoto\b)";
            operatorsMatches = Regex.Matches(this._sourceCode, operatorsPattern);
            this._totalNumberOfOperators += operatorsMatches.Count;
            this._operators += operatorsPattern;

            return this._totalNumberOfOperators;
        }

        public int CountTotalNumberOfOperands()
        {
            const string replacementCode = " ";

            this._notOperators = this._operators;
            this._totalNumberOfOperands = 0;

            var operandsPattern = @"(\babstract\b)|(\bbreak\b)|(\bchar\b)|(\bcontinue\b)|(\bdo\b)|(\bevent\b)|(\bfinally\b)|(\bforeach\b)|(\bIn\b)|(\binternal\b)|(\bnamespace\b)|(\boperator\b)|(\bparams\b)|(\breadonly\b)|(\bsealed\b)|(\bstatic\b)|(\bthis\b)|(\btypeof\b)|(\bunsafe\b)|(\bvoid\b)|(\bas\b)|(\bbyte\b)|(\bchecked\b)|(\bdecimal\b)|(\bdouble\b)|(\bexplicit\b)|(\bfixed\b)|(\bgoto\b)|(\bin\b)|(\bis\b)|(\bnew\b)|(\bout\b)|(\bprivate\b)|(\bref\b)|(\bshort\b)|(\bstring\b)|(\bstring\b)|(\bstring\b)|(\bstring\b)|(\bstring\b)|(\bstring\b)|(\bstring\b)|(\bstring\b)|(\bstring\b)|(\bthrow\b)|(\buint\b)|(\bushort\b)|(\bvolatile\b)|(\bbase\b)|(\bcase\b)|(\bclass\b)|(\bfloat\b)|(\bif\b)|(\bint\b)|(\block\b)|(\bNull\b)|(\bprotected\b)|(\breturn\b)|(\bsizeof\b)|(\bstruct\b)|(\btrue\b)|(\bbulong\b)|(\busing\b)|(\bwhile\b)|(\bbool\b)|(\bcatch\b)|(\bconst\b)|(\bdelegate\b)|(\benum\b)|(\bfalse\b)|(\bfor\b)|(\bimplicit\b)|(\binterface\b)|(\blong\b)|(\bObject\b)|(\boverride\b)|(\bpublic\b)|(\bsbyte\b)|(\bstackalloc\b)|(\bswitch\b)|(\btry\b)|(\bunchecked\b)|(\bvirtual\b)|(\badd\b)|(\basync\b)|(\bdynamic\b)|(\bglobal\b)|(\bjoin\b)|(\bpartial\b)|(\bselect\b)|(\bvar\b)|(\byield\b)|(\balias\b)|(\bawait\b)|(\bFROM\b)|(\bgroup\b)|(\blet\b)|(\bset\b)|(\bwhere\b)|(\bascending\b)|(\bdescending\b)|(\bdescending\b)|(\binto\b)|(\borderby\b)|(\bremove\b)|(\bvalue\b)";
            this._notOperators += operandsPattern;

            operandsPattern = this._notOperators;
            var operandsRegex = new Regex(operandsPattern);
            this._sourceCode = operandsRegex.Replace(this._sourceCode, replacementCode);

            operandsPattern = @"(\b\w+\b)";
            var matches = Regex.Matches(this._sourceCode, operandsPattern);
            this._totalNumberOfOperands = matches.Count;

            return this._totalNumberOfOperands;
        }

        public int CalculateProgramVocabulary()
        {
            return (this._numberOfDistinctOperators + this._numberOfDistinctOperands);
        }

        public int CalculateProgramLength()
        {
            return (this._totalNumberOfOperators + this._totalNumberOfOperands);
        }


        public double CalculateProgramVolume()
        {
            return (this.CalculateProgramLength() * Math.Log(this.CalculateProgramVocabulary(), 2));
        }


        public double CalculateProgramDifficulty()
        {
            return (this._numberOfDistinctOperators / 2 * this._totalNumberOfOperands / _numberOfDistinctOperands);
        }

        public double CalculateProgramEffort()
        {
            return (this.CalculateProgramVolume() * this.CalculateProgramDifficulty());
        }

        public double CalculateProgramErrors()
        {
            return (this.CalculateProgramVolume() / 3000);
        }

    }
}
