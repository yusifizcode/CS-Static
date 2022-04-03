using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public  class Student
    {
        public Student(string fullname, string groupNo, byte age)
        {
            this.FullName = fullname;
            this.GroupNo = groupNo;
            this.Age = age;
        }

        string _groupNo;
        string _fullName;
        public string FullName { get=>_fullName; set 
            {
                if (CheckFullname(value))
                    _fullName = value;
            } }
        public string GroupNo { get=>_groupNo; set 
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            } }
        public byte Age { get; set; }

        public static bool CheckGroupNo(string str)
        {
            if (!String.IsNullOrEmpty(str) && str.Length == 4 && char.IsUpper(str[0]))
            {
                int count = 0;
                for (int i = 1; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static bool CheckFullname(string str)
        {
            if (!String.IsNullOrEmpty(str) && char.IsUpper(str[0]) && char.IsLetter(str[str.Length-1]))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLower(str[i]) || (str[i] == ' ' && char.IsUpper(str[i+1])) )
                    {
                        return true;
                    }
                }
                return false;
            }
            return false ;
        }

    }
}
