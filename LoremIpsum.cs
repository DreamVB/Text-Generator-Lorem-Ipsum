// A drop in class to create random lorem ipsum text.
using System;
using System.Text;
using System.Windows.Forms;

namespace LoremIpsum
{
    public class TLoremIpsum
    {
        private int min_word;
        private int max_word;
        private int m_paragraphs;
        private bool m_includeLoremIpsum;
        private bool m_includeHtmlTags;
        //Create random obj
        private Random rnd = new Random();

        public int Paragraphs
        {
            get
            {
                return m_paragraphs;
            }
            set
            {
                m_paragraphs = value;
            }
        }

        public int MaxWord
        {
            get
            {
                return max_word;
            }
            set
            {
                max_word = value;
            }
        }

        public int MinWord
        {
            get
            {
                return min_word;
            }
            set
            {
                min_word = value;
            }
        }

        public bool IncludeHTMLParagraph
        {
            get
            {
                return m_includeHtmlTags;
            }
            set
            {
                m_includeHtmlTags = value;
            }
        }

        public bool Append_LoremIpsum
        {
            get
            {
                return m_includeLoremIpsum;
            }
            set
            {
                m_includeLoremIpsum = value;
            }
        }

        public StringBuilder LoremIpsum()
        {
            StringBuilder sb = new StringBuilder();
            
            if (this.Append_LoremIpsum)
            {
                //See if we need to include HTML Paragraph
                if (IncludeHTMLParagraph)
                {
                    //Append with HTML start paragraph tag
                    sb.Append("<p>Lorem ipsum dolor sit amet. ");
                }
                else
                {
                    //Append with out HTML paragraph tag
                    sb.Append("Lorem ipsum dolor sit amet. ");
                }
            }
            //Create paragraphs
            for (int x = 1; x <= this.Paragraphs;x++)
            {
                //Check if includeing HTML paragraphs
                if (this.IncludeHTMLParagraph)
                {
                    //Check if the tag is already added
                    if (sb.ToString().StartsWith("<p>",StringComparison.OrdinalIgnoreCase))
                    {
                        //Append random text and end paragraph tag
                        sb.Append(Get_Words() + "</p>" + Environment.NewLine + Environment.NewLine);
                    }
                    else
                    {
                        //Append HTML paragraph to random text
                        sb.Append("<p>" + Get_Words() + "</p>" + Environment.NewLine + Environment.NewLine);
                    }
                }
                else
                {
                    //Append random words to string builder along with the paragraph line breaks
                    sb.Append(Get_Words() + Environment.NewLine + Environment.NewLine);
                }
            }
            //Return string builder
            return sb;
        }

        private string Get_Words()
        {
            //To hold random words
            StringBuilder sb = new StringBuilder();

            const string words = "a,ac,accommodare,accumsan,accusata,ad,adhuc,adipisci,adipiscing" +
                   ",adolescens,adversarium,aenean,aeque,affert,agam,alia,alienum,aliquam,aliquet" +
                   ",aliquid,aliquip,altera,alterum,amet,an,ancillae,animal,ante,antiopam,aperiri" +
                   ",appareat,appetere,aptent,arcu,assueverit,at,atomorum,atqui,auctor,audire" +
                   ",augue,autem,bibendum,blandit,brute,causae,cetero,ceteros,civibus,class" +
                   ",commodo,commune,comprehensam,conceptam,conclusionemque,condimentum" +
                   ",congue,consectetuer,consectetur,consequat,consetetur,constituam,constituto" +
                   ",consul,contentiones,conubia,convallis,convenire,corrumpit,cras,cu,cubilia,cum" +
                   ",curabitur,curae,cursus,dapibus,debet,decore,definiebas,definitionem,definitiones" +
                   ",delectus,delenit,delicata,deseruisse,deserunt,deterruisset,detracto,detraxit,diam" +
                   ",dicam,dicant,dicat,dicit,dico,dicta,dictas,dictum,dictumst,dicunt,dignissim,dis" +
                   ",discere,disputationi,dissentiunt,docendi,doctus,dolor,dolore,dolorem,dolores,dolorum" +
                   ",doming,donec,dui,duis,duo,ea,eam,efficiantur,efficitur,egestas,eget,ei,eirmod,eius" +
                   ",elaboraret,electram,eleifend,elementum,elit,elitr,eloquentiam,enim,eos,epicurei" +
                   ",epicuri,equidem,erat,eripuit,eros,errem,error,erroribus,eruditi,esse,est,et,etiam,eu" +
                   ",euismod,eum,euripidis,evertitur,ex,expetenda,expetendis,explicari,fabellas,fabulas" +
                   ",facilis,facilisi,facilisis,falli,fames,fastidii,faucibus,felis,fermentum,ferri,feugait" +
                   ",feugiat,finibus,fringilla,fugit,fuisset,fusce,gloriatur,graece,graeci,graecis,graeco" +
                   ",gravida,gubergren,habemus,habeo,habitant,habitasse,hac,harum,has,hendrerit,himenaeos" +
                   ",hinc,his,homero,honestatis,iaculis,id,idque,ignota,iisque,imperdiet,impetus,in,inani" +
                   ",inceptos,inciderint,indoctum,inimicus,instructior,integer,intellegat,intellegebat" +
                   ",interdum,interesset,interpretaris,invenire,invidunt,ipsum,iriure,iudicabit,ius,iusto,";
            //Split the words string into an array.
            string[] items = words.Split(',');

            //Check min and max bounds
            if(this.MinWord > this.MaxWord){
                this.MaxWord = this.MinWord;
            }
            //Get the random number of words to use
            int n = rnd.Next(this.MinWord, this.MaxWord);

            //Create a string of length words
            for (int x = 0; x < n; x++)
            {
                //Get random number
                int r = rnd.Next(0, items.Length - 1);
                //Build the string
                sb.Append(items[r] + " ");
            }

            //Clear items array
            Array.Clear(items, 0, items.Length);
            //Return string.
           return sb.ToString().TrimEnd();
        }
    }
}
