using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter.Pattern
{
    public class LightningToUsbCAdapter : IUsbCPhone
    {
        private ILightningPhone _phone;

        public LightningToUsbCAdapter(ILightningPhone phone)
        {
            _phone = phone;
        }

        /// <inheritdoc />
        public void Charge()
        {
            _phone.Charge();
        }

        /// <inheritdoc />
        public void UseUsbC()
        {
            Console.WriteLine("USB-C cable plugged");
            _phone.UseLightning();
        }
    }
}
