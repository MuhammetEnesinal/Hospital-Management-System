using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetimUygulamasi
{
    internal class RandevuException : HastaneYonetimException
    {

        public RandevuException() : base("Randevu oluşturulurken bir hata oluştu.")
        {
        }

        // Mesaj parametresine sahip constructor
        public RandevuException(string message) : base(message)
        {
        }

        // Mesaj ve iç hata parametrelerine sahip constructor
        public RandevuException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
