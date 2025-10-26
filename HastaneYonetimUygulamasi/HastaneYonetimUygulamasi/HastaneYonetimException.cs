using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimUygulamasi
{
    internal class HastaneYonetimException : Exception
    {
          public HastaneYonetimException() : base("Hastane yönetim sisteminde bir hata oluştu.")
        {
        }

        // Mesaj parametresine sahip constructor
        public HastaneYonetimException(string message) : base(message)
        {
        }

        // Mesaj ve iç hata parametrelerine sahip constructor
        public HastaneYonetimException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
