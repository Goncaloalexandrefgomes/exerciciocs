using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace exerciciocs
{
    class RTFFile
    {

        private string _path = Application.StartupPath + "\\Resources\\poema.txt";
        private string _texto;

        public string Texto
        {
            get
            {
                _texto = File.ReadAllText(_path);
                return _texto;
            }
            set { _texto = value; }
        }

        public void Salvar()
        {
            File.WriteAllText(_path, _texto);
        }

        public void Reset()
        {
            _texto = "";
        }
    }
}