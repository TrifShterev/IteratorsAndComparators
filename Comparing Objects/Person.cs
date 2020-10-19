using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Comparing_Objects
{
  public  class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;
        public Person(string name, int age , string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo([AllowNull] Person other)
        {
            int result = 1;
            if (other!=null)
            {
                result = other.name.CompareTo(this.name);
                if (result==0)
                {
                    result = other.age.CompareTo(this.age);
                    if (result==0)
                    {
                        result = other.town.CompareTo(this.town);
                    }
                }
            }
            return result;
        }
    }
}
