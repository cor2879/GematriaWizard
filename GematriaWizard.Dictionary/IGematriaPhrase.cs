using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GematriaWizard.Dictionary
{
    public interface IGematriaPhrase : IComparable<IGematriaPhrase>, IEquatable<IGematriaPhrase>
    {
        short NumericValue { get; }
    }

    public interface IHebrewGematriaPhrase : IGematriaPhrase, IComparable<IHebrewGematriaPhrase>, IEquatable<IHebrewGematriaPhrase>
    {
        short HebrewGematria { get; }
    }

    public interface IEnglishGematriaPhrase : IGematriaPhrase, IComparable<IEnglishGematriaPhrase>, IEquatable<IEnglishGematriaPhrase>
    {
        short EnglishGematria { get; }
    }

    public interface ISimpleGematriaPhrase : IGematriaPhrase, IComparable<ISimpleGematriaPhrase>, IEquatable<ISimpleGematriaPhrase>
    {
        short SimpleGematria { get; }
    }
}
