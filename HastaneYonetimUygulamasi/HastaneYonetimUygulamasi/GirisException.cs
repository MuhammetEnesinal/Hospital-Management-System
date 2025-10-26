using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimUygulamasi
{
    internal class GirisException : HastaneYonetimException
    {
        // Parametresiz constructor
        public GirisException() : base("Giriş sırasında bir hata oluştu.")
        {
        }

        // Mesaj parametresine sahip constructor
        public GirisException(string message) : base(message)
        {
        }

        // Mesaj ve iç hata parametrelerine sahip constructor
        public GirisException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
