using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siblings {
    public class Program {
        public static int largestSiblingLimit = 100000000;
        public static int getLargestSibling(int x){
            char _tempChar;
            char[] _arrayChar = x.ToString().Where(Char.IsDigit).ToArray();
            char[] _arrangedNumber = new char[_arrayChar.Length];
            string _arrangedStringNumbers = string.Empty;

            for (int i = 0; i <= _arrayChar.Length -1; i++){
                for (int j = 0; j <= _arrayChar.Length -1; j++) {
                    int next = j == _arrayChar.Length -1 ? _arrayChar.Length -1 : j+1;
                    if (_arrayChar[j] < _arrayChar[next]){
                        _tempChar = _arrayChar[next];
                        _arrayChar[next] = _arrayChar[j];
                        _arrayChar[j] = _tempChar;
                    }
                }
            }

            _arrangedStringNumbers = string.Join("", _arrayChar);
            if (int.Parse(_arrangedStringNumbers) > largestSiblingLimit) return -1;

            return int.Parse(_arrangedStringNumbers);
        }


        public static void Main(string[] args){
            Console.WriteLine("Input a number");
            string number = Console.ReadLine();

            Console.WriteLine("Bigger sibling:");
            if (number != null) Console.WriteLine(getLargestSibling(int.Parse(number)));
        }
    }
}