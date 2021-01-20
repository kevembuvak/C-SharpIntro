using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<Type> //Generic Listede kullanacağımız Type anlamına geliyor
    {

        Type[] items;
        public MyList() //constructor, new'landığı an bu çalışır
        {
            items = new Type[0]; //burda oluşturulması gerekiyor çünkü bu class new'landığı an yapılması gerekiyor
        }

        public void Add(Type item)
        {
            Type[] tempArray = items;
            items = new Type[items.Length + 1]; //new yaptığımızda elemanlar uçuyor diye önceki değerleri tempArray'e attık

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //tempArray.Length de olabilirdi

        }
    }
}
