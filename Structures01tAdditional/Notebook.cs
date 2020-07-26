using System;
using System.Collections.Generic;
using System.Text;

namespace Structures01tAdditional
{
    struct Notebook
    {
        private string _model;
        private string _brand;
        private int _prise;

        public Notebook(string model, string brand, int prise)
        {
            _model = model;
            _brand = brand;
            _prise = prise;
        }

        public void Show()
        {
            Console.WriteLine($"model {_model}\nbrand {_brand}\nprise {_prise}");
        }
    }


}
