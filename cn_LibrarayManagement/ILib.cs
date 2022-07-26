using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement1
{
    public interface ILib
    {
        bool searchB(string s);
        void borrow(string bor, DateTime t);
        void returnBook(string s);
        void Details();
    }
}