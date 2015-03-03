using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebUI.Factory;

namespace WebUI.BLL
{
    internal class DALProvider
    {
        private static DALFactory _dalFactory;
        public static DALFactory DefaultProvide
        { 
            get 
            {
                return _dalFactory;
            }
        }
        static DALProvider()
        {
            _dalFactory = new DALFactory();
        }
    }
}
