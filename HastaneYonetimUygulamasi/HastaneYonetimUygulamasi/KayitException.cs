using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimUygulamasi
{
    internal class KayitException : HastaneYonetimException
    {
        public KayitException() : base("Hasta kaydı sırasında bir hata oluştu.")
        {
        }

        // Mesaj parametresine sahip constructor
        public KayitException(string message) : base(message)
        {

        }

        // Mesaj ve iç hata parametrelerine sahip constructor
        public KayitException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
