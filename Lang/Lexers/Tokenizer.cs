using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Lang.Lexers
{
    public class Tokenizer : TokenizableStreamBase<String>
    {
        public Tokenizer(String source)

        //MVM - 18 June 2022
        //Fix #1. To allow Unicode chars to be used as variable and function names

        : base(() => source.ToCharArray().Select(i => i.ToString(CultureInfo.InvariantCulture)).ToList())
        //: base(() =>  source.EnumerateRunes().Select(i => i.ToString()).ToList() )        
      
        {
           
        } 
    }
}
