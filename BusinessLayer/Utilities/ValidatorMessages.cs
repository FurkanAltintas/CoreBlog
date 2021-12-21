using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Utilities
{
    public class ValidatorMessages
    {
        public string NotEmpty { get; } = " alanı boş bırakamazsınız.";
        public string MaximumLenght { get; } = " karakterden büyük olmamalıdır.";
        public string MinimumLenght { get; } = " karakterden küçük olmamalıdır.";
        public string Equal { get; } = " uyuşmuyor.";

        #region Matches
        public class Matches
        {
            public string UppercaseLetter { get; } = " en az 1 büyük harf içermelidir.";
            public string LowercaseLetter { get; } = " en az 1 küçük harf içermelidir";
            public string Number { get; } = " en az bir rakam içermelidir";
        }
        #endregion
    }
}
